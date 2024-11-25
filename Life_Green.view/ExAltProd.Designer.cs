
namespace Life_Green.view
{
    partial class ExAltProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExAltProd));
            txtmedida = new TextBox();
            txtpreco = new TextBox();
            txtqtd = new TextBox();
            txtcategoria = new TextBox();
            txtnomeprod = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnalterar = new Button();
            btnexcluir = new Button();
            label6 = new Label();
            txtidprod = new TextBox();
            btnbuscaprod = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblInfoexprod = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtmedida
            // 
            txtmedida.Location = new Point(170, 251);
            txtmedida.Name = "txtmedida";
            txtmedida.Size = new Size(125, 27);
            txtmedida.TabIndex = 22;
            // 
            // txtpreco
            // 
            txtpreco.Location = new Point(169, 199);
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(125, 27);
            txtpreco.TabIndex = 21;
            // 
            // txtqtd
            // 
            txtqtd.Location = new Point(169, 142);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(125, 27);
            txtqtd.TabIndex = 20;
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(169, 89);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(125, 27);
            txtcategoria.TabIndex = 19;
            // 
            // txtnomeprod
            // 
            txtnomeprod.Location = new Point(169, 34);
            txtnomeprod.Name = "txtnomeprod";
            txtnomeprod.Size = new Size(125, 27);
            txtnomeprod.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 251);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 17;
            label5.Text = "Medida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 199);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 16;
            label4.Text = "Preço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 149);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 15;
            label3.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 96);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 14;
            label2.Text = "Categoria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 41);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 13;
            label1.Text = "Produto:";
            // 
            // btnalterar
            // 
            btnalterar.Location = new Point(6, 84);
            btnalterar.Name = "btnalterar";
            btnalterar.Size = new Size(94, 29);
            btnalterar.TabIndex = 23;
            btnalterar.Text = "Alterar";
            btnalterar.UseVisualStyleBackColor = true;
            btnalterar.Click += btnalterar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(228, 85);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(94, 29);
            btnexcluir.TabIndex = 24;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 46);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 25;
            label6.Text = "ID Produto";
            // 
            // txtidprod
            // 
            txtidprod.Location = new Point(171, 43);
            txtidprod.Name = "txtidprod";
            txtidprod.Size = new Size(125, 27);
            txtidprod.TabIndex = 26;
            // 
            // btnbuscaprod
            // 
            btnbuscaprod.Location = new Point(118, 26);
            btnbuscaprod.Name = "btnbuscaprod";
            btnbuscaprod.Size = new Size(94, 29);
            btnbuscaprod.TabIndex = 27;
            btnbuscaprod.Text = "Buscar";
            btnbuscaprod.UseVisualStyleBackColor = true;
            btnbuscaprod.Click += btnbuscaprod_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtidprod);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(115, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 83);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(322, 43);
            label7.Name = "label7";
            label7.Size = new Size(365, 20);
            label7.TabIndex = 27;
            label7.Text = "<-- Forneça o ID para realizar as operações ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(txtnomeprod);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtmedida);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtpreco);
            groupBox2.Controls.Add(txtcategoria);
            groupBox2.Controls.Add(txtqtd);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(115, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 291);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(btnbuscaprod);
            groupBox3.Controls.Add(btnalterar);
            groupBox3.Controls.Add(btnexcluir);
            groupBox3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(563, 338);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(328, 126);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
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
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(922, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblInfoexprod
            // 
            lblInfoexprod.AutoSize = true;
            lblInfoexprod.BackColor = Color.Transparent;
            lblInfoexprod.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoexprod.Location = new Point(563, 154);
            lblInfoexprod.Name = "lblInfoexprod";
            lblInfoexprod.Size = new Size(0, 20);
            lblInfoexprod.TabIndex = 33;
            // 
            // ExAltProd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 500);
            Controls.Add(lblInfoexprod);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExAltProd";
            Text = "Alterar e excluir produto";
            Load += ExAltProd_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmedida;
        private TextBox txtpreco;
        private TextBox txtqtd;
        private TextBox txtcategoria;
        private TextBox txtnomeprod;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnalterar;
        private Button btnexcluir;
        private Label label6;
        private TextBox txtidprod;
        private Button btnbuscaprod;
        private GroupBox groupBox1;
        private Label label7;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblInfoexprod;
    }
}