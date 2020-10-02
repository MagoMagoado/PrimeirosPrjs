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
    public partial class frmFase1 : Form
    {
        public frmFase1()
        {
            InitializeComponent();
        }

        Boolean v1 = false, v2 = false, v3 = false, v4 = false, v5 = false, v6 = false, v7 = false, v8 = false, v9 = false, v10 = false;
       

        private void bntContinuar_Click(object sender, EventArgs e)
        {
            if (v1 && v2 && v3 && v4 && v5 && v6 && v7 && v8 && v9 && v10)
            {
               
                frmCarregando2 carr = new frmCarregando2();
                carr.ShowDialog();
                this.Dispose();
            }
            else
           
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

       

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            v3 = true;          
            Class1.contador++;
            if (Class1.contador == 10)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = false;
            v2 = true;         
            Class1.contador++;
            if (Class1.contador == 10)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            pictureBox37.Visible = false;
            v1 = true;       
            Class1.contador++;
            if (Class1.contador == 10)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = false;
            v4 = true;           
            Class1.contador++;
            if (Class1.contador == 10)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            v5 = true;            
            Class1.contador++;
            if (Class1.contador == 10)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            v6 = true;            
            Class1.contador++;
            if (Class1.contador == 10)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            v7 = true;           
            Class1.contador++;
            if (Class1.contador == 10)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox28.Visible = false;
            v8 = true;        
            Class1.contador++;
            if (Class1.contador == 10)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.Visible = false;
            v9 = true;           
            Class1.contador++;
            if (Class1.contador == 10)
            {
                bntContinuar.Visible = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            v10 = true;
            Class1.contador++;
            if (Class1.contador == 10)
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
                lblCarregando.Text =" ";
            }
        }

        private void frmFase1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
