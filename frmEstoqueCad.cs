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
            else if (string.IsNullOrWhiteSpace(nudQuantidade.Value.ToString())) // Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Preencher a Quantidade ");
                nudQuantidade.Value = 0; // Limpa definindo o valor para zero
                nudQuantidade.Focus();
                lblCadQuantidade.ForeColor = Color.Red;
            }
           
           
            else if (string.IsNullOrWhiteSpace(cmbCadStatus.Text))// Não Aceita Campo Vazio
            {
                MessageBox.Show("Favor Escolha o Status ");
                cmbCadStatus.SelectedIndex = -1;
                cmbCadStatus.Focus();
                lblCadStatus.ForeColor = Color.Red;
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
                variaveis.quantidadeEstoque = (int)nudQuantidade.Value;              
                variaveis.statusEstoque = cmbCadStatus.Text;
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
                // Verificar se o valor de variaveis.quantidadeEstoque está dentro dos limites do NumericUpDown
                if (variaveis.quantidadeEstoque >= nudQuantidade.Minimum && variaveis.quantidadeEstoque <= nudQuantidade.Maximum)
                {
                    nudQuantidade.Value = variaveis.quantidadeEstoque;
                }
                else
                {
                    // Se estiver fora dos limites, defina o valor padrão ou trate de outra forma
                    nudQuantidade.Value = nudQuantidade.Minimum; // Ou qualquer valor padrão desejado
                }
               
               
                cmbCadStatus.Text = variaveis.statusEstoque;
               
                cmbCadProduto.SelectedItem = variaveis.idProduto; 

                txtCadNome.Enabled = true;
                nudQuantidade.Enabled = true;              
                cmbCadStatus.Enabled = true;
                cmbCadProduto.Enabled = true;
                btnCadSalvar.Enabled = true;
                btnLimpar.Enabled = false;
            }
        }
    }
}
