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
            label1 = new Label();
            btncadProd = new Button();
            btncadfunc = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnexaltProd = new Button();
            btnexaltFunc = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 34);
            label1.TabIndex = 0;
            label1.Text = "Life Green";
            label1.Click += label1_Click;
            // 
            // btncadProd
            // 
            btncadProd.Location = new Point(16, 69);
            btncadProd.Name = "btncadProd";
            btncadProd.Size = new Size(94, 29);
            btncadProd.TabIndex = 1;
            btncadProd.Text = "Produtos";
            btncadProd.UseVisualStyleBackColor = true;
            btncadProd.Click += btncadProd_Click;
            // 
            // btncadfunc
            // 
            btncadfunc.Location = new Point(140, 69);
            btncadfunc.Name = "btncadfunc";
            btncadfunc.Size = new Size(94, 29);
            btncadfunc.TabIndex = 2;
            btncadfunc.Text = "Funcionarios";
            btncadfunc.UseVisualStyleBackColor = true;
            btncadfunc.Click += btncadfunc_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btncadProd);
            groupBox1.Controls.Add(btncadfunc);
            groupBox1.Location = new Point(49, 191);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Realize cadastros";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnexaltFunc);
            groupBox2.Controls.Add(btnexaltProd);
            groupBox2.Location = new Point(437, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 125);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alterar e excluir";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnexaltProd
            // 
            btnexaltProd.Location = new Point(25, 69);
            btnexaltProd.Name = "btnexaltProd";
            btnexaltProd.Size = new Size(94, 29);
            btnexaltProd.TabIndex = 0;
            btnexaltProd.Text = "Produtos";
            btnexaltProd.UseVisualStyleBackColor = true;
            btnexaltProd.Click += btnexaltProd_Click;
            // 
            // btnexaltFunc
            // 
            btnexaltFunc.Location = new Point(172, 69);
            btnexaltFunc.Name = "btnexaltFunc";
            btnexaltFunc.Size = new Size(94, 29);
            btnexaltFunc.TabIndex = 1;
            btnexaltFunc.Text = "Funcionario";
            btnexaltFunc.UseVisualStyleBackColor = true;
            // 
            // TelaApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TelaApp";
            Text = "Tela Main";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btncadProd;
        private Button btncadfunc;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnexaltFunc;
        private Button btnexaltProd;
    }
}