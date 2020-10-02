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
    public partial class frmCarregando1 : Form
    {
        public frmCarregando1()
        {
            InitializeComponent();
        }

        private void bntContinuar_Click(object sender, EventArgs e)
        {
            frmFase1 fase1 = new frmFase1();
            fase1.ShowDialog();
            this.Dispose();
        }
    }
}
