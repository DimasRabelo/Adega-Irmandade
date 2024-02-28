using MySql.Data.MySqlClient; // Adicionando a diretiva using para o namespace MySql.Data.MySqlClient
using System;
using System.Data;
using System.Windows.Forms;

namespace Adega_Irmandade
{
    public static class banco
    {
        public static DataGridView dgProdutos;
        private static object reader;

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

                // Renomear a coluna "nomeProduto" para "Produto" no DataGridView
                dgProdutos.Columns["nomeProduto"].HeaderText = "Produto";
                dgProdutos.Columns["precoVendaProduto"].HeaderText = "Preço Unitário";
                dgProdutos.Columns["precoVendaProduto"].DefaultCellStyle.Format = "c"; // Formato de moeda
                dgProdutos.Columns["total_vendido"].HeaderText = "Soma do Valor total vendido";
                dgProdutos.Columns["total_vendido"].DefaultCellStyle.Format = "c"; // Formato de moeda
                dgProdutos.Columns["Unidades"].HeaderText = "Unidades Vendidas";

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os itens vendidos!\n\n" + erro);
            }
        }

        public static void CarregarFuncionario()
        {
            try
            {
                conexao.Conectar(); // Certifique-se de que conexao está corretamente inicializado e acessível
                string selecionar = "SELECT COUNT(*) AS qtdFuncionarios FROM tblfuncionarios WHERE statusFuncionario = 'ATIVO'";

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
    }
}
