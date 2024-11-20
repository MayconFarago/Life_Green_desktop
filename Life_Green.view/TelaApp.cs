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
    }
}
