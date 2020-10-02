namespace frmHome
{
    partial class frmHome
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
            this.bntComeçar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntInstrucoes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntComeçar
            // 
            this.bntComeçar.BackColor = System.Drawing.Color.Chartreuse;
            this.bntComeçar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntComeçar.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntComeçar.Location = new System.Drawing.Point(1082, 450);
            this.bntComeçar.Name = "bntComeçar";
            this.bntComeçar.Size = new System.Drawing.Size(259, 116);
            this.bntComeçar.TabIndex = 0;
            this.bntComeçar.Text = "Começar";
            this.bntComeçar.UseVisualStyleBackColor = false;
            this.bntComeçar.Click += new System.EventHandler(this.bntComeçar_Click);
            // 
            // bntSair
            // 
            this.bntSair.BackColor = System.Drawing.Color.Chartreuse;
            this.bntSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSair.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSair.Location = new System.Drawing.Point(1127, 696);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(165, 90);
            this.bntSair.TabIndex = 1;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = false;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // bntInstrucoes
            // 
            this.bntInstrucoes.BackColor = System.Drawing.Color.Chartreuse;
            this.bntInstrucoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntInstrucoes.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntInstrucoes.Location = new System.Drawing.Point(1096, 572);
            this.bntInstrucoes.Name = "bntInstrucoes";
            this.bntInstrucoes.Size = new System.Drawing.Size(226, 118);
            this.bntInstrucoes.TabIndex = 2;
            this.bntInstrucoes.Text = "Instruções";
            this.bntInstrucoes.UseVisualStyleBackColor = false;
            this.bntInstrucoes.Click += new System.EventHandler(this.bntInstrucoes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 57F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(431, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 94);
            this.label1.TabIndex = 5;
            this.label1.Text = "Colheita Maldita";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::frmHome.Properties.Resources.animation_right_test;
            this.pictureBox1.Location = new System.Drawing.Point(551, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::frmHome.Properties.Resources.cena5555rio_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 823);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntInstrucoes);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntComeçar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "Splash screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntComeçar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntInstrucoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

