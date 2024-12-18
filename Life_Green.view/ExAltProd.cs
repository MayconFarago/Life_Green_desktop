﻿using Life_Green.model;
using Life_Green_dal;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Life_Green.view
{
    public partial class ExAltProd : Form
    {
        private DataTable produtosl;
        SqlConnection Connection;
        private DataTable produtosTable;
        public ExAltProd()
        {
            InitializeComponent();
        }

        private async void btnalterar_Click(object sender, EventArgs e)
        {
            Connection = FabricaConexao.getConnection();
            if (txtidprod.Text != "")
            {
                int mtr = 0;

                try
                {

                    mtr = Convert.ToInt32(txtidprod.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao converter! " +
                        "Digite somente números" + ex.Message);
                    txtidprod.Clear();
                }

                Produtos Prod = new Produtos();
                Prod.Id = mtr;

                Prod.NomeProd = txtnomeprod.Text;
                Prod.CategoriaProd = txtcategoria.Text;
                Prod.QtdProd = Convert.ToInt32(txtqtd.Text);
                Prod.PrecoProd = Convert.ToDouble(txtpreco.Text);
                Prod.MedidaProd = txtmedida.Text;

                produtoDal produtoDal = new produtoDal();

                try
                {
                    produtoDal.abrirConexao(Connection);
                    produtoDal.alterar(Connection, Prod);
                    lblInfoexprod.Text = ("Produtos alterados com sucesso!!");

                    txtnomeprod.Clear();
                    txtmedida.Clear();
                    txtcategoria.Clear();
                    txtqtd.Clear();
                    txtpreco.Clear();
                    txtidprod.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("falha : ", ex.Message);
                }
                finally
                { produtoDal.fecharConexao(Connection); }


            }
            else
            {

                MessageBox.Show("Insira o ID Para alterar ");
            }
            await Task.Delay(1500);
            lblInfoexprod.Text = "Qual a proxima Busca, Altereação ou Exclusão?";
            button1_Click(sender, e);
        }

        private async void btnbuscaprod_Click(object sender, EventArgs e)
        {

            Connection = FabricaConexao.getConnection();

            if (txtidprod.Text != "")
            {

                int mtr = 0;

                try
                {

                    mtr = Convert.ToInt32(txtidprod.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao converter! " +
                        "Digite somente números" + ex.Message);
                    txtidprod.Clear();
                }

                Produtos Prod = new Produtos();
                Prod.Id = mtr;

                produtoDal produtoDal = new produtoDal();

                try
                {
                    produtoDal.abrirConexao(Connection);
                    produtoDal.PesquisarProdId(Connection, Prod);
                    lblInfoexprod.Text = ("Segue as informações do produto.");
                    txtnomeprod.Text = Prod.NomeProd;
                    txtcategoria.Text = Prod.CategoriaProd;
                    txtqtd.Text = Convert.ToInt32(Prod.QtdProd).ToString();
                    txtpreco.Text = Convert.ToDouble(Prod.PrecoProd).ToString();
                    txtmedida.Text = Prod.MedidaProd;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("falha : ", ex.Message);
                }
                finally
                { produtoDal.fecharConexao(Connection); }

            }
            else
            {

                MessageBox.Show("Insira o ID Para Buscar ");
            }
            await Task.Delay(1500);
            lblInfoexprod.Text = "Qual a proxima Busca, Altereação ou Exclusão?";
            button1_Click(sender, e);
        }

        private async void btnexcluir_Click(object sender, EventArgs e)
        {
            Connection = FabricaConexao.getConnection();


            if (txtidprod.Text != "")
            {

                int mtr = 0;

                try
                {

                    mtr = Convert.ToInt32(txtidprod.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao converter! " +
                        "Digite somente números" + ex.Message);
                    txtidprod.Clear();
                }

                Produtos Prod = new Produtos();
                Prod.Id = mtr;

                produtoDal prodDal = new produtoDal();

                try
                {

                    prodDal.abrirConexao(Connection);
                    prodDal.excluir(Connection, Prod);

                    lblInfoexprod.Text = ("Produto excluido com sucesso!!");

                    txtnomeprod.Clear();
                    txtmedida.Clear();
                    txtcategoria.Clear();
                    txtqtd.Clear();
                    txtpreco.Clear();
                    txtidprod.Clear();


                }
                catch (Exception ex)
                {

                    {
                        MessageBox.Show("Falha ao excluir" + ex.Message);
                    }

                }
                finally
                { prodDal.fecharConexao(Connection); }

            }
            else
            {

                MessageBox.Show("Insira o ID Para Excluir ");
            }
            await Task.Delay(1500);
            lblInfoexprod.Text = "Qual a proxima Busca, Altereação ou Exclusão?";
            button1_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tela_login Tl = new Tela_login();
            Tl.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TelaApp telaApp = new TelaApp();
            telaApp.Show();
            this.Close();
        }

        private void ExAltProd_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {

                DataRowView rowView = (DataRowView)listBox1.SelectedItem;

                txtidprod.Text = rowView["Id"].ToString();
                txtnomeprod.Text = rowView["nomeProd"].ToString();
                txtcategoria.Text = rowView["categoriaProd"].ToString();
                txtpreco.Text = rowView["precoProd"].ToString() + "$";
                txtqtd.Text = rowView["qtdProd"].ToString();
                txtmedida.Text = rowView["medidaPord"].ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Connection = FabricaConexao.getConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Produtos", Connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                produtosTable = new DataTable();

                Connection.Open();
                adapter.Fill(produtosTable);
                Connection.Close();

                
                listBox1.DisplayMember = "nomeProd";
                listBox1.ValueMember = "id";
                listBox1.DataSource = produtosTable;
            
        
        }
    }
        
    
}
