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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

      
            private void pctFechar_Click(object sender, EventArgs e)
            {
                var resposta = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNoCancel);
                if (resposta == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (resposta == DialogResult.No)
                {
                    new frmLogin().Show();
                    Close();
                }
            }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
    }

