using MySql.Data.MySqlClient;
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
            variaveis.senha = txtSenha.Text;

            if (variaveis.usuario == "DIMAS" && variaveis.senha == "1234")
            {
                variaveis.nivel = "ADMINISTRADOR";
                new frmMenuPrincipal().Show();
                Hide();
            }
            else
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT nomeFuncionario, emailFuncionario, senhaFuncionario, nivelFuncionario FROM tblfuncionarios WHERE emailFuncionario=@email AND senhaFuncionario=@senha AND statusFuncionario=@status";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    cmd.Parameters.AddWithValue("@email", variaveis.usuario);
                    cmd.Parameters.AddWithValue("@senha", variaveis.senha);
                    cmd.Parameters.AddWithValue("@status", "ATIVO");
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        variaveis.usuario = reader.GetString(0);
                        variaveis.nivel = reader.GetString(3);
                        new frmMenuPrincipal().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("ACESSO NEGADO");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtEmail.Focus();

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro ao logar. " + err);

                }




            }


        }
    }
}
