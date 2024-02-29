using MySql.Data.MySqlClient; // Adicionando a diretiva using para o namespace MySql.Data.MySqlClient
using System;
using System.Data;
using System.Windows.Forms;

namespace Adega_Irmandade
{
    public static class banco
    {
        public static DataGridView dgProdutos, dgContato,dgFuncionario;
      

        // Remova a declaração da variável reader, pois não é usada e está causando confusão
        // private static object reader;

        public static void CarregarVendas()
        {
            try
            {
                conexao.Conectar(); // Certifique-se de que conexao está corretamente inicializado e acessível
                string selecionar = "SELECT * FROM vw_produtos_vendidos";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgProdutos.DataSource = dt;
                dgProdutos.Columns[1].DefaultCellStyle.Format = "C2";

                dgProdutos.ClearSelection();

                // Renomear a coluna "nomeProduto" para "Produto" no DataGridView
                dgProdutos.Columns["nomeProduto"].HeaderText = "PRODUTOS";
                dgProdutos.Columns["precoVendaProduto"].HeaderText = "PREÇO UNITÁRIO";
                dgProdutos.Columns["precoVendaProduto"].DefaultCellStyle.Format = "c"; // Formato de moeda
                dgProdutos.Columns["total_vendido"].HeaderText = "VALOR TOTAL";
                dgProdutos.Columns["total_vendido"].DefaultCellStyle.Format = "c"; // Formato de moeda
                dgProdutos.Columns["Unidades"].HeaderText = "UNIDADES ";
               


                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os itens vendidos!\n\n" + erro);
            }
        }

        public static void CarregarNumFuncionario()
        {
            try
            {
                conexao.Conectar(); // Certifique-se de que conexao está corretamente inicializado e acessível
                string selecionar = "SELECT * FROM vw_qtdfuncionarios";

                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    variaveis.qtdFuncionarios = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar Quantidade de Funcionários!\n\n" + erro);
            }
        }

        public static void CarregarNumProdutos()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT COUNT(*) AS qtdProdutos FROM vwprodutos";

                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    variaveis.qtdProdutos= reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar Quantidade de Produtos!\n\n" + erro);
            }
        }
        public static void CarregarNumVendas()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT COUNT(*) AS qtdVendas FROM vw_vendas_info";

                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    variaveis.qtdVendas = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar Quantidade de Vendas!\n\n" + erro);
            }
        }
        public static void CarregarNumEmails()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT COUNT(*) AS qtdEmails FROM tblcontato";

                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    variaveis.qtdEmails = reader.GetInt32(0);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar Quantidade de Emails!\n\n" + erro);
            }
        }

        public static void CarregarContato()
        {
            try
            {
                conexao.Conectar();
                string selecionar = " SELECT * FROM tblcontato;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgContato.DataSource = dt;

                dgContato.Columns[0].Visible = false;
                dgContato.Columns[1].HeaderText = "Nome";
                dgContato.Columns[2].HeaderText = "E-mail";
                dgContato.Columns[3].HeaderText = "Telefone";
                dgContato.Columns[4].HeaderText = "Mensagem";
                dgContato.Columns[5].Visible = false;
                dgContato.Columns[6].Visible = false;
                dgContato.Columns[7].Visible = false;


                dgContato.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Emails!\n\n" + erro);
            }
        }
        public static void AlterarStatusEmail()
        {
            try
            {
                conexao.Conectar();
                string selecionar = " UPDATE tblcontato SET statusContato= 'RESPONDIDO' WHERE idContato=" + variaveis.codContato;
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgContato.DataSource = dt;
               

               


                dgContato.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar Status do Emails!\n\n" + erro);
            }
        }


        public static void CarregarFuncionario()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionarios";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgFuncionario.DataSource = dt;

                dgFuncionario.Columns[0].Visible = false;
                dgFuncionario.Columns[1].HeaderText = "NOME";
                dgFuncionario.Columns[2].Visible = false;
                dgFuncionario.Columns[3].HeaderText = "CARGO"; 
                dgFuncionario.Columns[4].HeaderText = "DATA DE NASCIMENTO";
                dgFuncionario.Columns[5].HeaderText = "E-MAIL";
                dgFuncionario.Columns[6].Visible = false;
                dgFuncionario.Columns[7].HeaderText = "NIVEL";
                dgFuncionario.Columns[8].HeaderText = "DATA DE ADMISSÃO";
                dgFuncionario.Columns[9].HeaderText = "ENDEREÇO";
                dgFuncionario.Columns[10].HeaderText = "TELEFONE";
                dgFuncionario.Columns[11].HeaderText = "CEP";
                dgFuncionario.Columns[12].HeaderText = "STATUS";
                dgFuncionario.Columns[13].HeaderText = "FOTO";
                dgFuncionario.Columns[14].Visible = false;
                dgFuncionario.Columns[15].Visible = false;
                dgFuncionario.Columns[16].Visible = false;


                dgFuncionario.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Funcionários!\n\n" + erro);
            }
        }






    }
}
    

