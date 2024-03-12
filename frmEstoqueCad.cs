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
    public partial class frmEstoqueCad : Form
    {
        public frmEstoqueCad()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmEstoque().Show();
            Close();
        }

        private void txtCadNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                nudQuantidade.Enabled = true;
                nudQuantidade.Focus();
            }
        }

        private void nudQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdCadDataCadastro.Enabled = true;
                mkdCadDataCadastro.Focus();
            }
        }

        private void mkdCadDataCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mkdCadDataAtual.Enabled = true;
                mkdCadDataAtual.Focus();
            }
        }

        private void mkdCadDataAtual_KeyPress(object sender, KeyPressEventArgs e)
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
                cmbCadProduto.Enabled = true;
                cmbCadProduto.Focus();
            }
        }

        private void cmbCadProduto_KeyPress(object sender, KeyPressEventArgs e)
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
            lblCadQuantidade.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadDataCadastro.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadDataAtual.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadStatus.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadhora.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadProdutos.ForeColor = Color.FromArgb(0, 0, 255);

            if (txtCadNome.Text.Length <= 5) // Não aceita menos que 6 caracteres 
            {
                MessageBox.Show("Favor Preencher o Nome Completo");
                txtCadNome.Clear();
                txtCadNome.Focus();
                lblCadNome.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(nudQuantidade.Value.ToString())) // Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher a Quantidade ");
                nudQuantidade.Value = 0; // Limpa definindo o valor para zero
                nudQuantidade.Focus();
                lblCadQuantidade.ForeColor = Color.Red;
            }
            else if (!mkdCadDataCadastro.MaskCompleted)// // Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Colocar o Data Completa ");
                mkdCadDataCadastro.Clear();
                mkdCadDataCadastro.Focus();
                lblCadDataCadastro.ForeColor = Color.Red;
            }
            else if (!mkdCadDataAtual.MaskCompleted)// // Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Colocar o Data Completa ");
                mkdCadDataAtual.Clear();
                mkdCadDataAtual.Focus();
                lblCadDataAtual.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(cmbCadStatus.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Status ");
                cmbCadStatus.SelectedIndex = -1;
                cmbCadStatus.Focus();
                lblCadStatus.ForeColor = Color.Red;
            }
            else if (!mkdCadHora.MaskCompleted)// // Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Colocar a Hora Completa ");
                mkdCadHora.Clear();
                mkdCadHora.Focus();
                lblCadhora.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(cmbCadProduto.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Produto ");
                cmbCadProduto.SelectedIndex = -1;
                cmbCadProduto.Focus();
                lblCadProdutos.ForeColor = Color.Red;
            }



            else
            {
                variaveis.nomeEstoque = txtCadNome.Text;
                variaveis.quantidadeEstoque = nudQuantidade.Text;
                variaveis.dataCadastroEstoque = DateTime.Parse(mkdCadDataCadastro.Text);
                variaveis.dataAtualiEstoque = DateTime.Parse(mkdCadDataAtual.Text);
                variaveis.statusEstoque = cmbCadStatus.Text;
                variaveis.horaEstoque = DateTime.Parse(mkdCadHora.Text);
                variaveis.idProduto = cmbCadProduto.Text;

                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirEstoque();
                    btnCadSalvar.Enabled = false;
                    btnLimpar.PerformClick();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarEstoque();
                    banco.CarregarDadosEstoque();

                }
                btnLimpar.Enabled = false;
            }




        }

        private void frmEstoqueCad_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "ALTERAR")
            {
                lblCadCadastrar.Text = "ALTERAR";
                banco.CarregarDadosEstoque();

                txtCadNome.Text = variaveis.nomeEstoque;
                nudQuantidade.Text = variaveis.quantidadeEstoque;
                mkdCadDataCadastro.Text = variaveis.dataCadastroEstoque.ToString();
                mkdCadDataAtual.Text = variaveis.dataAtualiEstoque.ToString();
                cmbCadStatus.Text = variaveis.statusEstoque;
                mkdCadHora.Text = variaveis.horaEstoque.ToString();
                cmbCadProduto.Text = variaveis.idProduto;

                txtCadNome.Enabled = true;
                nudQuantidade.Enabled = true;
                mkdCadDataCadastro.Enabled = true;
                mkdCadDataAtual.Enabled = true;
                cmbCadStatus.Enabled = true;
                mkdCadHora.Enabled = true;
                cmbCadProduto.Enabled = true;
                btnCadSalvar.Enabled = true;
                btnLimpar.Enabled = false;
            }
        }
    }
}
