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

        }
    }
}
