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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //sair
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            //Maximizar
            this.WindowState = FormWindowState.Maximized;
            btnMax.SendToBack();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //minimizar
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal; //Restaurar
            btnRestaurar.SendToBack();

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente cliente = new frmCadCliente(); //cria a instância(copia)
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();//limpa o painel, retira os objetos dele
            panelCentral.Controls.Add(cliente);//Adiciono o form no painel
            cliente.Show();

            //aplica a posição do eixo X do btncliente ao panelselecao
            panelSelecao.Top = btnCliente.Top;

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();//limpa o painel, retira os objetos dele
            panelSelecao.Top = btnInicio.Top;
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            frmCadAnimal animal = new frmCadAnimal(); //cria a instância(copia)
            animal.TopLevel = false;
            animal.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();//limpa o painel, retira os objetos dele
            panelCentral.Controls.Add(animal);//Adiciono o form no painel
            animal.Show();
            panelSelecao.Top = btnAnimal.Top;
        }

        private void btnRaca_Click(object sender, EventArgs e)
        {
            frmCadRaca Raca = new frmCadRaca(); //cria a instância(copia)
            Raca.TopLevel = false;
            Raca.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();//limpa o painel, retira os objetos dele
            panelCentral.Controls.Add(Raca);//Adiciono o form no painel
            Raca.Show();
            panelSelecao.Top = btnRaca.Top;
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            frmCadServico Servico = new frmCadServico(); //cria a instância(copia)
            Servico.TopLevel = false;
            Servico.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();//limpa o painel, retira os objetos dele
            panelCentral.Controls.Add(Servico);//Adiciono o form no painel
            Servico.Show();
            panelSelecao.Top = btnRaca.Top;
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            frmCadAgendamento Agendamento = new frmCadAgendamento(); //cria a instância(copia)
            Agendamento.TopLevel = false;
            Agendamento.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();//limpa o painel, retira os objetos dele
            panelCentral.Controls.Add(Agendamento);//Adiciono o form no painel
            Agendamento.Show();
            panelSelecao.Top = btnAgendamento.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.View_DetalhesAgendamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.view_DetalhesAgendamentosTableAdapter.Fill(this.petshopDataSet.View_DetalhesAgendamentos);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //recarregar os dados na view
            view_DetalhesAgendamentosTableAdapter.Fill(petshopDataSet.View_DetalhesAgendamentos);
            view_DetalhesAgendamentosBindingSource.Filter = "ag_data = '" + DateTime.Now.ToShortDateString() + "' and ag_situacao like 'Em andamento'";
            int QTDandamento = int.Parse(view_DetalhesAgendamentosBindingSource.Count.ToString());
            view_DetalhesAgendamentosBindingSource.RemoveFilter();//retirou o filtro anterior
            view_DetalhesAgendamentosBindingSource.Filter = "ag_data = '" + DateTime.Now.ToShortDateString() + "' and ag_situacao like 'Agendado'";
            int QTDagendado = int.Parse(view_DetalhesAgendamentosBindingSource.Count.ToString());
            lblandamento.Text = QTDandamento.ToString();
            lblagendamento.Text = QTDagendado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDetalhesAgendamentos Detalhes = new frmDetalhesAgendamentos(); //cria a instância(copia)
            Detalhes.TopLevel = false;
            Detalhes.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();//limpa o painel, retira os objetos dele
            panelCentral.Controls.Add(Detalhes);//Adiciona o form no painel
            Detalhes.Show();
            panelSelecao.Top = btnRaca.Top;
        }
    }
}
