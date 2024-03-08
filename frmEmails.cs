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
    public partial class frmEmails : Form
    {
        public frmEmails()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmEmails_Load(object sender, EventArgs e)
        {
            banco.dgEmails = dgvEmails;
            banco.CarregarEmails();
        }

        private void dgvEmails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

                if (e.Value != null && dgvEmails.Columns[e.ColumnIndex].HeaderText != null)
                {
                    // Converte o valor da célula para maiúsculas e define o valor formatado
                    e.Value = e.Value.ToString().ToUpper();
                    e.FormattingApplied = true; // Indica que a formatação foi aplicada
                }



            }
        }
    }
}