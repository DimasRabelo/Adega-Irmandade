﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adega_Irmandade
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            banco.dgVendas = dgvVendas;
            banco.CarregarTblVenda();

        }

        private void dgvVendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
                if (e.Value != null && e.ColumnIndex >= 0 && dgvVendas.Columns[e.ColumnIndex].HeaderText != null)
                {
                    // Verifica se a coluna não é uma coluna de data
                    if (dgvVendas.Columns[e.ColumnIndex].ValueType != typeof(DateTime))
                    {
                        // Converte o valor da célula para maiúsculas e define o valor formatado
                        e.Value = e.Value.ToString().ToUpper();
                        e.FormattingApplied = true; // Indica que a formatação foi aplicada
                    }
                }


            }
        }

        private void dgvVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = e.RowIndex;
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codFuncionario = Convert.ToInt32(dgvVendas[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvVendas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvVendas.Sort(dgvVendas.Columns[1], ListSortDirection.Ascending);
            dgvVendas.ClearSelection();
        }

      

        private void txtVendaNome_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeFuncionario = txtVendaNome.Text;
            banco.CarregarVendasNome();

            if (txtVendaNome.Text == "")
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
                banco.CarregarStatusVendas();
                txtVendaNome.Enabled = false;
            }
            else
            {
                banco.CarregarVendas();
                txtVendaNome.Enabled = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frmVendasCad().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new frmVendasCad().Show();
            Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja realmente excluir?, Essa ação não poderá ser desfeita.", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    banco.DesativarVendas();
                    banco.CarregarVendas();
                    dgvVendas.ClearSelection();
                }
                else
                {
                    dgvVendas.ClearSelection();
                }

            }
        }
    }
}