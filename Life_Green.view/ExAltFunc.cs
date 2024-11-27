using Life_Green.model;
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

namespace Life_Green.view
{
    public partial class ExAltFunc : Form
    {

        SqlConnection Connection;
        private DataTable funcionariostab;
        public ExAltFunc()
        {
            InitializeComponent();
        }

        private async void btnbuscar_Click(object sender, EventArgs e)
        {
            Connection = FabricaConexao.getConnection();

            if (txtidfunc.Text != "")
            {

                int mtr = 0;

                try
                {

                    mtr = Convert.ToInt32(txtidfunc.Text);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao converter o ID" + " Por favor colocar somente Numeros" + ex.Message);
                    txtidfunc.Clear();
                }

                Funcionario Func = new Funcionario();
                Func.Id = mtr;

                funcionarioDal FuncDal = new funcionarioDal();

                try
                {

                    FuncDal.abrirConexao(Connection);
                    FuncDal.pesquisarFuncId(Connection, Func);
                    lblinfoeafunc.Text = "Segue Informações sobre o Funcionario.";
                    txtNome.Text = Func.Nome;
                    txtCargo.Text = Func.Cargo;
                    txtCPF.Text = Func.Cpffunc;
                    txtUsuario.Text = Func.NomeUser;
                    txtSenha.Text = Func.SenhaUser;


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Falha ao Buscar :" + ex.Message);

                }
                finally { FuncDal.fecharConexao(Connection); }


            }
            else
            {
                MessageBox.Show("Insira o ID Para Buscar ");

            }

            await Task.Delay(1500);
            lblinfoeafunc.Text = "Qual a proxima Busca, Altereação ou Exclusão?";
            btnlistar_Click(sender, e);
        }

        private async void btnsalvarfunc_Click(object sender, EventArgs e)
        {

            Connection = FabricaConexao.getConnection();


            if (txtidfunc.Text != "")
            {

                int mtr = 0;

                try
                {

                    mtr = Convert.ToInt32(txtidfunc.Text);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao converter o ID" + " Por favor colocar somente Numeros" + ex.Message);
                    txtidfunc.Clear();
                }

                Funcionario Func = new Funcionario();
                Func.Id = mtr;

                Func.Nome = txtNome.Text;
                Func.Cargo = txtCargo.Text;
                Func.Cpffunc = txtCPF.Text;
                Func.NomeUser = txtUsuario.Text;
                Func.SenhaUser = txtSenha.Text;

                funcionarioDal FuncDal = new funcionarioDal();

                try
                {

                    FuncDal.abrirConexao(Connection);
                    FuncDal.alterar(Connection, Func);
                    lblinfoeafunc.Text = "Alteração feita com sucesso!!";
                    await Task.Delay(1500);
                    txtNome.Clear();
                    txtCargo.Clear();
                    txtCPF.Clear();
                    txtUsuario.Clear();
                    txtSenha.Clear();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Falha ao Alterar:" + ex.Message);

                }
                finally { FuncDal.fecharConexao(Connection); }


            }
            else
            {
                MessageBox.Show("Insira o ID Para Alterar ");

            }

            await Task.Delay(1500);
            lblinfoeafunc.Text = "Qual a proxima Busca, Altereação ou Exclusão?";
            btnlistar_Click(sender, e);
        }

        private async void btnexcluir_Click(object sender, EventArgs e)
        {

            Connection = FabricaConexao.getConnection();


            if (txtidfunc.Text != "")
            {

                int mtr = 0;

                try
                {

                    mtr = Convert.ToInt32(txtidfunc.Text);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao converter o ID" + " Por favor colocar somente Numeros" + ex.Message);
                    txtidfunc.Clear();
                }

                Funcionario Func = new Funcionario();
                Func.Id = mtr;

                funcionarioDal FuncDal = new funcionarioDal();

                try
                {

                    FuncDal.abrirConexao(Connection);
                    FuncDal.excluir(Connection, Func);
                    lblinfoeafunc.Text = "Usuario Excluido com sucesso!!";
                    await Task.Delay(1500);
                    txtNome.Clear();
                    txtCargo.Clear();
                    txtCPF.Clear();
                    txtUsuario.Clear();
                    txtSenha.Clear();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Falha ao Excluir :" + ex.Message);

                }
                finally { FuncDal.fecharConexao(Connection); }


            }
            else
            {
                MessageBox.Show("Insira o ID Para Excluir ");

            }

            await Task.Delay(1500);
            lblinfoeafunc.Text = "Qual a proxima Busca, Altereação ou Exclusão?";
            btnlistar_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            TelaApp Ta = new TelaApp();
            Ta.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tela_login Tl = new Tela_login();
            Tl.Show();
            this.Hide();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            Connection = FabricaConexao.getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Funcionarios", Connection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            funcionariostab = new DataTable();

            Connection.Open();
            adapter.Fill(funcionariostab);
            Connection.Close();


            listBox1.DisplayMember = "nome";
            listBox1.ValueMember = "id";
            listBox1.DataSource = funcionariostab;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {

                DataRowView rowView = (DataRowView)listBox1.SelectedItem;

                txtidfunc.Text = rowView["Id"].ToString();
                txtNome.Text = rowView["nome"].ToString();
                txtCargo.Text = rowView["cargo"].ToString();
                txtCPF.Text = rowView["cpffunc"].ToString();
                txtUsuario.Text = rowView["nomeUser"].ToString();
                txtSenha.Text = rowView["senhaUser"].ToString();
            }
        }
    }
}
