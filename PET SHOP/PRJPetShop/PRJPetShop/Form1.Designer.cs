namespace PRJPetShop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTopo = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblagendamento = new System.Windows.Forms.Label();
            this.lblandamento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.btnRaca = new System.Windows.Forms.Button();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.btnServico = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.petshopDataSet = new PRJPetShop.petshopDataSet();
            this.view_DetalhesAgendamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DetalhesAgendamentosTableAdapter = new PRJPetShop.petshopDataSetTableAdapters.View_DetalhesAgendamentosTableAdapter();
            this.tableAdapterManager = new PRJPetShop.petshopDataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelTopo.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DetalhesAgendamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.LimeGreen;
            this.panelTopo.Controls.Add(this.btnMin);
            this.panelTopo.Controls.Add(this.btnMax);
            this.panelTopo.Controls.Add(this.btnSair);
            this.panelTopo.Controls.Add(this.btnRestaurar);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(800, 44);
            this.panelTopo.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMin.BackgroundImage = global::PRJPetShop.Properties.Resources.iconfinder_minimize_2_2561246;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(668, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(36, 34);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMax.BackgroundImage = global::PRJPetShop.Properties.Resources.iconfinder_10_Maximize_1062321;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(710, 4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(36, 34);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSair.BackgroundImage = global::PRJPetShop.Properties.Resources.iconfinder_icon_close_circled_211650;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(752, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 34);
            this.btnSair.TabIndex = 0;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRestaurar.BackgroundImage = global::PRJPetShop.Properties.Resources.iconfinder_Restaurar;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(710, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(36, 34);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.Green;
            this.panelLateral.Controls.Add(this.groupBox1);
            this.panelLateral.Controls.Add(this.panelSelecao);
            this.panelLateral.Controls.Add(this.btnRaca);
            this.panelLateral.Controls.Add(this.btnAgendamento);
            this.panelLateral.Controls.Add(this.btnServico);
            this.panelLateral.Controls.Add(this.btnAnimal);
            this.panelLateral.Controls.Add(this.btnCliente);
            this.panelLateral.Controls.Add(this.btnInicio);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 44);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(201, 621);
            this.panelLateral.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Green;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblagendamento);
            this.groupBox1.Controls.Add(this.lblandamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Sigmar One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(5, 407);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(190, 205);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendamentos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(40, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Detalhes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblagendamento
            // 
            this.lblagendamento.AutoSize = true;
            this.lblagendamento.BackColor = System.Drawing.Color.White;
            this.lblagendamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblagendamento.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblagendamento.ForeColor = System.Drawing.Color.Red;
            this.lblagendamento.Location = new System.Drawing.Point(14, 126);
            this.lblagendamento.Margin = new System.Windows.Forms.Padding(0);
            this.lblagendamento.Name = "lblagendamento";
            this.lblagendamento.Size = new System.Drawing.Size(26, 28);
            this.lblagendamento.TabIndex = 7;
            this.lblagendamento.Text = "0";
            // 
            // lblandamento
            // 
            this.lblandamento.AutoSize = true;
            this.lblandamento.BackColor = System.Drawing.Color.White;
            this.lblandamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblandamento.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblandamento.ForeColor = System.Drawing.Color.Red;
            this.lblandamento.Location = new System.Drawing.Point(14, 50);
            this.lblandamento.Margin = new System.Windows.Forms.Padding(0);
            this.lblandamento.Name = "lblandamento";
            this.lblandamento.Size = new System.Drawing.Size(26, 28);
            this.lblandamento.TabIndex = 6;
            this.lblandamento.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "------------------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Em Andamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Agendados:";
            // 
            // panelSelecao
            // 
            this.panelSelecao.BackColor = System.Drawing.Color.Red;
            this.panelSelecao.Location = new System.Drawing.Point(4, 16);
            this.panelSelecao.Name = "panelSelecao";
            this.panelSelecao.Size = new System.Drawing.Size(10, 42);
            this.panelSelecao.TabIndex = 6;
            // 
            // btnRaca
            // 
            this.btnRaca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRaca.FlatAppearance.BorderSize = 2;
            this.btnRaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaca.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaca.ForeColor = System.Drawing.Color.White;
            this.btnRaca.Location = new System.Drawing.Point(19, 204);
            this.btnRaca.Name = "btnRaca";
            this.btnRaca.Size = new System.Drawing.Size(176, 42);
            this.btnRaca.TabIndex = 5;
            this.btnRaca.Text = "Raça";
            this.btnRaca.UseVisualStyleBackColor = true;
            this.btnRaca.Click += new System.EventHandler(this.btnRaca_Click);
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgendamento.FlatAppearance.BorderSize = 2;
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamento.ForeColor = System.Drawing.Color.White;
            this.btnAgendamento.Location = new System.Drawing.Point(19, 338);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(176, 42);
            this.btnAgendamento.TabIndex = 4;
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.UseVisualStyleBackColor = true;
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgendamento_Click);
            // 
            // btnServico
            // 
            this.btnServico.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnServico.FlatAppearance.BorderSize = 2;
            this.btnServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServico.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServico.ForeColor = System.Drawing.Color.White;
            this.btnServico.Location = new System.Drawing.Point(19, 270);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(176, 42);
            this.btnServico.TabIndex = 3;
            this.btnServico.Text = "Serviço";
            this.btnServico.UseVisualStyleBackColor = true;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnimal.FlatAppearance.BorderSize = 2;
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimal.ForeColor = System.Drawing.Color.White;
            this.btnAnimal.Location = new System.Drawing.Point(19, 141);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(176, 42);
            this.btnAnimal.TabIndex = 2;
            this.btnAnimal.Text = "Animal";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCliente.FlatAppearance.BorderSize = 2;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Location = new System.Drawing.Point(19, 78);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(176, 42);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInicio.FlatAppearance.BorderSize = 2;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(19, 16);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(176, 42);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_DetalhesAgendamentosBindingSource
            // 
            this.view_DetalhesAgendamentosBindingSource.DataMember = "View_DetalhesAgendamentos";
            this.view_DetalhesAgendamentosBindingSource.DataSource = this.petshopDataSet;
            // 
            // view_DetalhesAgendamentosTableAdapter
            // 
            this.view_DetalhesAgendamentosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PRJPetShop.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.Navy;
            this.panelCentral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCentral.BackgroundImage")));
            this.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(201, 44);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(599, 621);
            this.panelCentral.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTopo.ResumeLayout(false);
            this.panelLateral.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DetalhesAgendamentosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnRaca;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.Button btnServico;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel panelSelecao;
        private System.Windows.Forms.GroupBox groupBox1;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource view_DetalhesAgendamentosBindingSource;
        private petshopDataSetTableAdapters.View_DetalhesAgendamentosTableAdapter view_DetalhesAgendamentosTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblagendamento;
        private System.Windows.Forms.Label lblandamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

