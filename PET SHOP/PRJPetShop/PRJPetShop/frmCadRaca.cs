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
    public partial class frmCadRaca : Form
    {
        public frmCadRaca()
        {
            InitializeComponent();
        }

        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();//valida os dados
                this.racaBindingSource.EndEdit();//finaliza edição
                racaTableAdapter.Update(petshopDataSet.raca);
                groupBox1.Enabled = false;//bloqueia a GroupBox
                MessageBox.Show("Registro Salvo", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados. ", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmCadRaca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.petshopDataSet.raca);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;//libera a groupbox
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que quer excluir o registro atual?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    racaBindingSource.RemoveCurrent();//remove registro atual
                    racaTableAdapter.Update(petshopDataSet.raca);
                    MessageBox.Show("Registro excluído com sucesso.", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                //chama o método FILL (preencher dados)
                racaTableAdapter.Fill(petshopDataSet.raca);
                //avisa o erro
                MessageBox.Show("Não foi possível excluir os dados.", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            racaBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
    }
}
