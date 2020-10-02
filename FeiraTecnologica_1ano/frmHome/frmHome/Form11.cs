using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmHome
{
    public partial class frmCarregando3 : Form
    {
        public frmCarregando3()
        {
            InitializeComponent();
        }

        private void bntContinuar_Click(object sender, EventArgs e)
        {
            frmFase3 fase3 = new frmFase3();
            fase3.ShowDialog();
            this.Dispose();
        }

        private void frmCarregando3_Load(object sender, EventArgs e)
        {

        }
    }
}
