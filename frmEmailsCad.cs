using System;
using System.Drawing;
using System.Windows.Forms;

namespace Adega_Irmandade
{
    public partial class frmEmailsCad : Form
    {
        public frmEmailsCad()
        {
            InitializeComponent();

           
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmEmails().Show();
            Close();
        }

       

        private void frmEmailsCad_Load(object sender, EventArgs e)
        {

        }

        private void txtCadNome_KeyPress(object sender, KeyPressEventArgs e)
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
                mkdCadTelefone.Enabled = true;
                mkdCadTelefone.Focus();
            }
        }

        private void mkdCadTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCadMensagem.Enabled = true;
                txtCadMensagem.Focus();
            }
        }

        private void txtCadMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdCadDataContato.Enabled = true;
                mkdCadDataContato.Focus();
            }
        }

        private void mkdCadDataContato_KeyPress(object sender, KeyPressEventArgs e)
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
                mkdCadHora.Enabled = true;
                mkdCadHora.Focus();
            }
        }

        private void mkdCadHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCadSalvar.Enabled = true;
                btnCadSalvar.Focus();
            }
        }



        private void btnCadSalvar_Click(object sender, EventArgs e)
        {
            lblCadNome.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadEmail.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadTelefone.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadMensagem.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadDataContato.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadStatus.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadHora.ForeColor = Color.FromArgb(0, 0, 255);
        }

      
    }
}
