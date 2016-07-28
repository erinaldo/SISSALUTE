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
    public partial class inicialForm : Form
    {
        private Form _formulario;
        public inicialForm()
        {
            InitializeComponent();
        }

        private void inicialForm_Load(object sender, EventArgs e)
        {

        }

        private void painelMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuPrincipalCadastroClientes_Click_1(object sender, EventArgs e)
        {


            if (Application.OpenForms.OfType<cadastroClientesForm>().Count() > 0)
            {

                MessageBox.Show("Tela já aberta! Selecione outra opção...");
                
            }
            else
            {
                _formulario = new cadastroClientesForm
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill
                    };

                painelPrincipal.Controls.Add(_formulario);
                _formulario.Show();
            }
        }

        private void menuPrincipalFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void painelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
