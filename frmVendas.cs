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
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            banco.dgVendas = dgvVendas;
            banco.CarregarTblVenda(); 

        }

        private void txtVendaNome_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeFuncionario = txtVendaNome.Text;
            banco.CarregarVendasNome();

            if (txtVendaNome.Text == "")
            {
                chkAtivo.Visible = true;

            }
            else
            {
                chkAtivo.Visible = false;
            }
        }
    }
}
