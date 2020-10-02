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
    public partial class frmCarregando2 : Form
    {
        public frmCarregando2()
        {
            InitializeComponent();
        }

        private void bntContinuar_Click(object sender, EventArgs e)
        {
            frmFase2 fase2 = new frmFase2();
            fase2.ShowDialog();
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmCarregando_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
