namespace PRJPetShop
{
    partial class frmCadServico
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
            System.Windows.Forms.Label serv_codigoLabel;
            System.Windows.Forms.Label serv_descricaoLabel;
            System.Windows.Forms.Label serv_precoLabel;
            System.Windows.Forms.Label serv_tempoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadServico));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serv_codigoTextBox = new System.Windows.Forms.TextBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet = new PRJPetShop.petshopDataSet();
            this.serv_descricaoTextBox = new System.Windows.Forms.TextBox();
            this.serv_precoTextBox = new System.Windows.Forms.TextBox();
            this.serv_tempoComboBox = new System.Windows.Forms.ComboBox();
            this.servicoTableAdapter = new PRJPetShop.petshopDataSetTableAdapters.servicoTableAdapter();
            this.tableAdapterManager = new PRJPetShop.petshopDataSetTableAdapters.TableAdapterManager();
            this.servicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.servicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bntCancelar = new System.Windows.Forms.ToolStripButton();
            this.bntEditar = new System.Windows.Forms.ToolStripButton();
            serv_codigoLabel = new System.Windows.Forms.Label();
            serv_descricaoLabel = new System.Windows.Forms.Label();
            serv_precoLabel = new System.Windows.Forms.Label();
            serv_tempoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingNavigator)).BeginInit();
            this.servicoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // serv_codigoLabel
            // 
            serv_codigoLabel.AutoSize = true;
            serv_codigoLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serv_codigoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            serv_codigoLabel.Location = new System.Drawing.Point(42, 56);
            serv_codigoLabel.Name = "serv_codigoLabel";
            serv_codigoLabel.Size = new System.Drawing.Size(123, 33);
            serv_codigoLabel.TabIndex = 0;
            serv_codigoLabel.Text = "Código:";
            // 
            // serv_descricaoLabel
            // 
            serv_descricaoLabel.AutoSize = true;
            serv_descricaoLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serv_descricaoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            serv_descricaoLabel.Location = new System.Drawing.Point(42, 107);
            serv_descricaoLabel.Name = "serv_descricaoLabel";
            serv_descricaoLabel.Size = new System.Drawing.Size(154, 33);
            serv_descricaoLabel.TabIndex = 2;
            serv_descricaoLabel.Text = "Descrição:";
            // 
            // serv_precoLabel
            // 
            serv_precoLabel.AutoSize = true;
            serv_precoLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serv_precoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            serv_precoLabel.Location = new System.Drawing.Point(42, 166);
            serv_precoLabel.Name = "serv_precoLabel";
            serv_precoLabel.Size = new System.Drawing.Size(99, 33);
            serv_precoLabel.TabIndex = 4;
            serv_precoLabel.Text = "Preço:";
            // 
            // serv_tempoLabel
            // 
            serv_tempoLabel.AutoSize = true;
            serv_tempoLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serv_tempoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            serv_tempoLabel.Location = new System.Drawing.Point(42, 222);
            serv_tempoLabel.Name = "serv_tempoLabel";
            serv_tempoLabel.Size = new System.Drawing.Size(113, 33);
            serv_tempoLabel.TabIndex = 6;
            serv_tempoLabel.Text = "Tempo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(serv_codigoLabel);
            this.groupBox1.Controls.Add(this.serv_codigoTextBox);
            this.groupBox1.Controls.Add(serv_descricaoLabel);
            this.groupBox1.Controls.Add(this.serv_descricaoTextBox);
            this.groupBox1.Controls.Add(serv_precoLabel);
            this.groupBox1.Controls.Add(this.serv_precoTextBox);
            this.groupBox1.Controls.Add(serv_tempoLabel);
            this.groupBox1.Controls.Add(this.serv_tempoComboBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 467);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro Serviços";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "minutos";
            // 
            // serv_codigoTextBox
            // 
            this.serv_codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_codigo", true));
            this.serv_codigoTextBox.Enabled = false;
            this.serv_codigoTextBox.Location = new System.Drawing.Point(196, 60);
            this.serv_codigoTextBox.Name = "serv_codigoTextBox";
            this.serv_codigoTextBox.Size = new System.Drawing.Size(100, 31);
            this.serv_codigoTextBox.TabIndex = 1;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "servico";
            this.servicoBindingSource.DataSource = this.petshopDataSet;
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serv_descricaoTextBox
            // 
            this.serv_descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_descricao", true));
            this.serv_descricaoTextBox.Location = new System.Drawing.Point(196, 111);
            this.serv_descricaoTextBox.Name = "serv_descricaoTextBox";
            this.serv_descricaoTextBox.Size = new System.Drawing.Size(206, 31);
            this.serv_descricaoTextBox.TabIndex = 3;
            // 
            // serv_precoTextBox
            // 
            this.serv_precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_preco", true));
            this.serv_precoTextBox.Location = new System.Drawing.Point(196, 170);
            this.serv_precoTextBox.Name = "serv_precoTextBox";
            this.serv_precoTextBox.Size = new System.Drawing.Size(100, 31);
            this.serv_precoTextBox.TabIndex = 5;
            // 
            // serv_tempoComboBox
            // 
            this.serv_tempoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_tempo", true));
            this.serv_tempoComboBox.FormattingEnabled = true;
            this.serv_tempoComboBox.Items.AddRange(new object[] {
            "10",
            "15",
            "30",
            "35"});
            this.serv_tempoComboBox.Location = new System.Drawing.Point(196, 226);
            this.serv_tempoComboBox.Name = "serv_tempoComboBox";
            this.serv_tempoComboBox.Size = new System.Drawing.Size(100, 30);
            this.serv_tempoComboBox.TabIndex = 7;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = this.servicoTableAdapter;
            this.tableAdapterManager.UpdateOrder = PRJPetShop.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servicoBindingNavigator
            // 
            this.servicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.servicoBindingNavigator.BindingSource = this.servicoBindingSource;
            this.servicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servicoBindingNavigator.DeleteItem = null;
            this.servicoBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.servicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.servicoBindingNavigatorSaveItem,
            this.bntCancelar,
            this.bntEditar});
            this.servicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.servicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servicoBindingNavigator.Name = "servicoBindingNavigator";
            this.servicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servicoBindingNavigator.Size = new System.Drawing.Size(600, 35);
            this.servicoBindingNavigator.TabIndex = 3;
            this.servicoBindingNavigator.Text = "bindingNavigator1";
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
            // servicoBindingNavigatorSaveItem
            // 
            this.servicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.servicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("servicoBindingNavigatorSaveItem.Image")));
            this.servicoBindingNavigatorSaveItem.Name = "servicoBindingNavigatorSaveItem";
            this.servicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(32, 32);
            this.servicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.servicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.servicoBindingNavigatorSaveItem_Click);
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
            // frmCadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.servicoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadServico";
            this.Text = "frmCadServico";
            this.Load += new System.EventHandler(this.frmCadServico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingNavigator)).EndInit();
            this.servicoBindingNavigator.ResumeLayout(false);
            this.servicoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private petshopDataSetTableAdapters.servicoTableAdapter servicoTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator servicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton servicoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox serv_codigoTextBox;
        private System.Windows.Forms.TextBox serv_descricaoTextBox;
        private System.Windows.Forms.TextBox serv_precoTextBox;
        private System.Windows.Forms.ComboBox serv_tempoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton bntCancelar;
        private System.Windows.Forms.ToolStripButton bntEditar;
        private System.Windows.Forms.Label label2;
    }
}