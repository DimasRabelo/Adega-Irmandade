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
            lblUsuario.Text = variaveis.usuario;
            lblData.Text = DateTime.Now.ToShortDateString();
            time1.Start();
        }

        private void time1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
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

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            banco.dgProdutos = dgvProdutosMaisVendidos;
            banco.CarregarVendas();

        }

     
    }
    }

