using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adega_Irmandade
{
    public static class banco
    {
        public static DataGridView dgProdutos;

       
        public static void CarregarVendas()
        {
            try
            {
                conexao.Conectar();
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







    }
}