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
    public partial class cadastroProfissionaisForm : Form
    {
        public cadastroProfissionaisForm()
        {
            InitializeComponent();
        }

        private void profissionaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profissionaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sisSaluteDataSet);

        }

        private void cadastroProfissionais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sisSaluteDataSet.Enderecos'. Você pode movê-la ou removê-la conforme necessário.
            this.enderecosTableAdapter.Fill(this.sisSaluteDataSet.Enderecos);
            // TODO: esta linha de código carrega dados na tabela 'sisSaluteDataSet.Profissionais'. Você pode movê-la ou removê-la conforme necessário.
            this.profissionaisTableAdapter.Fill(this.sisSaluteDataSet.Profissionais);

        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
