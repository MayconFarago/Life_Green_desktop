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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 34);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 74);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Cargo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 116);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 161);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 204);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "Senha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 244);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 5;
            label6.Text = "Confirmar Senha:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(164, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 6;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(164, 74);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(125, 27);
            txtCargo.TabIndex = 7;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(164, 116);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(125, 27);
            txtCPF.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(164, 158);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 9;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(177, 202);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 27);
            txtSenha.TabIndex = 10;
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(205, 244);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(125, 27);
            txtConfSenha.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(55, 309);
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
            // CadFunc
            // 
            ClientSize = new Size(593, 378);
            Controls.Add(lblInfoCadFunc);
            Controls.Add(btnSalvar);
            Controls.Add(txtConfSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(txtCPF);
            Controls.Add(txtCargo);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadFunc";
            Text = "Tela cadFunc";
            Load += CadFunc_Load;
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
        private Label label5;
    }
}
