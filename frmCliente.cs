using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adega_Irmandade
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            banco.dgClientes = dgvCliente;
            banco.CarregarCliente();
        }
    }
}
