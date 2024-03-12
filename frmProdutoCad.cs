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
    public partial class frmProdutoCad : Form
    {
        public frmProdutoCad()
        {
            InitializeComponent();
        }

       
        

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmProduto().Show();
            Close();
        }

      

        private void txtCadProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCadDescricao.Enabled = true;
                txtCadDescricao.Focus();
            }
        }

        private void txtCadDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbCadCategoria.Enabled = true;
                cmbCadCategoria.Focus();
            }
        }

        private void cmbCadCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbCadStatus.Enabled = true;
                cmbCadStatus.Focus();
            }
        }

        private void cmbCadStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCadPrecoCompra.Enabled = true;
                txtCadPrecoCompra.Focus();
            }
        }

        private void txtCadPrecoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPrecoVenda.Enabled = true;
                txtPrecoVenda.Focus();
            }
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCadFornecedor.Enabled = true;
                txtCadFornecedor.Focus();
            }
        }
        private void txtCadFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdCadDataRecebimento.Enabled = true;
                mkdCadDataRecebimento.Focus();
            }
        }

        private void mkdCadDataRecebimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdCadHoraRecebimento.Enabled = true;
                mkdCadHoraRecebimento.Focus();
            }
        }

        private void mkdCadHoraRecebimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCadSalvar.Enabled = true;
                btnCadSalvar.Focus();
            }
        }

        private void btnCadSalvar_Click(object sender, EventArgs e)
        {
            lblCadProduto.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadDescricao.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadCategoria.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadStatus.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadPrecoCompra.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadPrecoVenda.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadFornecedor.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadHoraRecebimento.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadDataRecebimento.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadHoraRecebimento.ForeColor = Color.FromArgb(0, 0, 255);

            if (txtCadProduto.Text.Length <= 5) // Não aceita menos que 6 caracteres 
            {
                MessageBox.Show("Favor Preencher o Nome do Produto Completo");
                txtCadProduto.Clear();
                txtCadProduto.Focus();
                lblCadProduto.ForeColor = Color.Red;
            }



        }



    }
}