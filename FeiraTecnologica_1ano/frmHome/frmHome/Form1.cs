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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void bntInstrucoes_Click(object sender, EventArgs e)
        {
            frmInstrucoes ins = new frmInstrucoes();
            ins.ShowDialog();
            this.Dispose();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntComeçar_Click(object sender, EventArgs e)
        {
         frmHistoria historia = new frmHistoria();
            historia.ShowDialog();
            this.Dispose();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
