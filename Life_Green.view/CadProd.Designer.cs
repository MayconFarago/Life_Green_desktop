
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 58);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 113);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 166);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 216);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Preço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 262);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Medida";
            label5.Click += label5_Click;
            // 
            // txtnomeprod
            // 
            txtnomeprod.Location = new Point(165, 51);
            txtnomeprod.Name = "txtnomeprod";
            txtnomeprod.Size = new Size(125, 27);
            txtnomeprod.TabIndex = 5;
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(165, 106);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(125, 27);
            txtcategoria.TabIndex = 6;
            // 
            // txtqtd
            // 
            txtqtd.Location = new Point(165, 159);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(125, 27);
            txtqtd.TabIndex = 7;
            // 
            // txtpreco
            // 
            txtpreco.Location = new Point(165, 216);
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(125, 27);
            txtpreco.TabIndex = 8;
            // 
            // btncadprod
            // 
            btncadprod.Location = new Point(55, 366);
            btncadprod.Name = "btncadprod";
            btncadprod.Size = new Size(94, 29);
            btncadprod.TabIndex = 10;
            btncadprod.Text = "Salvar";
            btncadprod.UseVisualStyleBackColor = true;
            btncadprod.Click += btncadprod_Click;
            // 
            // lblinfoCadProd
            // 
            lblinfoCadProd.AutoSize = true;
            lblinfoCadProd.Location = new Point(421, 109);
            lblinfoCadProd.Name = "lblinfoCadProd";
            lblinfoCadProd.Size = new Size(0, 20);
            lblinfoCadProd.TabIndex = 11;
            // 
            // txtmedida
            // 
            txtmedida.Location = new Point(166, 268);
            txtmedida.Name = "txtmedida";
            txtmedida.Size = new Size(125, 27);
            txtmedida.TabIndex = 12;
            // 
            // CadProd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtmedida);
            Controls.Add(lblinfoCadProd);
            Controls.Add(btncadprod);
            Controls.Add(txtpreco);
            Controls.Add(txtqtd);
            Controls.Add(txtcategoria);
            Controls.Add(txtnomeprod);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadProd";
            Text = "Form1";
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
    }
}