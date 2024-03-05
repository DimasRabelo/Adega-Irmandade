using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;

namespace Adega_Irmandade
{
    public static class conexao
    {
        // string de conexao com o banco de dados
        public static string db = "SERVER=localhost;USER=root;DATABASE=adegairmandade";

        // Reconhecer a Bilbioteca do mysql
        public static MySqlConnection conn;

        // Método para conectar o Banco de Dados 
        public static void Conectar()
        {
            try
            {
                conn = new MySqlConnection(db);
                conn.Open();
            }
            catch (Exception ex) // Adicionando uma exceção para pegar o erro específico
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro");
            }
        }

        // Método para Fechar o Banco de Dados
        public static void Desconectar()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex) // Adicionando uma exceção para pegar o erro específico
            {
                MessageBox.Show("Erro ao desconectar com o banco de dados: " + ex.Message, "Erro");
            }
        }
    }
}
