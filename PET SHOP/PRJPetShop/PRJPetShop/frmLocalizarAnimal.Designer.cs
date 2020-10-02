namespace PRJPetShop
{
    partial class frmLocalizarAnimal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cli_nomeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.view_AnimaisClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_AnimaisClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet = new PRJPetShop.petshopDataSet();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.view_AnimaisClientesTableAdapter = new PRJPetShop.petshopDataSetTableAdapters.View_AnimaisClientesTableAdapter();
            this.tableAdapterManager = new PRJPetShop.petshopDataSetTableAdapters.TableAdapterManager();
            cli_nomeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_AnimaisClientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_AnimaisClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cli_nomeLabel
            // 
            cli_nomeLabel.AutoSize = true;
            cli_nomeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_nomeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            cli_nomeLabel.Location = new System.Drawing.Point(6, 43);
            cli_nomeLabel.Name = "cli_nomeLabel";
            cli_nomeLabel.Size = new System.Drawing.Size(145, 21);
            cli_nomeLabel.TabIndex = 17;
            cli_nomeLabel.Text = "Nome do Animal:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.view_AnimaisClientesDataGridView);
            this.groupBox1.Controls.Add(cli_nomeLabel);
            this.groupBox1.Controls.Add(this.bntCancelar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 313);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localizar Animal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "*DoubleClick sobre o campo desejado";
            // 
            // view_AnimaisClientesDataGridView
            // 
            this.view_AnimaisClientesDataGridView.AllowUserToAddRows = false;
            this.view_AnimaisClientesDataGridView.AllowUserToDeleteRows = false;
            this.view_AnimaisClientesDataGridView.AutoGenerateColumns = false;
            this.view_AnimaisClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_AnimaisClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.view_AnimaisClientesDataGridView.DataSource = this.view_AnimaisClientesBindingSource;
            this.view_AnimaisClientesDataGridView.Location = new System.Drawing.Point(6, 70);
            this.view_AnimaisClientesDataGridView.Name = "view_AnimaisClientesDataGridView";
            this.view_AnimaisClientesDataGridView.ReadOnly = true;
            this.view_AnimaisClientesDataGridView.Size = new System.Drawing.Size(513, 195);
            this.view_AnimaisClientesDataGridView.TabIndex = 17;
            this.view_AnimaisClientesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_AnimaisClientesDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ani_codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 83;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ani_nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Animal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cli_nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // view_AnimaisClientesBindingSource
            // 
            this.view_AnimaisClientesBindingSource.DataMember = "View_AnimaisClientes";
            this.view_AnimaisClientesBindingSource.DataSource = this.petshopDataSet;
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bntCancelar
            // 
            this.bntCancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bntCancelar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntCancelar.Location = new System.Drawing.Point(411, 271);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(108, 36);
            this.bntCancelar.TabIndex = 16;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = false;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(152, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(367, 23);
            this.txtNome.TabIndex = 15;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // view_AnimaisClientesTableAdapter
            // 
            this.view_AnimaisClientesTableAdapter.ClearBeforeFill = true;
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
            // frmLocalizarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 336);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLocalizarAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLocalizarAnimal";
            this.Load += new System.EventHandler(this.frmLocalizarAnimal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_AnimaisClientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_AnimaisClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource view_AnimaisClientesBindingSource;
        private petshopDataSetTableAdapters.View_AnimaisClientesTableAdapter view_AnimaisClientesTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView view_AnimaisClientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
    }
}