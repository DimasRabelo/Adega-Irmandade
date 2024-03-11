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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            banco.dgEstoque = dgvEstoque;
            banco.CarregarEstoque();
        }

       

        private void txtEstNome_TextChanged(object sender, EventArgs e)
        {

            variaveis.nomeEstoque = txtEstNome.Text;
            banco.CarregarEstoqueNome();

            if (txtEstNome.Text == "")
            {
                chkAtivo.Visible = true;

            }
            else
            {
                chkAtivo.Visible = false;
            }
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivo.Checked == true)
            {
                banco.CarregarStatusEstoque();
                txtEstNome.Enabled = false;
            }
            else
            {
                banco.CarregarEstoque();
                txtEstNome.Enabled = true;
            }
        }

        private void dgvEstoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (e.RowIndex % 2 == 1)
                {
                    e.CellStyle.BackColor = Color.FromArgb(127, 127, 127); // Cor Cinza
                    e.CellStyle.ForeColor = Color.FromArgb(0, 0, 0); // Cor Preta

                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(0, 0, 0); // Cor Preta
                    e.CellStyle.BackColor = Color.FromArgb(127, 127, 127); // Cor Cinza
                }
                if (e.Value != null && e.ColumnIndex >= 0 && dgvEstoque.Columns[e.ColumnIndex].HeaderText != null)
                {
                    // Verifica se a coluna não é uma coluna de data
                    if (dgvEstoque.Columns[e.ColumnIndex].ValueType != typeof(DateTime))
                    {
                        // Converte o valor da célula para maiúsculas e define o valor formatado
                        e.Value = e.Value.ToString().ToUpper();
                        e.FormattingApplied = true; // Indica que a formatação foi aplicada
                    }
                }

            }
            }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = e.RowIndex;
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codEstoque = Convert.ToInt32(dgvEstoque[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmEstoqueCad().Show();
            Hide();
        }
    }
}
