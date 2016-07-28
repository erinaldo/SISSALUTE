using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisSalute
{
    public partial class cadastroClientesForm : Form
    {

        public cadastroClientesForm()
        {
            InitializeComponent();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void cadastroClientesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sisSaluteDataSet.Enderecos' table. You can move, or remove it, as needed.
            this.enderecosTableAdapter.Fill(this.sisSaluteDataSet.Enderecos);
            // TODO: This line of code loads data into the 'sisSaluteDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.sisSaluteDataSet.Clientes);

        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sisSaluteDataSet);

        }

        private void telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataNascimentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
