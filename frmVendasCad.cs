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
    public partial class frmVendasCad : Form
    {
        public frmVendasCad()
        {
            InitializeComponent();
        }





        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmVendas().Show();
            Close();
        }

        private void cmbCadFuncionario_KeyPress(object sender, KeyPressEventArgs e)
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
                nudValorVenda.Enabled = true;
                nudValorVenda.Focus();
            }
        }

        private void nudValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbCadVendasProdutos.Enabled = true;
                cmbCadVendasProdutos.Focus();
            }
        }

        private void cmbCadVendasProdutos_KeyPress(object sender, KeyPressEventArgs e)
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
            lblCadStatus.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadValorVenda.ForeColor = Color.FromArgb(0, 0, 255);
            lblCadVendaProdutos.ForeColor = Color.FromArgb(0, 0, 255);


             if (string.IsNullOrWhiteSpace(cmbCadFuncionario.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Nivel ");
                cmbCadFuncionario.SelectedIndex = -1;
                cmbCadFuncionario.Focus();
                lblCadNome.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(cmbCadStatus.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Status ");
                cmbCadStatus.SelectedIndex = -1;
                cmbCadStatus.Focus();
                lblCadStatus.ForeColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(nudValorVenda.Value.ToString())) // Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher a Quantidade ");
                nudValorVenda.Value = 0; // Limpa definindo o valor para zero
                nudValorVenda.Focus();
                lblCadValorVenda.ForeColor = Color.Red;
            }
            if (string.IsNullOrWhiteSpace(cmbCadVendasProdutos.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Nivel ");
                cmbCadVendasProdutos.SelectedIndex = -1;
                cmbCadVendasProdutos.Focus();
                lblCadVendaProdutos.ForeColor = Color.Red;
            }
            else
            {
                variaveis.nomeFuncionario = cmbCadFuncionario.Text;
                variaveis.statusVenda = cmbCadStatus.Text;
                variaveis.valorTotalVenda = nudValorVenda.Text;
                variaveis.statusEstoque = cmbCadStatus.Text;
                variaveis.idProduto = cmbCadVendasProdutos.Text;

                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirVendas();
                    btnCadSalvar.Enabled = false;
                    btnLimpar.PerformClick();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarVendas();
                    banco.CarregarDadosVendas();

                }
                btnLimpar.Enabled = false;
            }



        }

        private void frmVendasCad_Load(object sender, EventArgs e)
        {

            if (variaveis.funcao == "ALTERAR")
            {
                lblCadCadastrar.Text = "ALTERAR";
                banco.CarregarDadosVendas();


                cmbCadFuncionario.Text = variaveis.nomeFuncionario;                            
                cmbCadStatus.Text = variaveis.statusVenda;
                cmbCadVendasProdutos.Text = variaveis.nomeProduto;
                btnCadSalvar.Enabled = true;
                btnLimpar.Enabled = false;





            }
        }
    }
    
}

       
