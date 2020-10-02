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
    public partial class frmFase3 : Form
    {
        public frmFase3()
        {
            InitializeComponent();
        }

        Boolean v1 = false, v2 = false, v3 = false, v4 = false, v5 = false, v6 = false, v7 = false, v8 = false, v9 = false, v10 = false;

        private void bntContinuar_Click(object sender, EventArgs e)
        {
            if (v1 && v2 && v3 && v4 && v5 && v6 && v7 && v8 && v9 && v10)
            {
                v1 = false;
                v2 = false;
                v3 = false;
                v4 = false;
                v5 = false;
                v6 = false;
                v7 = false;
                v8 = false;
                v9 = false;
                v10 = false;
                frmFinal final = new frmFinal();
                final.ShowDialog();
                this.Dispose();

            }
            else
            {
                bntContinuar.Visible = false;


            }
            v1 = false;
            v2 = false;
            v3 = false;
            v4 = false;
            v5 = false;
            v6 = false;
            v7 = false;
            v8 = false;
            v9 = false;
            v10 = false;
            
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox33.Visible = false;
            v1 = true;
            Class3.contador++;
            if (Class3.contador == 11)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.Visible = false;
            v2 = true;
            Class3.contador++;
            if (Class3.contador == 11)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.Visible = false;
            v3 = true;
            Class3.contador++;
            if (Class3.contador == 11)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Visible = false;
            v4 = true;
            Class3.contador++;
            if (Class3.contador == 11)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = false;
            v5 = true;
            Class3.contador++;
            if (Class3.contador == 11)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            v6 = true;
            Class3.contador++;
            if (Class3.contador == 11)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            v7 = true;
            Class3.contador++;
            if (Class3.contador == 11)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Visible = false;
            v8 = true;
            Class3.contador++;
            if (Class3.contador == 11)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            v9 = true;
            Class3.contador++;
            if (Class3.contador == 11)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox30.Visible = false;
            v10 = true;
            Class3.contador++;
            if (Class3.contador == 11)
            {
                bntContinuar.Visible = true;
            }
        }


     
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (p1.Value >= 100)
            {
                timer1.Stop();
                // programando para chamar outro form
                frmPerdeu f2 = new frmPerdeu();
                f2.ShowDialog();
                this.Dispose();

            }
            else
            {
                p1.Value = p1.Value + 5;
                lblCarregando.Text = p1.Value + "%";
            }

            if (v1 && v2 && v3 && v4 && v5 && v6 && v7 && v8 && v9 && v10)
            {
                timer1.Stop();
                lblCarregando.Text = " ";
            }

        }
    }
}
