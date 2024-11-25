
namespace Life_Green.view
{
    partial class Tela_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_login));
            lbluser = new Label();
            lblsenha = new Label();
            txtuser = new TextBox();
            txtsenha = new TextBox();
            btnlogin = new Button();
            btncadastro = new Button();
            lblinfotela = new Label();
            groupBox1 = new GroupBox();
            ckbMostrarSenha = new CheckBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.ForeColor = SystemColors.ActiveCaptionText;
            lbluser.Location = new Point(50, 67);
            lbluser.Margin = new Padding(4, 0, 4, 0);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(78, 20);
            lbluser.TabIndex = 0;
            lbluser.Text = "Usuario:";
            lbluser.Click += label1_Click;
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(62, 141);
            lblsenha.Margin = new Padding(4, 0, 4, 0);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(65, 20);
            lblsenha.TabIndex = 1;
            lblsenha.Text = "Senha:";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(180, 67);
            txtuser.Margin = new Padding(4, 3, 4, 3);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(216, 27);
            txtuser.TabIndex = 2;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(180, 141);
            txtsenha.Margin = new Padding(4, 3, 4, 3);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(216, 27);
            txtsenha.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(35, 44);
            btnlogin.Margin = new Padding(4, 3, 4, 3);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(158, 33);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btncadastro
            // 
            btncadastro.Location = new Point(272, 44);
            btncadastro.Margin = new Padding(4, 3, 4, 3);
            btncadastro.Name = "btncadastro";
            btncadastro.Size = new Size(158, 33);
            btncadastro.TabIndex = 5;
            btncadastro.Text = "Cadastre-se";
            btncadastro.UseVisualStyleBackColor = true;
            btncadastro.Click += btncadastro_Click;
            // 
            // lblinfotela
            // 
            lblinfotela.AutoSize = true;
            lblinfotela.Location = new Point(151, 26);
            lblinfotela.Margin = new Padding(4, 0, 4, 0);
            lblinfotela.Name = "lblinfotela";
            lblinfotela.Size = new Size(0, 20);
            lblinfotela.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(ckbMostrarSenha);
            groupBox1.Controls.Add(txtuser);
            groupBox1.Controls.Add(lblinfotela);
            groupBox1.Controls.Add(txtsenha);
            groupBox1.Controls.Add(lbluser);
            groupBox1.Controls.Add(lblsenha);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(262, 100);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(465, 232);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // ckbMostrarSenha
            // 
            ckbMostrarSenha.AutoSize = true;
            ckbMostrarSenha.Location = new Point(180, 187);
            ckbMostrarSenha.Margin = new Padding(4, 3, 4, 3);
            ckbMostrarSenha.Name = "ckbMostrarSenha";
            ckbMostrarSenha.Size = new Size(140, 24);
            ckbMostrarSenha.TabIndex = 7;
            ckbMostrarSenha.Text = "Mostra senha";
            ckbMostrarSenha.UseVisualStyleBackColor = true;
            ckbMostrarSenha.CheckedChanged += ckbMostrarSenha_CheckedChanged_1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btncadastro);
            groupBox2.Controls.Add(btnlogin);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(262, 361);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(465, 98);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(413, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 54);
            label1.TabIndex = 9;
            label1.Text = "Life Green";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(963, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Tela_login
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 500);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Tela_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += Tela_login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Tela_login_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Tela de login carregada.");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lbluser;
        private Label lblsenha;
        private TextBox txtuser;
        private TextBox txtsenha;
        private Button btnlogin;
        private Button btncadastro;
        private Label lblinfotela;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox ckbMostrarSenha;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
