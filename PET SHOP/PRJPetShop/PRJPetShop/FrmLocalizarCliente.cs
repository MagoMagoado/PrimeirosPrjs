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
    public partial class FrmLocalizarCliente : Form
    {
        public FrmLocalizarCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void FrmLocalizarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            clienteBindingSource.Filter = "cli_nome like '" + txtNome.Text + "%'";
        }

        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                VariaveisGlobais.CodigoTroca = int.Parse(clienteDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                VariaveisGlobais.CodigoTroca = 0;
            }
            this.Dispose();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
