﻿using System;
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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            banco.dgClientes = dgvCliente;
            banco.CarregarCliente();
        }

        private void txtClienteNome_TextChanged(object sender, EventArgs e)
        {

            variaveis.nomeUsuario = txtClienteNome.Text;
            banco.CarregarClienteNome();

            if (txtClienteNome.Text == "")
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
                banco.CarregarStatusCliente();
                txtClienteNome.Enabled = false;
            }
            else
            {
                banco.CarregarCliente();
                txtClienteNome.Enabled = true;
            }
        }

        private void dgvCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
                if (e.Value != null && e.ColumnIndex >= 0 && dgvCliente.Columns[e.ColumnIndex].HeaderText != null)
                {
                    // Verifica se a coluna não é uma coluna de data
                    if (dgvCliente.Columns[e.ColumnIndex].ValueType != typeof(DateTime))
                    {
                        // Converte o valor da célula para maiúsculas e define o valor formatado
                        e.Value = e.Value.ToString().ToUpper();
                        e.FormattingApplied = true; // Indica que a formatação foi aplicada
                    }
                }


            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = e.RowIndex;
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codUsuario = Convert.ToInt32(dgvCliente[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvCliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCliente.Sort(dgvCliente.Columns[1], ListSortDirection.Ascending);
            dgvCliente.ClearSelection();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frmClienteCad().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.funcao = "ALTERAR";
                variaveis.codUsuario = Convert.ToInt32(dgvCliente.Rows[variaveis.linhaSelecionada].Cells["idUsuario"].Value);

                // Abrir o formulário de cadastro de clientes
                new frmClienteCad().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja realmente excluir?, Essa ação não poderá ser desfeita.", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    banco.DesativarCliente();
                    banco.CarregarCliente();
                    dgvCliente.ClearSelection();
                }
                else
                {
                    dgvCliente.ClearSelection();
                }

            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}