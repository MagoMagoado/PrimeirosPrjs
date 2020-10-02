namespace PRJPetShop
{
    partial class frmCadAgendamento
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
            System.Windows.Forms.Label ag_codigoLabel;
            System.Windows.Forms.Label ag_dataLabel;
            System.Windows.Forms.Label ag_horarioLabel;
            System.Windows.Forms.Label ag_situacaoLabel;
            System.Windows.Forms.Label ag_totalLabel;
            System.Windows.Forms.Label ani_fotoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAgendamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.ani_fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet = new PRJPetShop.petshopDataSet();
            this.ag_animalComboBox = new System.Windows.Forms.ComboBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ag_codigoTextBox = new System.Windows.Forms.TextBox();
            this.ag_dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ag_horarioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ag_situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.ag_totalTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodServ = new System.Windows.Forms.MaskedTextBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.btnAddServ = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.view_ServicosAgendamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_ServicosAgendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoTableAdapter = new PRJPetShop.petshopDataSetTableAdapters.agendamentoTableAdapter();
            this.tableAdapterManager = new PRJPetShop.petshopDataSetTableAdapters.TableAdapterManager();
            this.animalTableAdapter = new PRJPetShop.petshopDataSetTableAdapters.animalTableAdapter();
            this.agendamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.agendamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bntCancelar = new System.Windows.Forms.ToolStripButton();
            this.bntEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.agendamento_servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamento_servicosTableAdapter = new PRJPetShop.petshopDataSetTableAdapters.agendamento_servicosTableAdapter();
            this.view_ServicosAgendamentoTableAdapter = new PRJPetShop.petshopDataSetTableAdapters.View_ServicosAgendamentoTableAdapter();
            this.servicoTableAdapter = new PRJPetShop.petshopDataSetTableAdapters.servicoTableAdapter();
            this.view_TotalServicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_TotalServicosTableAdapter = new PRJPetShop.petshopDataSetTableAdapters.View_TotalServicosTableAdapter();
            ag_codigoLabel = new System.Windows.Forms.Label();
            ag_dataLabel = new System.Windows.Forms.Label();
            ag_horarioLabel = new System.Windows.Forms.Label();
            ag_situacaoLabel = new System.Windows.Forms.Label();
            ag_totalLabel = new System.Windows.Forms.Label();
            ani_fotoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ani_fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicosAgendamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicosAgendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingNavigator)).BeginInit();
            this.agendamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamento_servicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TotalServicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ag_codigoLabel
            // 
            ag_codigoLabel.AutoSize = true;
            ag_codigoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ag_codigoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ag_codigoLabel.Location = new System.Drawing.Point(16, 31);
            ag_codigoLabel.Name = "ag_codigoLabel";
            ag_codigoLabel.Size = new System.Drawing.Size(72, 21);
            ag_codigoLabel.TabIndex = 0;
            ag_codigoLabel.Text = "Código:";
            // 
            // ag_dataLabel
            // 
            ag_dataLabel.AutoSize = true;
            ag_dataLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ag_dataLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ag_dataLabel.Location = new System.Drawing.Point(360, 31);
            ag_dataLabel.Name = "ag_dataLabel";
            ag_dataLabel.Size = new System.Drawing.Size(55, 21);
            ag_dataLabel.TabIndex = 2;
            ag_dataLabel.Text = "Data:";
            // 
            // ag_horarioLabel
            // 
            ag_horarioLabel.AutoSize = true;
            ag_horarioLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ag_horarioLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ag_horarioLabel.Location = new System.Drawing.Point(475, 31);
            ag_horarioLabel.Name = "ag_horarioLabel";
            ag_horarioLabel.Size = new System.Drawing.Size(69, 21);
            ag_horarioLabel.TabIndex = 4;
            ag_horarioLabel.Text = "Horário:";
            // 
            // ag_situacaoLabel
            // 
            ag_situacaoLabel.AutoSize = true;
            ag_situacaoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ag_situacaoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ag_situacaoLabel.Location = new System.Drawing.Point(104, 31);
            ag_situacaoLabel.Name = "ag_situacaoLabel";
            ag_situacaoLabel.Size = new System.Drawing.Size(231, 21);
            ag_situacaoLabel.TabIndex = 6;
            ag_situacaoLabel.Text = "Situação do Agendamento:";
            // 
            // ag_totalLabel
            // 
            ag_totalLabel.AutoSize = true;
            ag_totalLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ag_totalLabel.ForeColor = System.Drawing.Color.Firebrick;
            ag_totalLabel.Location = new System.Drawing.Point(453, 120);
            ag_totalLabel.Name = "ag_totalLabel";
            ag_totalLabel.Size = new System.Drawing.Size(117, 19);
            ag_totalLabel.TabIndex = 10;
            ag_totalLabel.Text = "Total a pagar:";
            // 
            // ani_fotoLabel
            // 
            ani_fotoLabel.AutoSize = true;
            ani_fotoLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            ani_fotoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ani_fotoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_fotoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ani_fotoLabel.Location = new System.Drawing.Point(57, 144);
            ani_fotoLabel.Name = "ani_fotoLabel";
            ani_fotoLabel.Size = new System.Drawing.Size(78, 25);
            ani_fotoLabel.TabIndex = 29;
            ani_fotoLabel.Text = "Animal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            label1.Location = new System.Drawing.Point(24, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 18);
            label1.TabIndex = 30;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            label2.Location = new System.Drawing.Point(165, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 18);
            label2.TabIndex = 30;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            label3.Location = new System.Drawing.Point(339, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 18);
            label3.TabIndex = 30;
            label3.Text = "Quant.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            label4.Location = new System.Drawing.Point(434, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 18);
            label4.TabIndex = 30;
            label4.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLocalizar);
            this.groupBox1.Controls.Add(ani_fotoLabel);
            this.groupBox1.Controls.Add(this.ani_fotoPictureBox);
            this.groupBox1.Controls.Add(ag_codigoLabel);
            this.groupBox1.Controls.Add(this.ag_animalComboBox);
            this.groupBox1.Controls.Add(this.ag_codigoTextBox);
            this.groupBox1.Controls.Add(ag_dataLabel);
            this.groupBox1.Controls.Add(this.ag_dataMaskedTextBox);
            this.groupBox1.Controls.Add(ag_horarioLabel);
            this.groupBox1.Controls.Add(this.ag_horarioMaskedTextBox);
            this.groupBox1.Controls.Add(ag_situacaoLabel);
            this.groupBox1.Controls.Add(this.ag_situacaoComboBox);
            this.groupBox1.Controls.Add(ag_totalLabel);
            this.groupBox1.Controls.Add(this.ag_totalTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Agendamento";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLocalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocalizar.BackgroundImage")));
            this.btnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizar.Location = new System.Drawing.Point(148, 203);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(40, 36);
            this.btnLocalizar.TabIndex = 30;
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // ani_fotoPictureBox
            // 
            this.ani_fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animalBindingSource, "ani_foto", true));
            this.ani_fotoPictureBox.Enabled = false;
            this.ani_fotoPictureBox.Location = new System.Drawing.Point(194, 131);
            this.ani_fotoPictureBox.Name = "ani_fotoPictureBox";
            this.ani_fotoPictureBox.Size = new System.Drawing.Size(120, 120);
            this.ani_fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ani_fotoPictureBox.TabIndex = 28;
            this.ani_fotoPictureBox.TabStop = false;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.petshopDataSet;
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ag_animalComboBox
            // 
            this.ag_animalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendamentoBindingSource, "ag_animal", true));
            this.ag_animalComboBox.DataSource = this.animalBindingSource;
            this.ag_animalComboBox.DisplayMember = "ani_nome";
            this.ag_animalComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ag_animalComboBox.FormattingEnabled = true;
            this.ag_animalComboBox.Location = new System.Drawing.Point(12, 172);
            this.ag_animalComboBox.Name = "ag_animalComboBox";
            this.ag_animalComboBox.Size = new System.Drawing.Size(176, 29);
            this.ag_animalComboBox.TabIndex = 9;
            this.ag_animalComboBox.ValueMember = "ani_codigo";
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataMember = "agendamento";
            this.agendamentoBindingSource.DataSource = this.petshopDataSet;
            this.agendamentoBindingSource.PositionChanged += new System.EventHandler(this.agendamentoBindingSource_PositionChanged);
            // 
            // ag_codigoTextBox
            // 
            this.ag_codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_codigo", true));
            this.ag_codigoTextBox.Enabled = false;
            this.ag_codigoTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ag_codigoTextBox.Location = new System.Drawing.Point(20, 64);
            this.ag_codigoTextBox.Name = "ag_codigoTextBox";
            this.ag_codigoTextBox.Size = new System.Drawing.Size(68, 27);
            this.ag_codigoTextBox.TabIndex = 1;
            this.ag_codigoTextBox.TextChanged += new System.EventHandler(this.ag_codigoTextBox_TextChanged);
            // 
            // ag_dataMaskedTextBox
            // 
            this.ag_dataMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_data", true));
            this.ag_dataMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ag_dataMaskedTextBox.Location = new System.Drawing.Point(364, 64);
            this.ag_dataMaskedTextBox.Mask = "00/00/0000";
            this.ag_dataMaskedTextBox.Name = "ag_dataMaskedTextBox";
            this.ag_dataMaskedTextBox.Size = new System.Drawing.Size(94, 27);
            this.ag_dataMaskedTextBox.TabIndex = 3;
            this.ag_dataMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ag_horarioMaskedTextBox
            // 
            this.ag_horarioMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_horario", true));
            this.ag_horarioMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ag_horarioMaskedTextBox.Location = new System.Drawing.Point(479, 64);
            this.ag_horarioMaskedTextBox.Mask = "00:00";
            this.ag_horarioMaskedTextBox.Name = "ag_horarioMaskedTextBox";
            this.ag_horarioMaskedTextBox.Size = new System.Drawing.Size(76, 27);
            this.ag_horarioMaskedTextBox.TabIndex = 5;
            this.ag_horarioMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ag_situacaoComboBox
            // 
            this.ag_situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_situacao", true));
            this.ag_situacaoComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ag_situacaoComboBox.FormattingEnabled = true;
            this.ag_situacaoComboBox.Items.AddRange(new object[] {
            "Agendado",
            "Em Andamento",
            "Finalizado"});
            this.ag_situacaoComboBox.Location = new System.Drawing.Point(108, 64);
            this.ag_situacaoComboBox.Name = "ag_situacaoComboBox";
            this.ag_situacaoComboBox.Size = new System.Drawing.Size(230, 29);
            this.ag_situacaoComboBox.TabIndex = 7;
            // 
            // ag_totalTextBox
            // 
            this.ag_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_total", true));
            this.ag_totalTextBox.Enabled = false;
            this.ag_totalTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ag_totalTextBox.Location = new System.Drawing.Point(479, 142);
            this.ag_totalTextBox.Name = "ag_totalTextBox";
            this.ag_totalTextBox.Size = new System.Drawing.Size(65, 27);
            this.ag_totalTextBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCodServ);
            this.groupBox2.Controls.Add(this.txtServico);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.btnAddServ);
            this.groupBox2.Controls.Add(this.txtQtd);
            this.groupBox2.Controls.Add(this.txtValorUnit);
            this.groupBox2.Controls.Add(this.view_ServicosAgendamentoDataGridView);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 297);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços";
            // 
            // txtCodServ
            // 
            this.txtCodServ.Location = new System.Drawing.Point(21, 43);
            this.txtCodServ.Mask = "000";
            this.txtCodServ.Name = "txtCodServ";
            this.txtCodServ.Size = new System.Drawing.Size(67, 23);
            this.txtCodServ.TabIndex = 34;
            this.txtCodServ.ValidatingType = typeof(int);
            this.txtCodServ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodServ_KeyDown);
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(112, 43);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(200, 23);
            this.txtServico.TabIndex = 33;
            // 
            // btnAddServ
            // 
            this.btnAddServ.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddServ.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServ.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAddServ.Location = new System.Drawing.Point(507, 25);
            this.btnAddServ.Name = "btnAddServ";
            this.btnAddServ.Size = new System.Drawing.Size(48, 41);
            this.btnAddServ.TabIndex = 31;
            this.btnAddServ.Text = "+";
            this.btnAddServ.UseVisualStyleBackColor = false;
            this.btnAddServ.Click += new System.EventHandler(this.btnAddServ_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(334, 43);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(67, 23);
            this.txtQtd.TabIndex = 3;
            this.txtQtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQtd_KeyDown);
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Location = new System.Drawing.Point(425, 43);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(67, 23);
            this.txtValorUnit.TabIndex = 1;
            this.txtValorUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorUnit_KeyDown);
            // 
            // view_ServicosAgendamentoDataGridView
            // 
            this.view_ServicosAgendamentoDataGridView.AllowUserToAddRows = false;
            this.view_ServicosAgendamentoDataGridView.AllowUserToDeleteRows = false;
            this.view_ServicosAgendamentoDataGridView.AutoGenerateColumns = false;
            this.view_ServicosAgendamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_ServicosAgendamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.view_ServicosAgendamentoDataGridView.DataSource = this.view_ServicosAgendamentoBindingSource;
            this.view_ServicosAgendamentoDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.view_ServicosAgendamentoDataGridView.Location = new System.Drawing.Point(7, 101);
            this.view_ServicosAgendamentoDataGridView.Name = "view_ServicosAgendamentoDataGridView";
            this.view_ServicosAgendamentoDataGridView.ReadOnly = true;
            this.view_ServicosAgendamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_ServicosAgendamentoDataGridView.Size = new System.Drawing.Size(564, 172);
            this.view_ServicosAgendamentoDataGridView.TabIndex = 0;
            this.view_ServicosAgendamentoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_ServicosAgendamentoDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ag_serv_numero";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Número";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 85;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ag_serv_agendamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "ag_serv_agendamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ag_serv_servico";
            this.dataGridViewTextBoxColumn3.HeaderText = "ag_serv_servico";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "serv_descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "serv_tempo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tempo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 77;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ag_serv_quantidade";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quant.";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 78;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ag_serv_valor_unitario";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn7.HeaderText = "Valor Único";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 98;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SubTotal";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn8.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 87;
            // 
            // view_ServicosAgendamentoBindingSource
            // 
            this.view_ServicosAgendamentoBindingSource.DataMember = "View_ServicosAgendamento";
            this.view_ServicosAgendamentoBindingSource.DataSource = this.petshopDataSet;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "servico";
            this.servicoBindingSource.DataSource = this.petshopDataSet;
            // 
            // agendamentoTableAdapter
            // 
            this.agendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = this.agendamentoTableAdapter;
            this.tableAdapterManager.animalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PRJPetShop.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // agendamentoBindingNavigator
            // 
            this.agendamentoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.agendamentoBindingNavigator.BindingSource = this.agendamentoBindingSource;
            this.agendamentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agendamentoBindingNavigator.DeleteItem = null;
            this.agendamentoBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.agendamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.agendamentoBindingNavigatorSaveItem,
            this.bntCancelar,
            this.bntEditar,
            this.toolStripButton1});
            this.agendamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agendamentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agendamentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agendamentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agendamentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agendamentoBindingNavigator.Name = "agendamentoBindingNavigator";
            this.agendamentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agendamentoBindingNavigator.Size = new System.Drawing.Size(600, 35);
            this.agendamentoBindingNavigator.TabIndex = 3;
            this.agendamentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 32);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // agendamentoBindingNavigatorSaveItem
            // 
            this.agendamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agendamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agendamentoBindingNavigatorSaveItem.Image")));
            this.agendamentoBindingNavigatorSaveItem.Name = "agendamentoBindingNavigatorSaveItem";
            this.agendamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(32, 32);
            this.agendamentoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.agendamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.agendamentoBindingNavigatorSaveItem_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bntCancelar.Image")));
            this.bntCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(85, 32);
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Image = ((System.Drawing.Image)(resources.GetObject("bntEditar.Image")));
            this.bntEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(69, 32);
            this.bntEditar.Text = "Editar";
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(82, 32);
            this.toolStripButton1.Text = "Finalizar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // agendamento_servicosBindingSource
            // 
            this.agendamento_servicosBindingSource.DataMember = "agendamento_servicos";
            this.agendamento_servicosBindingSource.DataSource = this.petshopDataSet;
            // 
            // agendamento_servicosTableAdapter
            // 
            this.agendamento_servicosTableAdapter.ClearBeforeFill = true;
            // 
            // view_ServicosAgendamentoTableAdapter
            // 
            this.view_ServicosAgendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // view_TotalServicosBindingSource
            // 
            this.view_TotalServicosBindingSource.DataMember = "View_TotalServicos";
            this.view_TotalServicosBindingSource.DataSource = this.petshopDataSet;
            // 
            // view_TotalServicosTableAdapter
            // 
            this.view_TotalServicosTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 621);
            this.Controls.Add(this.agendamentoBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadAgendamento";
            this.Text = "frmCadAgendamento";
            this.Load += new System.EventHandler(this.frmCadAgendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ani_fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicosAgendamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicosAgendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingNavigator)).EndInit();
            this.agendamentoBindingNavigator.ResumeLayout(false);
            this.agendamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamento_servicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TotalServicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private petshopDataSetTableAdapters.agendamentoTableAdapter agendamentoTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator agendamentoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton agendamentoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ag_codigoTextBox;
        private System.Windows.Forms.MaskedTextBox ag_dataMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox ag_horarioMaskedTextBox;
        private System.Windows.Forms.ComboBox ag_situacaoComboBox;
        private System.Windows.Forms.ComboBox ag_animalComboBox;
        private System.Windows.Forms.TextBox ag_totalTextBox;
        private petshopDataSetTableAdapters.animalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.PictureBox ani_fotoPictureBox;
        private System.Windows.Forms.ToolStripButton bntCancelar;
        private System.Windows.Forms.ToolStripButton bntEditar;
        private System.Windows.Forms.BindingSource agendamento_servicosBindingSource;
        private petshopDataSetTableAdapters.agendamento_servicosTableAdapter agendamento_servicosTableAdapter;
        private System.Windows.Forms.BindingSource view_ServicosAgendamentoBindingSource;
        private petshopDataSetTableAdapters.View_ServicosAgendamentoTableAdapter view_ServicosAgendamentoTableAdapter;
        private System.Windows.Forms.DataGridView view_ServicosAgendamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Button btnAddServ;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private petshopDataSetTableAdapters.servicoTableAdapter servicoTableAdapter;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.MaskedTextBox txtCodServ;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource view_TotalServicosBindingSource;
        private petshopDataSetTableAdapters.View_TotalServicosTableAdapter view_TotalServicosTableAdapter;
        private System.Windows.Forms.Button btnLocalizar;
    }
}