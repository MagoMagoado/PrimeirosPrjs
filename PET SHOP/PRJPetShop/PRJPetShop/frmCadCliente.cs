using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRJPetShop
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();//valida os dados
                this.clienteBindingSource.EndEdit();//finaliza edição
                clienteTableAdapter.Update(petshopDataSet.cliente);
                groupBox1.Enabled = false;//bloqueia a GroupBox
                MessageBox.Show("Registro Salvo", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
            catch(Exception erro)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados. ", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;//libera a groupbox
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que quer excluir o registro atual?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();//remove registro atual
                    clienteTableAdapter.Update(petshopDataSet.cliente);
                    MessageBox.Show("Registro excluído com sucesso.", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                //chama o método FILL (preencher dados)
                clienteTableAdapter.Fill(petshopDataSet.cliente);
                //avisa o erro
                MessageBox.Show("Não foi possível excluir os dados.", "PetShop", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                //define filtro de imagem

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    cli_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoTroca = 0;
            FrmLocalizarCliente loca = new FrmLocalizarCliente();
            loca.ShowDialog();
            if (VariaveisGlobais.CodigoTroca > 0) //se ele encontrou registro
            {
                //posicionar códgio localizado
                clienteBindingSource.Position = clienteBindingSource.Find("cli_codigo", VariaveisGlobais.CodigoTroca);
            }
        }
    }
}
