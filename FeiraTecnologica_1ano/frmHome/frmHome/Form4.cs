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
    public partial class frmFase2 : Form
    {
        public frmFase2()
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
               
                frmCarregando3 carr = new frmCarregando3();
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


          private void pictureBox34_Click(object sender, EventArgs e)
          {
              pictureBox34.Visible = false;
              v3 = true;
              Class2.contador++;
              if (Class2.contador == 11)
              {
                  bntContinuar.Visible = true;
              }
          }

          private void pictureBox32_Click(object sender, EventArgs e)
          {
              pictureBox32.Visible = false;
              v2 = true;
              Class2.contador++;
              if (Class2.contador == 11)
              {
                  bntContinuar.Visible = true;
              }
          }

          private void pictureBox22_Click(object sender, EventArgs e)
          {
              pictureBox22.Visible = false;
              v1 = true;
              Class2.contador++;
              if (Class2.contador == 11)
              {
                  bntContinuar.Visible = true;
              }
          }

          private void pictureBox18_Click(object sender, EventArgs e)
          {
              pictureBox18.Visible = false;
              v4 = true;
              Class2.contador++;
              if (Class2.contador == 11)
              {
                  bntContinuar.Visible = true;
              }
          }

          private void pictureBox14_Click(object sender, EventArgs e)
          {
              pictureBox14.Visible = false;
              v5 = true;
              Class2.contador++;
              if (Class2.contador == 11)
              {
                  bntContinuar.Visible = true;
              }
          }

          private void pictureBox10_Click(object sender, EventArgs e)
          {
              pictureBox10.Visible = false;
              v6 = true;
              Class2.contador++;
              if (Class2.contador == 11)
              {
                  bntContinuar.Visible = true;
              }
          }

          private void pictureBox12_Click(object sender, EventArgs e)
          {
              pictureBox12.Visible = false;
              v7 = true;
              Class2.contador++;
              if (Class2.contador == 11)
              {
                  bntContinuar.Visible = true;
              }
          }

          private void pictureBox4_Click(object sender, EventArgs e)
          {
              pictureBox4.Visible = false;
              v8 = true;
              Class2.contador++;
              if (Class2.contador == 11)
              {
                  bntContinuar.Visible = true;
              }
          }

          private void pictureBox20_Click(object sender, EventArgs e)
          {
              pictureBox20.Visible = false;
              v9 = true;
              Class2.contador++;
              if (Class2.contador == 11)
              {
                  bntContinuar.Visible = true;
              }
          }

          private void pictureBox7_Click(object sender, EventArgs e)
          {
              pictureBox7.Visible = false;
              v10 = true;
              Class2.contador++;
              if (Class2.contador == 11)
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

          private void pictureBox30_Click(object sender, EventArgs e)
          {

          }
    }
}
