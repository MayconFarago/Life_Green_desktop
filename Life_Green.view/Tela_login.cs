using Life_Green.model;
using Life_Green_dal;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Life_Green.view
{
    public partial class Tela_login : Form
    {

        SqlConnection Connection;
        public Tela_login()
        {
            InitializeComponent();
            txtsenha.UseSystemPasswordChar = true;
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            CadFunc cadFunc = new CadFunc();
            this.Hide();
            cadFunc.ShowDialog();
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            Connection = FabricaConexao.getConnection();

            Funcionario Func = new Funcionario();

            Func.NomeUser = txtuser.Text;
            Func.SenhaUser = txtsenha.Text;
            try
            {
                String BuscaFunc = "SELECT * FROM Funcionarios WHERE nomeUser = '" + txtuser.Text + "' AND senhaUser = '" + txtsenha.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(BuscaFunc, Connection);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    Func.NomeUser = txtuser.Text;
                    Func.SenhaUser = txtsenha.Text;

                    lblinfotela.Text = "Sucesso, entrando .....";
                    await Task.Delay(2500);

                    TelaApp telaApp = new TelaApp();
                    this.Hide();
                    telaApp.ShowDialog();
                }
                else
                {

                    lblinfotela.Text = "Senha ou Usario incorreto";
                    await Task.Delay(2500);
                    txtuser.Clear();
                    txtsenha.Clear();

                }


            }
            catch
            {
                MessageBox.Show("Erro");
            }
            finally
            {
                Connection.Close();
            }


        }


        private void ckbMostrarSenha_CheckedChanged_1(object sender, EventArgs e)
        {

            if (txtsenha.UseSystemPasswordChar)
            {

                txtsenha.UseSystemPasswordChar = false;
                ckbMostrarSenha.Text = "Ocultar Senha";

            }
            else
            {

                txtsenha.UseSystemPasswordChar = true;
                ckbMostrarSenha.Text = "Mostrar Senha";

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
