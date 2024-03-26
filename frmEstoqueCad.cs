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
                txtQuantidade.Enabled = true;
                txtQuantidade.Focus();
            }
        }


        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
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

            lblCadStatus.ForeColor = Color.FromArgb(0, 0, 255);

            lblCadProdutos.ForeColor = Color.FromArgb(0, 0, 255);
            if (txtCadNome.Text.Length <= 5) // Não aceita menos que 6 caracteres 
            {
                MessageBox.Show("Favor Preencher o Nome Completo");
                txtCadNome.Clear();
                txtCadNome.Focus();
                lblCadNome.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtQuantidade.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher o Cargo ");
                txtQuantidade.Clear();
                txtQuantidade.Focus();
                lblCadQuantidade.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(cmbCadStatus.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Nivel ");
                cmbCadStatus.SelectedIndex = -1;
                cmbCadStatus.Focus();
                lblCadStatus.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(cmbCadProduto.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Nivel ");
                cmbCadProduto.SelectedIndex = -1;
                cmbCadProduto.Focus();
                lblCadProdutos.ForeColor = Color.Red;
            }



        }

        private void frmEstoqueCad_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "ALTERAR")
            {
                lblCadCadastrar.Text = "ALTERAR";
                banco.CarregarDadosEstoque();

                txtCadNome.Text = variaveis.nomeEstoque;

                // Convertendo a quantidade de estoque para string antes de atribuir ao TextBox
                txtQuantidade.Text = variaveis.quantidadeEstoque.ToString();

                cmbCadStatus.Text = variaveis.statusEstoque;
                cmbCadProduto.Text = variaveis.nomeProduto;

                txtCadNome.Enabled = true;
                txtQuantidade.Enabled = true;
                cmbCadStatus.Enabled = true;
                cmbCadProduto.Enabled = true;
                btnCadSalvar.Enabled = true;
                btnLimpar.Enabled = false;
            }
        }
    }
  }
