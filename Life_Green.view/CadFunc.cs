using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Life_Green_dal;
using Life_Green.model;


namespace Life_Green.view
{

    public partial class CadFunc : Form
    {
        SqlConnection Connection;
        public CadFunc()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CadFunc));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNome = new TextBox();
            txtCargo = new TextBox();
            txtCPF = new TextBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtConfSenha = new TextBox();
            btnSalvar = new Button();
            lblInfoCadFunc = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(92, 64);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(89, 101);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Cargo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(106, 143);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(76, 188);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 3;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(89, 231);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Senha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(6, 29);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 5;
            label6.Text = "Confirmar Senha:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(185, 64);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 6;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(185, 101);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(125, 27);
            txtCargo.TabIndex = 7;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(185, 143);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(125, 27);
            txtCPF.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(185, 185);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 9;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(185, 228);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 27);
            txtSenha.TabIndex = 10;
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(185, 26);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(125, 27);
            txtConfSenha.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(451, 398);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblInfoCadFunc
            // 
            lblInfoCadFunc.AutoSize = true;
            lblInfoCadFunc.Location = new Point(414, 48);
            lblInfoCadFunc.Name = "lblInfoCadFunc";
            lblInfoCadFunc.Size = new Size(0, 20);
            lblInfoCadFunc.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(945, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(txtCargo);
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Location = new Point(308, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 283);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(txtConfSenha);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(308, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 75);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Confirmação";
            // 
            // CadFunc
            // 
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 453);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(lblInfoCadFunc);
            Controls.Add(btnSalvar);
            Cursor = Cursors.Default;
            Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadFunc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela cadFunc";
            Load += CadFunc_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private async void btnSalvar_Click(object? sender, EventArgs e)
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

        private void CadFunc_Load(object? sender, EventArgs e)
        {
            Console.WriteLine("Tela de cadastro de funcionario carregada.");
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtNome;
        private TextBox txtCargo;
        private TextBox txtCPF;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtConfSenha;
        private Button btnSalvar;
        private Label lblInfoCadFunc;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tela_login tl = new Tela_login();
            tl.Show();
            this.Hide();
        }
    }
}
