using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            else if (string.IsNullOrWhiteSpace(txtCadDescricao.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher o Cargo ");
                txtCadDescricao.Clear();
                txtCadDescricao.Focus();
                lblCadDescricao.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(cmbCadCategoria.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Nivel ");
                cmbCadCategoria.SelectedIndex = -1;
                cmbCadCategoria.Focus();
                lblCadCategoria.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(cmbCadStatus.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Status ");
                cmbCadStatus.SelectedIndex = -1;
                cmbCadStatus.Focus();
                lblCadStatus.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtCadPrecoCompra.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher o Cargo ");
                txtCadPrecoCompra.Clear();
                txtCadPrecoCompra.Focus();
                lblCadPrecoCompra.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtPrecoVenda.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher o Cargo ");
                txtPrecoVenda.Clear();
                txtPrecoVenda.Focus();
                lblCadPrecoVenda.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(txtCadFornecedor.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher o Cargo ");
                txtCadFornecedor.Clear();
                txtCadFornecedor.Focus();
                lblCadFornecedor.ForeColor = Color.Red;
            }
            else if (!mkdCadDataRecebimento.MaskCompleted)// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor digite a Data de Admissão ");
                mkdCadDataRecebimento.Clear();
                mkdCadDataRecebimento.Focus();
                lblCadDataRecebimento.ForeColor = Color.Red;
            }
            else if (!mkdCadHoraRecebimento.MaskCompleted)// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor digite a Data de Admissão ");
                mkdCadHoraRecebimento.Clear();
                mkdCadHoraRecebimento.Focus();
                lblCadHoraRecebimento.ForeColor = Color.Red;
            }
            else
            {
                variaveis.nomeProduto = txtCadProduto.Text;
                variaveis.descricaoProduto = txtCadDescricao.Text;
                variaveis.categoriaProduto = cmbCadCategoria.Text;
                variaveis.statusProduto = cmbCadStatus.Text;
                variaveis.precoCompraProduto = (int)Convert.ToDecimal(txtCadPrecoCompra.Text);
                variaveis.precoVendaProduto = (int)Convert.ToDecimal(txtPrecoVenda.Text);
                variaveis.fornecedorProduto = txtCadFornecedor.Text;
                variaveis.dataReceProduto = DateTime.Parse(mkdCadDataRecebimento.Text);
                variaveis.horaProduto = DateTime.Parse(mkdCadHoraRecebimento.Text);

                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirProdutos();
                    btnCadSalvar.Enabled = false;
                    btnLimpar.PerformClick();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarProdutos();
                    banco.CarregarDadosProdutos();

                }
                btnLimpar.Enabled = false;
            }
        }

        private void frmProdutoCad_Load(object sender, EventArgs e)
        {

            if (variaveis.funcao == "ALTERAR")
            {
                lblCadCadastrar.Text = "ALTERAR";
                banco.CarregarDadosProdutos();


                txtCadProduto.Text = variaveis.nomeProduto;
                txtCadDescricao.Text = variaveis.descricaoProduto;
                cmbCadCategoria.Text = variaveis.categoriaProduto;
                cmbCadStatus.Text = variaveis.statusProduto;
                txtCadPrecoCompra.Text = variaveis.precoCompraProduto.ToString();
                txtPrecoVenda.Text = variaveis.precoVendaProduto.ToString();
                txtCadFornecedor.Text = variaveis.fornecedorProduto;
                mkdCadDataRecebimento.Text = variaveis.dataReceProduto.ToString();
                mkdCadHoraRecebimento.Text = variaveis.horaProduto.ToString();

                txtCadProduto.Enabled = true;
                txtCadDescricao.Enabled = true;
                cmbCadCategoria.Enabled = true;
                cmbCadStatus.Enabled = true;
                txtCadPrecoCompra.Enabled = true;
                txtPrecoVenda.Enabled = true;
                txtCadFornecedor.Enabled = true;
                mkdCadDataRecebimento.Enabled = true;
                mkdCadHoraRecebimento.Enabled = true;
                btnCadSalvar.Enabled = true;
                btnLimpar.Enabled = false;





            }
        }

       
    }

    
}