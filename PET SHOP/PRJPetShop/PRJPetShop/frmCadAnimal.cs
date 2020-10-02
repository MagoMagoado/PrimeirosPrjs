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
    public partial class frmCadAnimal : Form
    {
        public frmCadAnimal()
        {
            InitializeComponent();
        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();//valida os dados
                this.animalBindingSource.EndEdit();//finaliza edição
                animalTableAdapter.Update(petshopDataSet.animal);
                groupBox1.Enabled = false;//bloqueia a GroupBox
                MessageBox.Show("Registro Salvo", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados. ", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frmCadAnimal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.petshopDataSet.raca);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.petshopDataSet.animal);

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
                    animalBindingSource.RemoveCurrent();//remove registro atual
                    animalTableAdapter.Update(petshopDataSet.animal);
                    MessageBox.Show("Registro excluído com sucesso.", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                //chama o método FILL (preencher dados)
                animalTableAdapter.Fill(petshopDataSet.animal);
                //avisa o erro
                MessageBox.Show("Não foi possível excluir os dados.", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            animalBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                //define filtro de imagem

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ani_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
