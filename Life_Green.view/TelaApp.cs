using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Green.view
{
    public partial class TelaApp : Form
    {
        public TelaApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncadProd_Click(object sender, EventArgs e)
        {
            CadProd cadProd = new CadProd();
            this.Hide();
            cadProd.ShowDialog();

        }

        private void btncadfunc_Click(object sender, EventArgs e)
        {
            CadFunc cadFunc = new CadFunc();
            this.Hide();
            cadFunc.ShowDialog();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnexaltProd_Click(object sender, EventArgs e)
        {
            ExAltProd exAltProd = new ExAltProd();
            this.Hide();
            exAltProd.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tela_login tela_Login = new Tela_login();
            tela_Login.Show();
            this.Hide();
        }

        private void btnexaltFunc_Click(object sender, EventArgs e)
        {
            ExAltFunc exAltFunc = new ExAltFunc();
            exAltFunc.Show();
            this.Hide();
        }

        private void btncsvfunc_Click(object sender, EventArgs e)
        {

        }
    }
}
