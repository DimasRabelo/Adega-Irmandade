using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Adega_Irmandade
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        

       

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            banco.dgFuncionario = dgvFuncionario;
            banco.CarregarFuncionario();
           


        }

        private void dgvFuncionario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
            }
        }

        private void txtCadNome_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeFuncionario = txtCadNome.Text;
            banco.CarregarFuncionarioNome();

            if (txtCadNome.Text == "")
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
                banco.CarregarStatusFuncionario();
                txtCadNome.Enabled = false;
            }
            else
            {
                banco.CarregarFuncionario();
                txtCadNome.Enabled = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frmCadFuncionario().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new frmCadFuncionario().Show();
            Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja realmente excluir?, Essa ação não poderá ser desfeita.", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    banco.DesativarFuncionario();
                    banco.CarregarFuncionario();
                    dgvFuncionario.ClearSelection();
                }
                else
                {
                    dgvFuncionario.ClearSelection();
                }

            }
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = e.RowIndex;
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codFuncionario = Convert.ToInt32(dgvFuncionario[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvFuncionario_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvFuncionario.Sort(dgvFuncionario.Columns[1], ListSortDirection.Ascending);
            dgvFuncionario.ClearSelection();
        }
    }
}
