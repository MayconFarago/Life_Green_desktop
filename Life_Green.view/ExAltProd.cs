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
    public partial class ExAltProd : Form
    {

        SqlConnection Connection;
        public ExAltProd()
        {
            InitializeComponent();
        }


        private void btnalterar_Click(object sender, EventArgs e)
        {
            Connection = FabricaConexao.getConnection();

            int mtr = 0;

            try
            {

                mtr = Convert.ToInt32(txtidprod.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao converter! " +
                    "Digite somente números" + ex.Message);
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
                MessageBox.Show("Produtos alterados com sucesso!!");

            } catch (Exception ex) 
            {
                MessageBox.Show("falha : ", ex.Message);
            }



        }
    }
}
