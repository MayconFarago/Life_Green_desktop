
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
            SuspendLayout();
            // 
            // txtmedida
            // 
            txtmedida.Location = new Point(373, 288);
            txtmedida.Name = "txtmedida";
            txtmedida.Size = new Size(125, 27);
            txtmedida.TabIndex = 22;
            // 
            // txtpreco
            // 
            txtpreco.Location = new Point(372, 236);
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(125, 27);
            txtpreco.TabIndex = 21;
            // 
            // txtqtd
            // 
            txtqtd.Location = new Point(372, 179);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(125, 27);
            txtqtd.TabIndex = 20;
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(372, 126);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(125, 27);
            txtcategoria.TabIndex = 19;
            // 
            // txtnomeprod
            // 
            txtnomeprod.Location = new Point(372, 71);
            txtnomeprod.Name = "txtnomeprod";
            txtnomeprod.Size = new Size(125, 27);
            txtnomeprod.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(244, 288);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 17;
            label5.Text = "Medida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 236);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 16;
            label4.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 186);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 15;
            label3.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 133);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 14;
            label2.Text = "Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 78);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 13;
            label1.Text = "Produto";
            // 
            // btnalterar
            // 
            btnalterar.Location = new Point(196, 342);
            btnalterar.Name = "btnalterar";
            btnalterar.Size = new Size(94, 29);
            btnalterar.TabIndex = 23;
            btnalterar.Text = "Alterar";
            btnalterar.UseVisualStyleBackColor = true;
            btnalterar.Click += btnalterar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(501, 342);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(94, 29);
            btnexcluir.TabIndex = 24;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 26);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 25;
            label6.Text = "ID Produto";
            // 
            // txtidprod
            // 
            txtidprod.Location = new Point(373, 23);
            txtidprod.Name = "txtidprod";
            txtidprod.Size = new Size(125, 27);
            txtidprod.TabIndex = 26;
            // 
            // ExAltProd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtidprod);
            Controls.Add(label6);
            Controls.Add(btnexcluir);
            Controls.Add(btnalterar);
            Controls.Add(txtmedida);
            Controls.Add(txtpreco);
            Controls.Add(txtqtd);
            Controls.Add(txtcategoria);
            Controls.Add(txtnomeprod);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ExAltProd";
            Text = "Alterar e excluir produto";
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
    }
}