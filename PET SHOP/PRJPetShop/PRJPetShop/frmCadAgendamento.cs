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
    public partial class frmCadAgendamento : Form
    {
        public frmCadAgendamento()
        {
            InitializeComponent();
        }

        private void agendamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();//valida os dados
                this.agendamentoBindingSource.EndEdit();//finaliza edição
                agendamentoTableAdapter.Update(petshopDataSet.agendamento);
                groupBox1.Enabled = false;//bloqueia a GroupBox
                MessageBox.Show("Registro Salvo. Insira o serviço abaixo.", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodServ.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados. ", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Finalizado();
        }

        private void frmCadAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.View_TotalServicos'. Você pode movê-la ou removê-la conforme necessário.
            this.view_TotalServicosTableAdapter.Fill(this.petshopDataSet.View_TotalServicos);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.petshopDataSet.servico);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.View_ServicosAgendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.view_ServicosAgendamentoTableAdapter.Fill(this.petshopDataSet.View_ServicosAgendamento);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.agendamento_servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamento_servicosTableAdapter.Fill(this.petshopDataSet.agendamento_servicos);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.petshopDataSet.animal);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.agendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamentoTableAdapter.Fill(this.petshopDataSet.agendamento);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ag_situacaoComboBox.Text = "Agendado";//deixa a caixa situação com agendado
            ag_dataMaskedTextBox.Text = DateTime.Now.ToShortDateString();//caixa data com agendado
            ag_horarioMaskedTextBox.Text = DateTime.Now.ToShortTimeString();//caixa horario com agendado
            ag_totalTextBox.Text = "0.00";
            groupBox1.Enabled = true;//libera a groupbox
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que quer excluir o registro atual?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    agendamentoBindingSource.RemoveCurrent();//remove registro atual
                    agendamentoTableAdapter.Update(petshopDataSet.agendamento);
                    MessageBox.Show("Registro excluído com sucesso.", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                //chama o método FILL (preencher dados)
                agendamentoTableAdapter.Fill(petshopDataSet.agendamento);
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

        private void txtCodServ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCodServ.Text != "")
            {
                servicoBindingSource.Filter = "serv_codigo = " + txtCodServ.Text;
                if (servicoBindingSource.Count == 1)//encontrou 1 serviço
                {
                    //cria uma variavel com todos os dados do registro encontrado
                    DataRowView ServicoEncontrado = (DataRowView)servicoBindingSource.Current;
                    txtServico.Text = ServicoEncontrado["serv_descricao"].ToString();
                    txtValorUnit.Text = ServicoEncontrado["serv_preco"].ToString();
                    txtQtd.Text = "1";
                    txtQtd.SelectAll();
                    txtQtd.Focus();
                }
                else //abrir o cadastro pra ele localizar 
                {
                    frmCadServico serv = new frmCadServico();
                    serv.ShowDialog();
                    //joga os valores para as textBoxes
                }
            }
        }

        private void btnAddServ_Click(object sender, EventArgs e)
        {
            try
            {
                agendamento_servicosTableAdapter.InserirServico(int.Parse(ag_codigoTextBox.Text),
                int.Parse(txtCodServ.Text), int.Parse(txtQtd.Text), decimal.Parse(txtValorUnit.Text));
                //limpa todas as TextBoxes acima
                txtCodServ.Clear();
                txtServico.Clear();
                txtQtd.Clear();
                txtValorUnit.Clear();
                txtCodServ.Focus();
                //atualiza Grid
                Atualizar_Grid();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro. Tente novamente.", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Total();
        }

        private void Atualizar_Grid()
        {
            try
            {
                if (ag_codigoTextBox.Text !="")//pesquisar
                {
                    //recarrega os dados
                    view_ServicosAgendamentoTableAdapter.Fill(petshopDataSet.View_ServicosAgendamento);
                    //filtra pelo Código do Agendamento
                    view_ServicosAgendamentoBindingSource.Filter = "ag_serv_agendamento =" + ag_codigoTextBox.Text;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ag_codigoTextBox_TextChanged(object sender, EventArgs e)
        {
            Atualizar_Grid();
        }

        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && txtQtd.Text !="")
            {
                txtValorUnit.SelectAll();
                txtValorUnit.Focus();
            }
        }

        private void txtValorUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtValorUnit.Text != "")
            {
                btnAddServ_Click(sender, e);
            }
        }

        private void view_ServicosAgendamentoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Codigo = 0;
                Codigo = int.Parse(view_ServicosAgendamentoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                agendamento_servicosTableAdapter.RemoverServico(Codigo);
            }
            catch (Exception)
            {

            }
            Atualizar_Grid();
            Total();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Após finalizado, o agendamento não poderá  ser mais alterado", "PetShop",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ag_situacaoComboBox.Text = "Finalizado"; //muda o text da combo
                agendamentoBindingSource.EndEdit();//finalizar edição
                agendamentoTableAdapter.Update(petshopDataSet.agendamento); //salva as alterações
                MessageBox.Show("Agendamento finalizado com sucesso!", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //bloquear is botoes
                Finalizado();
            }           
        }

        private void Finalizado() 
        {
            if (ag_situacaoComboBox.Text=="Finalizado")
            {
                //bloquear os botoes
                bindingNavigatorDeleteItem.Enabled = false;
                agendamentoBindingNavigatorSaveItem.Enabled = false;
                bntCancelar.Enabled = false;
                bntEditar.Enabled = false;
                toolStripButton1.Enabled = false;
                groupBox2.Enabled = false;
            }
            else
            {
                //libera os botoes
                bindingNavigatorDeleteItem.Enabled = true;
                agendamentoBindingNavigatorSaveItem.Enabled = true;
                bntCancelar.Enabled = true;
                bntEditar.Enabled = true;
                toolStripButton1.Enabled = true;
                groupBox2.Enabled = true;
            }
        }

        private void agendamentoBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Finalizado();
        }

        private void Total()
        {
            if (ag_codigoTextBox.Text != "")
            {
                view_TotalServicosTableAdapter.Fill(petshopDataSet.View_TotalServicos); //carrega os dados
                view_TotalServicosBindingSource.Filter = "ag_serv_agendamento = " + ag_codigoTextBox.Text;
                if (view_TotalServicosBindingSource.Count == 1)
                {
                    //pegar o total e jogar na TextBox
                    DataRowView Resultado = (DataRowView)view_TotalServicosBindingSource.Current;
                    ag_totalTextBox.Text = Resultado["Total"].ToString();
                    agendamentoTableAdapter.Update(petshopDataSet.agendamento);
                }
                else //se nao tiver itens/serviços, o Total é 0
                {
                    ag_totalTextBox.Text = "0.00";
                    agendamentoTableAdapter.Update(petshopDataSet.agendamento);
                }
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoTroca = 0;
            frmLocalizarAnimal loca = new frmLocalizarAnimal();
            loca.ShowDialog();
            if (VariaveisGlobais.CodigoTroca > 0) //se ele encontrou registro
            {
                //posicionar códgio localizado
                animalBindingSource.Position = animalBindingSource.Find("ani_codigo", VariaveisGlobais.CodigoTroca);
            }
        }
    }
}
