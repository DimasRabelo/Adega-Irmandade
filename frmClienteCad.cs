using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adega_Irmandade
{
    public partial class frmClienteCad : Form
    {
        public frmClienteCad()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
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
                txtCadSenha.Enabled = true;
                txtCadSenha.Focus();
            }
        }

        private void txtCadSenha_KeyPress(object sender, KeyPressEventArgs e)
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
                pctCadFoto.Enabled = true;
                pctCadFoto.Focus();
            }
        }

        private void btnCadFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdFoto = new OpenFileDialog();
                ofdFoto.Multiselect = false;
                ofdFoto.FileName = "";
                ofdFoto.InitialDirectory = @"C:";
                ofdFoto.Title = "SELECIONE UMA FOTO";
                ofdFoto.Filter = "JPG ou PNG (*.jpg ou .png)|*.jpg;*.png";
                ofdFoto.CheckPathExists = true; //checar se o caminho existe
                ofdFoto.CheckFileExists = true; //checar se o arquivo existe
                ofdFoto.RestoreDirectory = true;//Restaurar ao diretório inicial

                DialogResult dr = ofdFoto.ShowDialog();
                pctCadFoto.Image = Image.FromFile(ofdFoto.FileName); //colocar a foto na picturebox
                variaveis.fotoUsuario = "Usuario/" + Regex.Replace(txtCadNome.Text, @"\s", "").ToLower() +
                     Regex.Replace(txtCadEmail.Text, @"\s", "").ToLower() + ".png";

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        variaveis.atFotoUsuario = "S";
                        variaveis.caminhoFotoUsuario = ofdFoto.FileName;
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("Erro de segurança - fale com o admin.\n Mensagem:" + ex.Message + "\n Detalhe: " + ex.StackTrace);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Você não permissão \n Mensagem: " + ex.Message);
                    }
                }
                btnCadSalvar.Enabled = true;
                btnCadSalvar.Focus();
            }
            catch
            {
                btnCadSalvar.Enabled = true;
                btnCadSalvar.Focus();
            }
        }

        private void btnCadSalvar_Click(object sender, EventArgs e)
        {
            lblCadNome.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadEmail.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadSenha.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadStatus.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadFoto.ForeColor = Color.FromArgb(0, 0, 255);

            if (txtCadNome.Text.Length <= 5) // Não aceita menos que 6 caracteres 
            {
                MessageBox.Show("Favor Preencher o Nome Completo");
                txtCadNome.Clear();
                txtCadNome.Focus();
                lblCadNome.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtCadEmail.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor preencher o Email ");
                txtCadEmail.Clear();
                txtCadEmail.Focus();
                lblCadEmail.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtCadSenha.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor digitar a Senha ");
                txtCadSenha.Clear();
                txtCadSenha.Focus();
                lblCadSenha.ForeColor = Color.Red;
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
                variaveis.nomeUsuario = txtCadNome.Text;
                variaveis.emailUsuario = txtCadEmail.Text;
                variaveis.senhaUsuario = txtCadSenha.Text;
                variaveis.statusUsuario = cmbCadStatus.Text;

                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirCliente();
                    btnCadSalvar.Enabled = false;
                    btnLimpar.PerformClick();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarCliente();
                    if (variaveis.atFotoUsuario == "S")
                    {
                        banco.AlterarFotoCliente();
                    }
                }
                btnLimpar.Enabled = false;
            }
        }







        private void pctCadFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdFoto = new OpenFileDialog();
                ofdFoto.Multiselect = false;
                ofdFoto.FileName = "";
                ofdFoto.InitialDirectory = @"C:";
                ofdFoto.Title = "SELECIONE UMA FOTO";
                ofdFoto.Filter = "JPG OU PNG (*.jpg ou *.png)|*.jpg;*.png";
                ofdFoto.CheckPathExists = true; // Checar se o caminho Existe
                ofdFoto.CheckFileExists = true; // Checar se o arquivo Existe
                ofdFoto.RestoreDirectory = true;  // Restaurar ao Diretorio Inicial

                DialogResult dr = ofdFoto.ShowDialog();

                // Verificar se o usuário selecionou um arquivo e se a operação foi confirmada
                if (dr == DialogResult.OK)
                {
                    pctCadFoto.Image = Image.FromFile(ofdFoto.FileName); // Colocar a foto na picture box
                    variaveis.fotoUsuario = "Usuario/" + Regex.Replace(txtCadNome.Text, @"\s", "").ToLower() + ".png";

                    try
                    {
                        variaveis.atFotoUsuario = "S";
                        variaveis.caminhoFotoUsuario = ofdFoto.FileName;
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("Erro de Segurança - Fale com o Admin. \n Mensagem: " + ex.Message + "\n Detalhe: " + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Você Não tem Permissão. \n Mensagem: " + ex.Message);
                    }

                    // Ativar o botão de salvar após selecionar a foto
                    btnCadSalvar.Enabled = true;
                    btnCadSalvar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a foto: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtCadNome.Text = "";
            txtCadEmail.Text = "";
            txtCadSenha.Text = "";
            txtCadEmail.Text = "";
            txtCadSenha.Text = "";
            cmbCadStatus.SelectedIndex = -1;
            pctCadFoto.Image = null;
        }

        private void frmClienteCad_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "ALTERAR")
            {
                lblCadCadastrar.Text = "ALTERAR";
                banco.CarregarDadosCliente();

                txtCadNome.Text = variaveis.nomeUsuario;
                txtCadEmail.Text = variaveis.emailUsuario;
                txtCadSenha.Text = variaveis.senhaUsuario;
                cmbCadStatus.Text = variaveis.statusUsuario;
                pctCadFoto.Image = banco.ByteToImage(banco.GetImgToByte(variaveis.enderecoServidorFtp + "Usuario/" + variaveis.fotoUsuario));

                txtCadNome.Enabled = true;
                txtCadEmail.Enabled = true;
                txtCadSenha.Enabled = true;
                cmbCadStatus.Enabled = true;
                btnCadSalvar.Enabled = true;
                btnLimpar.Enabled = false;
            }
        }

     
    }
}

    

