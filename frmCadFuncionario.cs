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
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Close();
        }

        private void txtCadNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCadCargo.Enabled = true;
                txtCadCargo.Focus();
            }
        }

        private void txtCadCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            mkdCadDataNasc.Enabled = true;
            mkdCadDataNasc.Focus();
        }

        private void mkdCadDataNasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCadEmail.Enabled = true;
                txtCadEmail.Focus();
            }
        }

        private void txtCadEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCadSenha.Enabled = true;
                txtCadSenha.Focus();

            }
        }

        private void txtCadSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbCadNivel.Enabled = true;
                cmbCadNivel.Focus();
            }
        }

        private void cmbCadNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdCadDataAdmissao.Enabled = true;
                mkdCadDataAdmissao.Focus();
            }
        }

        private void mkdCadDataAdmissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCadEndereco.Enabled = true;
                txtCadEndereco.Focus();
            }
        }

        private void txtCadEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdCadCep.Enabled = true;
                mkdCadCep.Focus();
            }
        }

        private void mkdCadCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdCadTelefone.Enabled = true;
                mkdCadTelefone.Focus();
            }
        }

        private void mkdCadTelefone_KeyPress(object sender, KeyPressEventArgs e)
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
                txtCadFacebook.Enabled = true;
                txtCadFacebook.Focus();
            }
        }

        private void txtCadFacebook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCadInstagran.Enabled = true;
                txtCadInstagran.Focus();
            }
        }

        private void txtCadInstagran_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCadWhatsap.Enabled = true;
                txtCadWhatsap.Focus();
            }
        }

        private void txtCadWhatsap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                pctCadFoto.Enabled = true;
                pctCadFoto.Focus();
            }
        }
    }
}
