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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Life_Green.view
{
    public partial class CadFunc2 : Form
    {
        SqlConnection Connection;
        public CadFunc2()
        {
            InitializeComponent();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            Connection = FabricaConexao.getConnection();

            Funcionario Func = new Funcionario();

            Func.Nome = txtNome.Text;
            Func.Cargo = txtCargo.Text;
            Func.Cpffunc = txtCPF.Text;
            Func.NomeUser = txtUsuario.Text;
            Func.SenhaUser = txtSenha.Text;

            if (txtSenha.Text == txtConfSenha.Text)
            {

                funcionarioDal FuncDal = new funcionarioDal();

                try
                {
                    FuncDal.abrirConexao(Connection);

                    FuncDal.adicionar(Connection, Func);


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Falha: " + ex.Message);

                }

                lblInfoCadFunc.Text = "Usuario cadastrado com sucesso!!";
                await Task.Delay(3000);
                lblInfoCadFunc.Text = "";
                txtNome.Text = "";
                txtCargo.Text = "";
                txtCPF.Text = "";
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtConfSenha.Text = "";

            }
            else
            {

                lblInfoCadFunc.Text = " As senhas estao diferentes, verifique-as ";
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tela_login tl = new Tela_login();
            tl.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TelaApp ta = new TelaApp();
            ta.Show();
            this.Hide();
        }
    }
}
