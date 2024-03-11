using System;
using System.Drawing;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel;

namespace Adega_Irmandade
{
    public partial class frmFuncionarioCad : Form
    {
        public frmFuncionarioCad()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Close();
        }

        private void txtCadNome_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCadCargo.Enabled = true;
                txtCadCargo.Focus();
            }
        }

        private void txtCadCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdCadDataNasc.Enabled = true;
                mkdCadDataNasc.Focus();
            }
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
                txtCadWhatsapp.Enabled = true;
                txtCadWhatsapp.Focus();
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
                variaveis.fotoFuncionario = "funcionario/" + Regex.Replace(txtCadNome.Text, @"\s", "").ToLower() +
                     Regex.Replace(txtCadCargo.Text, @"\s", "").ToLower() + ".png";

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        variaveis.atFotoFuncionario = "S";
                        variaveis.caminhoFotoFuncionario = ofdFoto.FileName;
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
            lblCadCargo.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadDataNasc.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadEmail.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadSenha.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadNivel.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadDataAdmissao.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadEndereco.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadCep.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadTelefone.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadStatus.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadFacebook.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadInstagran.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadWhatsapp.ForeColor = Color.FromArgb(0, 0, 255);


            if (txtCadNome.Text.Length <= 5) // Não aceita menos que 6 caracteres 
            {
                MessageBox.Show("Favor Preencher o Nome Completo");
                txtCadNome.Clear();
                txtCadNome.Focus();
                lblCadNome.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtCadCargo.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher o Cargo ");
                txtCadCargo.Clear();
                txtCadCargo.Focus();
                lblCadCargo.ForeColor = Color.Red;
            }
            else if (!mkdCadDataNasc.MaskCompleted)// // Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Colocar a Data de Nascimento Completa ");
                mkdCadDataNasc.Clear();
                mkdCadDataNasc.Focus();
                lblCadDataNasc.ForeColor = Color.Red;
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
            else if (string.IsNullOrWhiteSpace(cmbCadNivel.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Nivel ");
                cmbCadNivel.SelectedIndex = -1;
                cmbCadNivel.Focus();
                lblCadNivel.ForeColor = Color.Red;
            }
            else if (!mkdCadDataAdmissao.MaskCompleted)// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor digite a Data de Admissão ");
                mkdCadDataAdmissao.Clear();
                mkdCadDataAdmissao.Focus();
                lblCadDataAdmissao.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtCadEndereco.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher o Endereço ");
                txtCadEndereco.Clear();
                txtCadEndereco.Focus();
                lblCadEndereco.ForeColor = Color.Red;
            }
            else if (!mkdCadCep.MaskCompleted)// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor digite a Data de Admissão ");
                mkdCadCep.Clear();
                mkdCadCep.Focus();
                lblCadCep.ForeColor = Color.Red;
            }
            else if (!mkdCadTelefone.MaskCompleted)// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor digite a Data de Admissão ");
                mkdCadTelefone.Clear();
                mkdCadTelefone.Focus();
                lblCadTelefone.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(cmbCadStatus.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Status ");
                cmbCadStatus.SelectedIndex = -1;
                cmbCadStatus.Focus();
                lblCadStatus.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtCadFacebook.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher o Link do Facebook");
                txtCadFacebook.Clear();
                txtCadFacebook.Focus();
                lblCadFacebook.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtCadInstagran.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher o Link do Instagram");
                txtCadInstagran.Clear();
                txtCadInstagran.Focus();
                lblCadInstagran.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtCadWhatsapp.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher o Link do WhatsApp");
                txtCadWhatsapp.Clear();
                txtCadWhatsapp.Focus();
                lblCadWhatsapp.ForeColor = Color.Red;
            }
            else
            {
                variaveis.nomeFuncionario = txtCadNome.Text;
                variaveis.altFuncionario = Regex.Replace(txtCadNome.Text, @"\s", "").ToLower();
                variaveis.dataNascFuncionario = DateTime.Parse(mkdCadDataNasc.Text);
                variaveis.cargoFuncionario = txtCadCargo.Text;
                variaveis.emailFuncionario = txtCadEmail.Text;
                variaveis.senhaFuncionario = txtCadSenha.Text;
                variaveis.nivelFuncionario = cmbCadNivel.Text;
                variaveis.dataAdmissaoFuncionario = DateTime.Parse(mkdCadDataAdmissao.Text);
                variaveis.enderecoFuncionario = txtCadEndereco.Text;
                variaveis.cepFuncionario = mkdCadCep.Text;
                variaveis.telFuncionario = mkdCadTelefone.Text;
                variaveis.statusFuncionario = cmbCadStatus.Text;
                variaveis.linkFaceFuncionario = txtCadFacebook.Text;
                variaveis.linkInstaFuncionario = txtCadInstagran.Text;
                variaveis.linkWhatsFuncionario = txtCadWhatsapp.Text;

                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirFuncionario();
                    btnCadSalvar.Enabled = false;
                    btnLimpar.PerformClick();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarFuncionario();
                    if (variaveis.atFotoFuncionario == "S")
                    {
                        banco.AlterarFotoFuncionario();
                    }
                }
                btnLimpar.Enabled = false;
            }
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "ALTERAR")
            {
                lblCadCadastrar.Text = "ALTERAR";
                banco.CarregarDadosFuncionario();

                txtCadNome.Text = variaveis.nomeFuncionario;
                txtCadCargo.Text = variaveis.cargoFuncionario;
                mkdCadDataNasc.Text = variaveis.dataNascFuncionario.ToString();
                txtCadEmail.Text = variaveis.emailFuncionario;
                txtCadSenha.Text = variaveis.senhaFuncionario;
                cmbCadNivel.Text = variaveis.nivelFuncionario;
                mkdCadDataAdmissao.Text = variaveis.dataAdmissaoFuncionario.ToString();
                txtCadEndereco.Text = variaveis.enderecoFuncionario;
                mkdCadCep.Text = variaveis.cepFuncionario;
                mkdCadTelefone.Text = variaveis.telFuncionario;
                cmbCadStatus.Text = variaveis.statusFuncionario;
                pctCadFoto.Image = banco.ByteToImage(banco.GetImgToByte(variaveis.enderecoServidorFtp + "funcionario/" + variaveis.fotoFuncionario));
                txtCadFacebook.Text = variaveis.linkFaceFuncionario;
                txtCadInstagran.Text = variaveis.linkInstaFuncionario;
                txtCadWhatsapp.Text = variaveis.linkWhatsFuncionario;




                txtCadNome.Enabled = true;
                txtCadCargo.Enabled = true;
                mkdCadDataNasc.Enabled = true;
                txtCadEmail.Enabled = true;
                txtCadSenha.Enabled = true;
                cmbCadNivel.Enabled = true;
                mkdCadDataAdmissao.Enabled = true;
                txtCadEndereco.Enabled = true;
                mkdCadCep.Enabled = true;
                mkdCadTelefone.Enabled = true;
                cmbCadStatus.Enabled = true;
                txtCadFacebook.Enabled = true;
                txtCadInstagran.Enabled = true;
                txtCadWhatsapp.Enabled = true;
                btnCadSalvar.Enabled = true;
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
                    pctCadFoto.Image = Image.FromFile(ofdFoto.FileName); // Colocar a foto na picture box
                    variaveis.fotoFuncionario = "funcionario/" + Regex.Replace(txtCadNome.Text, @"\s", "").ToLower() + ".png";

                    if (dr == DialogResult.OK)
                    {
                        try
                        {
                            variaveis.atFotoFuncionario = "S";
                            variaveis.caminhoFotoFuncionario = ofdFoto.FileName;
                        }
                        catch (SecurityException ex)
                        {
                            MessageBox.Show("Erro de Segurança - Fale com o Admin. \n Mensagem: " + ex.Message + "\n Detalhe: " + ex.StackTrace);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(" Você Não tem Permissão. \n Mensagem: " + ex.Message);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            {
                txtCadNome.Text = "";
                txtCadCargo.Text = "";
                mkdCadDataNasc.Text = "";
                txtCadEmail.Text = "";
                txtCadSenha.Text = "";
                cmbCadNivel.SelectedIndex = -1;
                mkdCadDataAdmissao.Text = "";
                txtCadEndereco.Text = "";
                mkdCadCep.Text = "";
                mkdCadTelefone.Text = "";
                cmbCadStatus.SelectedIndex = -1;
                txtCadFacebook.Text = "";
                txtCadInstagran.Text = "";
                txtCadWhatsapp.Text = "";
                pctCadFoto.Image = null;
            }
        }

       
    }

        

      
    
    }



