namespace PRJPetShop
{
    partial class frmCadAnimal
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
            System.Windows.Forms.Label ani_codigoLabel;
            System.Windows.Forms.Label ani_nomeLabel;
            System.Windows.Forms.Label ani_idadeLabel;
            System.Windows.Forms.Label ani_alergiaLabel;
            System.Windows.Forms.Label ani_racaLabel;
            System.Windows.Forms.Label ani_sexoLabel;
            System.Windows.Forms.Label ani_agressivoLabel;
            System.Windows.Forms.Label ani_corLabel;
            System.Windows.Forms.Label ani_fotoLabel;
            System.Windows.Forms.Label cli_fotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAnimal));
            this.petshopDataSet = new PRJPetShop.petshopDataSet();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new PRJPetShop.petshopDataSetTableAdapters.animalTableAdapter();
            this.tableAdapterManager = new PRJPetShop.petshopDataSetTableAdapters.TableAdapterManager();
            this.racaTableAdapter = new PRJPetShop.petshopDataSetTableAdapters.racaTableAdapter();
            this.animalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.animalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bntCancelar = new System.Windows.Forms.ToolStripButton();
            this.bntEditar = new System.Windows.Forms.ToolStripButton();
            this.ani_codigoTextBox = new System.Windows.Forms.TextBox();
            this.ani_nomeTextBox = new System.Windows.Forms.TextBox();
            this.ani_idadeTextBox = new System.Windows.Forms.TextBox();
            this.ani_alergiaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ani_fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ani_corComboBox = new System.Windows.Forms.ComboBox();
            this.ani_agressivoComboBox = new System.Windows.Forms.ComboBox();
            this.ani_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.ani_sexoComboBox = new System.Windows.Forms.ComboBox();
            this.ani_racaComboBox = new System.Windows.Forms.ComboBox();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new PRJPetShop.petshopDataSetTableAdapters.clienteTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dono_foto = new System.Windows.Forms.PictureBox();
            ani_codigoLabel = new System.Windows.Forms.Label();
            ani_nomeLabel = new System.Windows.Forms.Label();
            ani_idadeLabel = new System.Windows.Forms.Label();
            ani_alergiaLabel = new System.Windows.Forms.Label();
            ani_racaLabel = new System.Windows.Forms.Label();
            ani_sexoLabel = new System.Windows.Forms.Label();
            ani_agressivoLabel = new System.Windows.Forms.Label();
            ani_corLabel = new System.Windows.Forms.Label();
            ani_fotoLabel = new System.Windows.Forms.Label();
            cli_fotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).BeginInit();
            this.animalBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ani_fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dono_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // ani_codigoLabel
            // 
            ani_codigoLabel.AutoSize = true;
            ani_codigoLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            ani_codigoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ani_codigoLabel.Location = new System.Drawing.Point(323, 34);
            ani_codigoLabel.Name = "ani_codigoLabel";
            ani_codigoLabel.Size = new System.Drawing.Size(72, 21);
            ani_codigoLabel.TabIndex = 1;
            ani_codigoLabel.Text = "Código:";
            // 
            // ani_nomeLabel
            // 
            ani_nomeLabel.AutoSize = true;
            ani_nomeLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            ani_nomeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ani_nomeLabel.Location = new System.Drawing.Point(23, 34);
            ani_nomeLabel.Name = "ani_nomeLabel";
            ani_nomeLabel.Size = new System.Drawing.Size(61, 21);
            ani_nomeLabel.TabIndex = 3;
            ani_nomeLabel.Text = "Nome:";
            // 
            // ani_idadeLabel
            // 
            ani_idadeLabel.AutoSize = true;
            ani_idadeLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            ani_idadeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ani_idadeLabel.Location = new System.Drawing.Point(6, 237);
            ani_idadeLabel.Name = "ani_idadeLabel";
            ani_idadeLabel.Size = new System.Drawing.Size(62, 21);
            ani_idadeLabel.TabIndex = 11;
            ani_idadeLabel.Text = "Idade:";
            // 
            // ani_alergiaLabel
            // 
            ani_alergiaLabel.AutoSize = true;
            ani_alergiaLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            ani_alergiaLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ani_alergiaLabel.Location = new System.Drawing.Point(5, 278);
            ani_alergiaLabel.Name = "ani_alergiaLabel";
            ani_alergiaLabel.Size = new System.Drawing.Size(70, 21);
            ani_alergiaLabel.TabIndex = 13;
            ani_alergiaLabel.Text = "Alergia:";
            // 
            // ani_racaLabel
            // 
            ani_racaLabel.AutoSize = true;
            ani_racaLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            ani_racaLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ani_racaLabel.Location = new System.Drawing.Point(6, 90);
            ani_racaLabel.Name = "ani_racaLabel";
            ani_racaLabel.Size = new System.Drawing.Size(56, 21);
            ani_racaLabel.TabIndex = 21;
            ani_racaLabel.Text = "Raça:";
            // 
            // ani_sexoLabel
            // 
            ani_sexoLabel.AutoSize = true;
            ani_sexoLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            ani_sexoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ani_sexoLabel.Location = new System.Drawing.Point(6, 126);
            ani_sexoLabel.Name = "ani_sexoLabel";
            ani_sexoLabel.Size = new System.Drawing.Size(50, 21);
            ani_sexoLabel.TabIndex = 22;
            ani_sexoLabel.Text = "Sexo:";
            // 
            // ani_agressivoLabel
            // 
            ani_agressivoLabel.AutoSize = true;
            ani_agressivoLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            ani_agressivoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ani_agressivoLabel.Location = new System.Drawing.Point(6, 165);
            ani_agressivoLabel.Name = "ani_agressivoLabel";
            ani_agressivoLabel.Size = new System.Drawing.Size(88, 21);
            ani_agressivoLabel.TabIndex = 23;
            ani_agressivoLabel.Text = "Agressivo:";
            // 
            // ani_corLabel
            // 
            ani_corLabel.AutoSize = true;
            ani_corLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            ani_corLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ani_corLabel.Location = new System.Drawing.Point(6, 201);
            ani_corLabel.Name = "ani_corLabel";
            ani_corLabel.Size = new System.Drawing.Size(42, 21);
            ani_corLabel.TabIndex = 24;
            ani_corLabel.Text = "Cor:";
            // 
            // ani_fotoLabel
            // 
            ani_fotoLabel.AutoSize = true;
            ani_fotoLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            ani_fotoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ani_fotoLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_fotoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            ani_fotoLabel.Location = new System.Drawing.Point(9, 319);
            ani_fotoLabel.Name = "ani_fotoLabel";
            ani_fotoLabel.Size = new System.Drawing.Size(74, 27);
            ani_fotoLabel.TabIndex = 26;
            ani_fotoLabel.Text = "Dono:";
            // 
            // cli_fotoLabel
            // 
            cli_fotoLabel.AutoSize = true;
            cli_fotoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cli_fotoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            cli_fotoLabel.Location = new System.Drawing.Point(385, 114);
            cli_fotoLabel.Name = "cli_fotoLabel";
            cli_fotoLabel.Size = new System.Drawing.Size(107, 21);
            cli_fotoLabel.TabIndex = 28;
            cli_fotoLabel.Text = "Animal(3x4):";
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.petshopDataSet;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = this.racaTableAdapter;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PRJPetShop.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // animalBindingNavigator
            // 
            this.animalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.animalBindingNavigator.BindingSource = this.animalBindingSource;
            this.animalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animalBindingNavigator.DeleteItem = null;
            this.animalBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.animalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.animalBindingNavigatorSaveItem,
            this.bntCancelar,
            this.bntEditar});
            this.animalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalBindingNavigator.Name = "animalBindingNavigator";
            this.animalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalBindingNavigator.Size = new System.Drawing.Size(600, 35);
            this.animalBindingNavigator.TabIndex = 0;
            this.animalBindingNavigator.Text = "bindingNavigator1";
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
            // animalBindingNavigatorSaveItem
            // 
            this.animalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.animalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("animalBindingNavigatorSaveItem.Image")));
            this.animalBindingNavigatorSaveItem.Name = "animalBindingNavigatorSaveItem";
            this.animalBindingNavigatorSaveItem.Size = new System.Drawing.Size(32, 32);
            this.animalBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.animalBindingNavigatorSaveItem.Click += new System.EventHandler(this.animalBindingNavigatorSaveItem_Click);
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
            // ani_codigoTextBox
            // 
            this.ani_codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_codigo", true));
            this.ani_codigoTextBox.Enabled = false;
            this.ani_codigoTextBox.Location = new System.Drawing.Point(401, 30);
            this.ani_codigoTextBox.Name = "ani_codigoTextBox";
            this.ani_codigoTextBox.Size = new System.Drawing.Size(98, 31);
            this.ani_codigoTextBox.TabIndex = 2;
            // 
            // ani_nomeTextBox
            // 
            this.ani_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_nome", true));
            this.ani_nomeTextBox.Location = new System.Drawing.Point(90, 30);
            this.ani_nomeTextBox.Name = "ani_nomeTextBox";
            this.ani_nomeTextBox.Size = new System.Drawing.Size(227, 31);
            this.ani_nomeTextBox.TabIndex = 4;
            // 
            // ani_idadeTextBox
            // 
            this.ani_idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_idade", true));
            this.ani_idadeTextBox.Location = new System.Drawing.Point(100, 233);
            this.ani_idadeTextBox.Name = "ani_idadeTextBox";
            this.ani_idadeTextBox.Size = new System.Drawing.Size(98, 31);
            this.ani_idadeTextBox.TabIndex = 12;
            // 
            // ani_alergiaTextBox
            // 
            this.ani_alergiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_alergia", true));
            this.ani_alergiaTextBox.Location = new System.Drawing.Point(100, 270);
            this.ani_alergiaTextBox.Name = "ani_alergiaTextBox";
            this.ani_alergiaTextBox.Size = new System.Drawing.Size(227, 31);
            this.ani_alergiaTextBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dono_foto);
            this.groupBox1.Controls.Add(this.btnFoto);
            this.groupBox1.Controls.Add(cli_fotoLabel);
            this.groupBox1.Controls.Add(ani_fotoLabel);
            this.groupBox1.Controls.Add(this.ani_fotoPictureBox);
            this.groupBox1.Controls.Add(ani_corLabel);
            this.groupBox1.Controls.Add(this.ani_corComboBox);
            this.groupBox1.Controls.Add(ani_agressivoLabel);
            this.groupBox1.Controls.Add(this.ani_agressivoComboBox);
            this.groupBox1.Controls.Add(this.ani_clienteComboBox);
            this.groupBox1.Controls.Add(ani_sexoLabel);
            this.groupBox1.Controls.Add(this.ani_sexoComboBox);
            this.groupBox1.Controls.Add(ani_racaLabel);
            this.groupBox1.Controls.Add(this.ani_racaComboBox);
            this.groupBox1.Controls.Add(ani_codigoLabel);
            this.groupBox1.Controls.Add(this.ani_codigoTextBox);
            this.groupBox1.Controls.Add(this.ani_alergiaTextBox);
            this.groupBox1.Controls.Add(ani_nomeLabel);
            this.groupBox1.Controls.Add(ani_alergiaLabel);
            this.groupBox1.Controls.Add(this.ani_nomeTextBox);
            this.groupBox1.Controls.Add(this.ani_idadeTextBox);
            this.groupBox1.Controls.Add(ani_idadeLabel);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 475);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Animal";
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFoto.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFoto.Location = new System.Drawing.Point(401, 265);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(66, 31);
            this.btnFoto.TabIndex = 30;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.petshopDataSet;
            // 
            // ani_fotoPictureBox
            // 
            this.ani_fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animalBindingSource, "ani_foto", true));
            this.ani_fotoPictureBox.Enabled = false;
            this.ani_fotoPictureBox.Location = new System.Drawing.Point(379, 139);
            this.ani_fotoPictureBox.Name = "ani_fotoPictureBox";
            this.ani_fotoPictureBox.Size = new System.Drawing.Size(120, 120);
            this.ani_fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ani_fotoPictureBox.TabIndex = 27;
            this.ani_fotoPictureBox.TabStop = false;
            // 
            // ani_corComboBox
            // 
            this.ani_corComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_cor", true));
            this.ani_corComboBox.FormattingEnabled = true;
            this.ani_corComboBox.Items.AddRange(new object[] {
            "Marrom",
            "Preto",
            "Branco",
            "Misto",
            "Manchado"});
            this.ani_corComboBox.Location = new System.Drawing.Point(100, 197);
            this.ani_corComboBox.Name = "ani_corComboBox";
            this.ani_corComboBox.Size = new System.Drawing.Size(228, 30);
            this.ani_corComboBox.TabIndex = 25;
            // 
            // ani_agressivoComboBox
            // 
            this.ani_agressivoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_agressivo", true));
            this.ani_agressivoComboBox.FormattingEnabled = true;
            this.ani_agressivoComboBox.Items.AddRange(new object[] {
            "S",
            "N"});
            this.ani_agressivoComboBox.Location = new System.Drawing.Point(100, 161);
            this.ani_agressivoComboBox.Name = "ani_agressivoComboBox";
            this.ani_agressivoComboBox.Size = new System.Drawing.Size(98, 30);
            this.ani_agressivoComboBox.TabIndex = 24;
            // 
            // ani_clienteComboBox
            // 
            this.ani_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "ani_cliente", true));
            this.ani_clienteComboBox.DataSource = this.clienteBindingSource;
            this.ani_clienteComboBox.DisplayMember = "cli_nome";
            this.ani_clienteComboBox.FormattingEnabled = true;
            this.ani_clienteComboBox.Location = new System.Drawing.Point(99, 316);
            this.ani_clienteComboBox.Name = "ani_clienteComboBox";
            this.ani_clienteComboBox.Size = new System.Drawing.Size(228, 30);
            this.ani_clienteComboBox.TabIndex = 26;
            this.ani_clienteComboBox.ValueMember = "cli_codigo";
            // 
            // ani_sexoComboBox
            // 
            this.ani_sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_sexo", true));
            this.ani_sexoComboBox.FormattingEnabled = true;
            this.ani_sexoComboBox.Items.AddRange(new object[] {
            "F",
            "M"});
            this.ani_sexoComboBox.Location = new System.Drawing.Point(100, 122);
            this.ani_sexoComboBox.Name = "ani_sexoComboBox";
            this.ani_sexoComboBox.Size = new System.Drawing.Size(227, 30);
            this.ani_sexoComboBox.TabIndex = 23;
            // 
            // ani_racaComboBox
            // 
            this.ani_racaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "ani_raca", true));
            this.ani_racaComboBox.DataSource = this.racaBindingSource;
            this.ani_racaComboBox.DisplayMember = "raca_nome";
            this.ani_racaComboBox.FormattingEnabled = true;
            this.ani_racaComboBox.Location = new System.Drawing.Point(100, 86);
            this.ani_racaComboBox.Name = "ani_racaComboBox";
            this.ani_racaComboBox.Size = new System.Drawing.Size(227, 30);
            this.ani_racaComboBox.TabIndex = 22;
            this.ani_racaComboBox.ValueMember = "raca_codigo";
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "raca";
            this.racaBindingSource.DataSource = this.petshopDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dono_foto
            // 
            this.dono_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dono_foto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "cli_foto", true));
            this.dono_foto.Location = new System.Drawing.Point(149, 349);
            this.dono_foto.Name = "dono_foto";
            this.dono_foto.Size = new System.Drawing.Size(120, 120);
            this.dono_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dono_foto.TabIndex = 31;
            this.dono_foto.TabStop = false;
            // 
            // frmCadAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.animalBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadAnimal";
            this.Text = "frmCadAnimal";
            this.Load += new System.EventHandler(this.frmCadAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).EndInit();
            this.animalBindingNavigator.ResumeLayout(false);
            this.animalBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ani_fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dono_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private petshopDataSetTableAdapters.animalTableAdapter animalTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator animalBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton animalBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ani_codigoTextBox;
        private System.Windows.Forms.TextBox ani_nomeTextBox;
        private System.Windows.Forms.TextBox ani_idadeTextBox;
        private System.Windows.Forms.TextBox ani_alergiaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ani_racaComboBox;
        private petshopDataSetTableAdapters.racaTableAdapter racaTableAdapter;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private System.Windows.Forms.ComboBox ani_sexoComboBox;
        private System.Windows.Forms.ComboBox ani_clienteComboBox;
        private System.Windows.Forms.ComboBox ani_corComboBox;
        private System.Windows.Forms.ComboBox ani_agressivoComboBox;
        private System.Windows.Forms.PictureBox ani_fotoPictureBox;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private petshopDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.ToolStripButton bntCancelar;
        private System.Windows.Forms.ToolStripButton bntEditar;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox dono_foto;
    }
}