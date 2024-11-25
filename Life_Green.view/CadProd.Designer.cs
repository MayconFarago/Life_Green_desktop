
namespace Life_Green.view
{
    partial class CadProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadProd));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtnomeprod = new TextBox();
            txtcategoria = new TextBox();
            txtqtd = new TextBox();
            txtpreco = new TextBox();
            btncadprod = new Button();
            lblinfoCadProd = new Label();
            txtmedida = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(41, 48);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(32, 95);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Categoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(20, 140);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(60, 189);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Preço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(52, 233);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Medida:";
            label5.Click += label5_Click;
            // 
            // txtnomeprod
            // 
            txtnomeprod.Location = new Point(180, 40);
            txtnomeprod.Name = "txtnomeprod";
            txtnomeprod.Size = new Size(140, 27);
            txtnomeprod.TabIndex = 5;
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(180, 87);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(140, 27);
            txtcategoria.TabIndex = 6;
            // 
            // txtqtd
            // 
            txtqtd.Location = new Point(180, 132);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(140, 27);
            txtqtd.TabIndex = 7;
            // 
            // txtpreco
            // 
            txtpreco.Location = new Point(180, 181);
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(140, 27);
            txtpreco.TabIndex = 8;
            // 
            // btncadprod
            // 
            btncadprod.Location = new Point(423, 359);
            btncadprod.Name = "btncadprod";
            btncadprod.Size = new Size(106, 25);
            btncadprod.TabIndex = 10;
            btncadprod.Text = "Salvar";
            btncadprod.UseVisualStyleBackColor = true;
            btncadprod.Click += btncadprod_Click;
            // 
            // lblinfoCadProd
            // 
            lblinfoCadProd.AutoSize = true;
            lblinfoCadProd.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblinfoCadProd.Location = new Point(749, 83);
            lblinfoCadProd.Name = "lblinfoCadProd";
            lblinfoCadProd.Size = new Size(0, 20);
            lblinfoCadProd.TabIndex = 11;
            // 
            // txtmedida
            // 
            txtmedida.Location = new Point(181, 225);
            txtmedida.Name = "txtmedida";
            txtmedida.Size = new Size(140, 27);
            txtmedida.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(893, -192);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(934, -192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtqtd);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtmedida);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtpreco);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtcategoria);
            groupBox1.Controls.Add(txtnomeprod);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(305, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 315);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // CadProd
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 500);
            Controls.Add(lblinfoCadProd);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btncadprod);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadProd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void cklmedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtnomeprod;
        private TextBox txtcategoria;
        private TextBox txtqtd;
        private TextBox txtpreco;
        private Button btncadprod;
        private Label lblinfoCadProd;
        private TextBox txtmedida;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
    }
}