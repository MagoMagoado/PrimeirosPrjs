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
    public partial class frmCadServico : Form
    {
        public frmCadServico()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();//valida os dados
                this.servicoBindingSource.EndEdit();//finaliza edição
                servicoTableAdapter.Update(petshopDataSet.servico);
                groupBox1.Enabled = false;//bloqueia a GroupBox
                MessageBox.Show("Registro Salvo", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados. ", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.petshopDataSet.servico);

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
                 servicoBindingSource.RemoveCurrent();//remove registro atual
                    servicoTableAdapter.Update(petshopDataSet.servico);
                    MessageBox.Show("Registro excluído com sucesso.", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                //chama o método FILL (preencher dados)
                servicoTableAdapter.Fill(petshopDataSet.servico);
                //avisa o erro
                MessageBox.Show("Não foi possível excluir os dados.", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            servicoBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
    }
}
