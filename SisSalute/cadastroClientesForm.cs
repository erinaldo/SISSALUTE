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
            //this.enderecosTableAdapter.Fill(this.sisSaluteDataSet.Enderecos);
            // TODO: This line of code loads data into the 'sisSaluteDataSet.Clientes' table. You can move, or remove it, as needed.
            //this.clientesTableAdapter.Fill(this.sisSaluteDataSet.Clientes);

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


        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            using (SisSalute_ModeloEntidadeContainer conexao = new SisSalute_ModeloEntidadeContainer())
            if (string.IsNullOrEmpty(this.nomeTextBox.Text))
            {
                MessageBox.Show("Digite o nome do cliente");
            }
            else
            {
                string nome = Convert.ToString(this.nomeTextBox.Text);
                var cliente = conexao.Clientes
                    .Where(p => p.nome == nome)
                    .FirstOrDefault();
                if (cliente == null)
                {
                    MessageBox.Show("Cliente não existe");
                    this.nomeTextBox.Text = string.Empty;
                }
                else
                {
                    conexao.Clientes.Remove(cliente);
                    conexao.SaveChanges();
                    MessageBox.Show("Cliente excluído com sucesso!");
                    this.nomeTextBox.Text = string.Empty;
                }
            }
        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.cpf = this.cpfTextBox.Text;
            cliente.telefone = this.telefoneTextBox.Text;
            cliente.celular1 = this.celular1TextBox.Text;
            cliente.celular2 = this.celular2TextBox.Text;
            cliente.email = this.emailTextBox.Text;
            cliente.facebook = this.facebookTextBox.Text;
            cliente.profissao = this.profissaoTextBox.Text;
            cliente.estadoCivil = this.estadoCivilTextBox.Text;
            cliente.sexo = this.sexoComboBox.Text;
            cliente.dataNascimento = this.dataNascimentoDateTimePicker.Value;
            cliente.dataCadastro = this.dataCadastroDateTimePicker.Value;

            cliente.nome = this.nomeTextBox.Text;

            using (SisSalute_ModeloEntidadeContainer conexao = new SisSalute_ModeloEntidadeContainer())
            {
                conexao.Clientes.Add(cliente);
                conexao.SaveChanges();
                MessageBox.Show("Cliente cadastrado");
            }
      /*      if (validaCampo())
            {
                
            
            } */

        }

     /*   private bool validaCampo()
        {
            if (string.IsNullOrEmpty(this.nomeTextBox.Text))
            {
                MessageBox.Show("O campo Nome deve ser preenchido");
                return false;
            }
        } */

    }
}
