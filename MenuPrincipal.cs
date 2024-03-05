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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            lblUsuario.Text = variaveis.usuario;
            lblData.Text = DateTime.Now.ToShortDateString();
            time1.Start();
        }

        private void time1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }



        private void pctFechar_Click(object sender, EventArgs e)
            {
                var resposta = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNoCancel);
                if (resposta == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (resposta == DialogResult.No)
                {
                    new frmLogin().Show();
                    Close();
                }
            }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            banco.dgProdutos = dgvProdutosMaisVendidos;
            banco.CarregarVendas();
            banco.CarregarNumFuncionario();
            lblNumFuncionario.Text = variaveis.qtdFuncionarios.ToString();
            banco.CarregarNumProdutos();
            lblNumProdutos.Text = variaveis.qtdProdutos.ToString();
            banco.CarregarNumVendas();
            lblNumVendas.Text = variaveis.qtdVendas.ToString();
            banco.CarregarNumEmails();
            lblNumEmails.Text = variaveis.qtdEmails.ToString();
            banco.dgContato = dgvContato;
            banco.CarregarContato();
           


        }

        private void dgvProdutosMaisVendidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
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

        private void dgvContato_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var resposta = MessageBox.Show("O E-MAIL FOI RESPONDIDO", "EMAIL", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                // Saber qual linha foi selecionada 
                variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
                if(variaveis.linhaSelecionada >= 0)
                {
                    variaveis.codContato = Convert.ToInt32(dgvContato[0, variaveis.linhaSelecionada].Value);
                    banco.AlterarStatusEmail();
                    banco.dgContato = dgvContato;
                    banco.CarregarContato();


                }

            }
        }

        private void dgvContato_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Hide();
        }

        private void pnlMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

