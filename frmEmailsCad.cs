using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
                cmbCadStatus.Enabled = true;
                cmbCadStatus.Focus();
            }
        }
        private void cmbCadStatus_KeyPress(object sender, KeyPressEventArgs e)
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
            lblCadStatus.ForeColor = Color.FromArgb(0, 0, 255);
           


            if (txtCadNome.Text.Length <= 5) // Não aceita menos que 6 caracteres 
            {
                MessageBox.Show("Favor Preencher o Nome Completo");
                txtCadNome.Clear();
                txtCadNome.Focus();
                lblCadNome.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtCadEmail.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher o Email ");
                txtCadEmail.Clear();
                txtCadEmail.Focus();
                lblCadEmail.ForeColor = Color.Red;
            }
            else if (!mkdCadTelefone.MaskCompleted)// // Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Colocar o Telefone Completo ");
                mkdCadTelefone.Clear();
                mkdCadTelefone.Focus();
                lblCadTelefone.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtCadMensagem.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher a Mensagem ");
                txtCadMensagem.Clear();
                txtCadMensagem.Focus();
                lblCadMensagem.ForeColor = Color.Red;
            }

           
            else if (string.IsNullOrWhiteSpace(cmbCadStatus.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Status ");
                cmbCadStatus.SelectedIndex = -1;
                cmbCadStatus.Focus();
                lblCadStatus.ForeColor = Color.Red;
            }
          
            else
            {
                variaveis.nomeContato = txtCadNome.Text;
                variaveis.emailContato = txtCadEmail.Text;
                variaveis.telefoneContato = mkdCadTelefone.Text;
                variaveis.mensagemContato = txtCadMensagem.Text;
                variaveis.statusContato = cmbCadStatus.Text;
                       

                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirEmails();
                    btnCadSalvar.Enabled = false;
                    btnLimpar.PerformClick();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarEmails();
                    banco.CarregarDadosEmails();

                }
                btnLimpar.Enabled = false;
            }
        }
         






        private void frmEmailsCad_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "ALTERAR")
            {
                lblCadCadastrar.Text = "ALTERAR";
                banco.CarregarDadosEmails();

                txtCadNome.Text = variaveis.nomeContato;
                txtCadEmail.Text = variaveis.emailContato;
                mkdCadTelefone.Text = variaveis.telefoneContato;
                txtCadMensagem.Text = variaveis.mensagemContato;
                cmbCadStatus.Text = variaveis.statusContato;
                          
                
               
               



                txtCadNome.Enabled = true;
                txtCadEmail.Enabled = true;
                mkdCadTelefone.Enabled = true;
                txtCadMensagem.Enabled = true;
              
                cmbCadStatus.Enabled = true;
               

                btnCadSalvar.Enabled = true;
                btnLimpar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCadNome.Text = "";
            txtCadEmail.Text = "";
            mkdCadTelefone.Text = "";
            txtCadMensagem.Text = "";
            cmbCadStatus.SelectedIndex = -1;
            
        }

       
    }

      
    
}
