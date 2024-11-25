namespace Life_Green.view
{
    partial class TelaApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaApp));
            btncadProd = new Button();
            btncadfunc = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnexaltFunc = new Button();
            btnexaltProd = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btncadProd
            // 
            btncadProd.Location = new Point(6, 69);
            btncadProd.Name = "btncadProd";
            btncadProd.Size = new Size(125, 29);
            btncadProd.TabIndex = 1;
            btncadProd.Text = "Produtos";
            btncadProd.UseVisualStyleBackColor = true;
            btncadProd.Click += btncadProd_Click;
            // 
            // btncadfunc
            // 
            btncadfunc.Location = new Point(162, 69);
            btncadfunc.Name = "btncadfunc";
            btncadfunc.Size = new Size(125, 29);
            btncadfunc.TabIndex = 2;
            btncadfunc.Text = "Funcionarios";
            btncadfunc.UseVisualStyleBackColor = true;
            btncadfunc.Click += btncadfunc_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btncadProd);
            groupBox1.Controls.Add(btncadfunc);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(167, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Realize cadastros";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(btnexaltFunc);
            groupBox2.Controls.Add(btnexaltProd);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(533, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 125);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alterar e excluir";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnexaltFunc
            // 
            btnexaltFunc.Location = new Point(162, 69);
            btnexaltFunc.Name = "btnexaltFunc";
            btnexaltFunc.Size = new Size(125, 29);
            btnexaltFunc.TabIndex = 1;
            btnexaltFunc.Text = "Funcionario";
            btnexaltFunc.UseVisualStyleBackColor = true;
            btnexaltFunc.Click += btnexaltFunc_Click;
            // 
            // btnexaltProd
            // 
            btnexaltProd.Location = new Point(6, 69);
            btnexaltProd.Name = "btnexaltProd";
            btnexaltProd.Size = new Size(125, 29);
            btnexaltProd.TabIndex = 0;
            btnexaltProd.Text = "Produtos";
            btnexaltProd.UseVisualStyleBackColor = true;
            btnexaltProd.Click += btnexaltProd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(965, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(397, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 54);
            label1.TabIndex = 33;
            label1.Text = "Life Green";
            // 
            // TelaApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 500);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Main";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btncadProd;
        private Button btncadfunc;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnexaltFunc;
        private Button btnexaltProd;
        private PictureBox pictureBox1;
        private Label label1;
    }
}