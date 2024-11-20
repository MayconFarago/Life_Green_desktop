using Life_Green.model;
using Life_Green_dal;
using Microsoft.Data.Sql;
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
    public partial class CadProd : Form
    {
        SqlConnection Connection;
        public CadProd()
        {
            InitializeComponent();


        }

        private async void btncadprod_Click(object? sender, EventArgs e)
        {
            Connection = FabricaConexao.getConnection();
            Produtos Prod = new Produtos();

            Prod.NomeProd = txtnomeprod.Text;
            Prod.CategoriaProd = txtcategoria.Text;
            Prod.QtdProd = Convert.ToInt32((txtqtd.Text));
            Prod.PrecoProd = Convert.ToDouble((txtpreco.Text).ToString());
            Prod.MedidaProd = txtmedida.Text;
            

            produtoDal produtoDal = new produtoDal();

            try
            {
                if (string.IsNullOrWhiteSpace(txtcategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtnomeprod.Text)  ||
                    string.IsNullOrWhiteSpace(txtmedida.Text))
                    
                {

                    lblinfoCadProd.Text = "Garanta que todos os campos foram preenchido";
                    await Task.Delay(1000);
                    lblinfoCadProd.Text = "Atente-se com os capos que pede quantidade e preço";
                    await Task.Delay(1000);
                    lblinfoCadProd.Text = " os preenchedo somente com numeros";
                    await Task.Delay(1000);
                    lblinfoCadProd.Text = "e tente novamente";

                }
                else
                {
                    produtoDal.abrirConexao(Connection);

                    produtoDal.add(Connection, Prod);

                    lblinfoCadProd.Text = "Produto cadastrado com Sucesso !!";
                    await Task.Delay(1000);
                    txtnomeprod.Clear();
                    txtcategoria.Clear();
                    txtpreco.Clear();
                    txtqtd.Clear();
                    txtmedida.Clear();

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }



        }




    }
}
