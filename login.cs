using System;
using System.Drawing;
using System.Windows.Forms;

namespace Adega_Irmandade
{
    public partial class frmLogin : Form
    {

        int mostrar = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Encerrar ?", "Encerrar", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pctFechar_MouseEnter(object sender, EventArgs e)
        {
            pctFechar.Size = new Size(30, 30);
            pctFechar.Location = new Point(948, 12);
        }

        private void pctFechar_MouseLeave(object sender, EventArgs e)
        {
            pctFechar.Size = new Size(34, 34);
            pctFechar.Location = new Point(950, 12);
        }

        private void pctMostrar_Click(object sender, EventArgs e)
        {
            if (mostrar == 0)
            {
                txtSenha.PasswordChar = '\0';
                pctMostrar.Image = Properties.Resources.Esconder;
                mostrar = 1;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                pctMostrar.Image = Properties.Resources.Mostrar;
                mostrar = 0;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            variaveis.usuario = txtEmail.Text;
            new frmMenuPrincipal().Show();
            Hide();
        }

   
    }
}
