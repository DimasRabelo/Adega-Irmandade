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
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void chkFunc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFunc.Checked)
            {
                chkAno.Checked = false; // Desmarca o outro CheckBox
                banco.dgRelatorio = dgvRelatorios;
                banco.CarregarVendasRelatorio();
            }
        }

        private void chkAno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAno.Checked)
            {
                chkFunc.Checked = false; // Desmarca o outro CheckBox
                banco.dgRelatorio = dgvRelatorios;
                banco.CarregarVendasAnual();
            }
        }

        private void dgvRelatorios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
                if (e.Value != null && e.ColumnIndex >= 0 && dgvRelatorios.Columns[e.ColumnIndex].HeaderText != null)
                {
                    // Verifica se a coluna não é uma coluna de data
                    if (dgvRelatorios.Columns[e.ColumnIndex].ValueType != typeof(DateTime))
                    {
                        // Converte o valor da célula para maiúsculas e define o valor formatado
                        e.Value = e.Value.ToString().ToUpper();
                        e.FormattingApplied = true; // Indica que a formatação foi aplicada
                    }
                }


            }
        }
    }
}