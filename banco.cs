using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;



namespace Adega_Irmandade
{
    public static class banco
    {
        public static DataGridView dgProdutosVendidos, dgContato, dgFuncionario, dgProdutos, dgEmails, dgEstoque,dgVendas,dgClientes,dgRelatorio;
        

        private static bool ValidarFTP()
        {
            if (string.IsNullOrEmpty(variaveis.enderecoServidorFtp) || string.IsNullOrEmpty(variaveis.usuarioFtp) || string.IsNullOrEmpty(variaveis.senhaFtp))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Converter a Imagem em byte 
        public static byte[] GetImgToByte(string caminhoArquivoFtp)
        {
            try
            {
                WebClient ftpclient = new WebClient();
                ftpclient.Credentials = new NetworkCredential(variaveis.usuarioFtp, variaveis.senhaFtp);
                byte[] imageTobyte = ftpclient.DownloadData(caminhoArquivoFtp);
                return imageTobyte;

            }
            catch
            {
                WebClient ftpclient = new WebClient();
                ftpclient.Credentials = new NetworkCredential(variaveis.usuarioFtp, variaveis.senhaFtp);
                byte[] imageToByte = ftpclient.DownloadData(variaveis.enderecoServidorFtp + @"\funcionario\fotoUser.png");
                return imageToByte;
            }
            
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream memoryStream = new MemoryStream();
            byte[] pData = blob;
            memoryStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(memoryStream, false);
            memoryStream.Dispose();
            return bm;
        }


        // Tratamento de imagem do Cliente Usuario //

        // Inicio do Relátórios //
        public static string TraduzirMes(string mesEmIngles)
        {
            switch (mesEmIngles.ToLower())
            {
                case "january":
                    return "Janeiro";
                case "february":
                    return "Fevereiro";
                case "march":
                    return "Março";
                case "april":
                    return "Abril";
                case "may":
                    return "Maio";
                case "june":
                    return "Junho";
                case "july":
                    return "Julho";
                case "august":
                    return "Agosto";
                case "september":
                    return "Setembro";
                case "october":
                    return "Outubro";
                case "november":
                    return "Novembro";
                case "december":
                    return "Dezembro";
                default:
                    return mesEmIngles;
            }
        }

        public static void CarregarVendasRelatorio()
        {
            try
            {
                conexao.Conectar(); // Certifique-se de que conexao está corretamente inicializado e acessível
                string selecionar = "SELECT * FROM vwvendaspormesanofuncionario";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Reorganize as colunas na ordem desejada
                dgRelatorio.DataSource = dt;

                dgRelatorio.ClearSelection();

                // Renomear a coluna "nomeProduto" para "Produto" no DataGridView
                dgRelatorio.Columns["nomeFuncionario"].HeaderText = "FUNCIONÁRIO";
                dgRelatorio.Columns["ValorTotalVenda"].HeaderText = "VALOR TOTAL DA VENDA";
                dgRelatorio.Columns["ValorTotalVenda"].DefaultCellStyle.Format = "c"; // Formato de moeda
                dgRelatorio.Columns["Mes"].HeaderText = "MÊS";
                dgRelatorio.Columns["Ano"].HeaderText = "ANO";

                // Traduzir os nomes dos meses
                foreach (DataGridViewRow row in dgRelatorio.Rows)
                {
                    if (row.Cells["Mes"].Value != null)
                    {
                        string mesEmIngles = row.Cells["Mes"].Value.ToString(); // Usar "Mes" em vez de "MES"
                        string mesTraduzido = TraduzirMes(mesEmIngles);
                        row.Cells["Mes"].Value = mesTraduzido;
                    }
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os itens vendidos!\n\n" + erro);
            }
        }


        public static void CarregarVendasAnual()
        {
            try
            {
                conexao.Conectar(); // Certifique-se de que conexao está corretamente inicializado e acessível
                string selecionar = "SELECT * FROM vwTotalVendasPorAno";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Reorganize as colunas na ordem desejada
                dgRelatorio.DataSource = dt;

                dgRelatorio.ClearSelection();


                dgRelatorio.Columns["ano"].HeaderText = "ANO REFERENCIA";
                dgRelatorio.Columns["total_vendas"].HeaderText = "VALOR TOTAL EM REAIS";
                dgRelatorio.Columns["total_vendas"].DefaultCellStyle.Format = "c"; // Formato de moeda

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os itens vendidos!\n\n" + erro);
            }
        }




        // Inicio do Menu Principal//

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

                dgProdutosVendidos.DataSource = dt;
                dgProdutosVendidos.Columns[1].DefaultCellStyle.Format = "C2";

                dgProdutosVendidos.ClearSelection();

                // Renomear a coluna "nomeProduto" para "Produto" no DataGridView
                dgProdutosVendidos.Columns["nomeProduto"].HeaderText = "PRODUTOS";
                dgProdutosVendidos.Columns["precoVendaProduto"].HeaderText = "PREÇO UNITÁRIO";
                dgProdutosVendidos.Columns["precoVendaProduto"].DefaultCellStyle.Format = "c"; // Formato de moeda
                dgProdutosVendidos.Columns["total_vendido"].HeaderText = "VALOR TOTAL";
                dgProdutosVendidos.Columns["total_vendido"].DefaultCellStyle.Format = "c"; // Formato de moeda
                dgProdutosVendidos.Columns["Unidades"].HeaderText = "UNIDADES ";




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
                    variaveis.qtdProdutos = reader.GetInt32(0);
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
        // Fim  Menu Principal//

        // Inicio Formulario do Funcionario //

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

        public static void CarregarFuncionarioNome()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionarios WHERE nomeFuncionario LIKE '%" + variaveis.nomeFuncionario + "%' ORDER BY nomeFuncionario;";
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
                MessageBox.Show("Erro ao carregar os Funcionario pelo nome!\n\n" + erro);
            }
        }

        public static void CarregarStatusFuncionario()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionarios WHERE statusFuncionario =  'ATIVO' ORDER BY nomeFuncionario;";
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
                MessageBox.Show("Erro ao carregar os Funcionário pelo status!\n\n" + erro);
            }
        }

        public static void InserirFuncionario()
        {
            try
            {
                conexao.Conectar();
                string inserir = "INSERT INTO tblfuncionarios (nomeFuncionario, altFuncionario, cargoFuncionario, dataNascFuncionario, emailFuncionario, senhaFuncionario, nivelFuncionario, dataAdmissaoFuncionario, enderecoFuncionario, cepFuncionario, telFuncionario, statusFuncionario, linkFaceFuncionario, linkInstaFuncionario, linkWhatsFuncionario, fotoFuncionario) VALUES (@nome, @alt, @cargo, @dataNasc, @email, @senha, @nivel, @dataAdmissao, @endereco, @cep, @telefone, @status, @facebook, @instagram, @whats, @foto)";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                // Parâmetros 
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@alt", variaveis.altFuncionario);
                cmd.Parameters.AddWithValue("@cargo", variaveis.cargoFuncionario);
                cmd.Parameters.AddWithValue("@dataNasc", variaveis.dataNascFuncionario);
                cmd.Parameters.AddWithValue("@email", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@nivel", variaveis.nivelFuncionario);
                cmd.Parameters.AddWithValue("@dataAdmissao", variaveis.dataAdmissaoFuncionario);
                cmd.Parameters.AddWithValue("@endereco", variaveis.enderecoFuncionario);
                cmd.Parameters.AddWithValue("@cep", variaveis.cepFuncionario);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telFuncionario);
                cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@facebook", variaveis.linkFaceFuncionario);
                cmd.Parameters.AddWithValue("@instagram", variaveis.linkInstaFuncionario);
                cmd.Parameters.AddWithValue("@whats", variaveis.linkWhatsFuncionario);
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoFuncionario);
                // Fim parâmetros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário Cadastrado Com Sucesso!", "CADASTRO FUNCIONÁRIO");
                conexao.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoFuncionario))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "funcionario/" + Path.GetFileName(variaveis.fotoFuncionario);
                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoFuncionario, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch
                        {
                            MessageBox.Show("Foto não Selecionada ou Existente.", "FOTO");
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar o Funcionário!\n\n" + erro.Message, "ERRO");
            }
        }
      
        public static void CarregarDadosFuncionario()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionarios WHERE idFuncionario = @codigo; ";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFuncionario);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.nomeFuncionario = reader.GetString(1);
                    variaveis.cargoFuncionario = reader.GetString(3);
                    variaveis.dataNascFuncionario = reader.GetDateTime(4);
                    variaveis.emailFuncionario = reader.GetString(5);
                    variaveis.senhaFuncionario = reader.GetString(6);
                    variaveis.nivelFuncionario = reader.GetString(7);
                    variaveis.dataAdmissaoFuncionario = reader.GetDateTime(8);
                    variaveis.enderecoFuncionario = reader.GetString(9);
                    variaveis.telFuncionario = reader.GetString(10);
                    variaveis.cepFuncionario = reader.GetString(11);
                    variaveis.statusFuncionario = reader.GetString(12);
                    variaveis.fotoFuncionario = reader.GetString(13);
                    variaveis.fotoFuncionario = variaveis.fotoFuncionario.Remove(0, 12);
                    variaveis.linkFaceFuncionario = reader.GetString(14);
                    variaveis.linkInstaFuncionario = reader.GetString(15);
                    variaveis.linkWhatsFuncionario = reader.GetString(16);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Funcionários!\n\n" + erro);
            }
        }

        public static void AlterarFuncionario()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblfuncionarios SET nomeFuncionario =@nome, altFuncionario =@alt, cargoFuncionario =@cargo, dataNascFuncionario =@dataNasc, emailFuncionario =@email, senhaFuncionario =@senha, nivelFuncionario=@nivel, dataAdmissaoFuncionario=@dataAdmissao, enderecoFuncionario=@endereco,cepFuncionario=@cep,telFuncionario=@telefone, statusFuncionario=@status,linkFaceFuncionario=@facebook, linkInstaFuncionario=@instagram, linkWhatsFuncionario=@whats WHERE idFuncionario=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parâmetros 
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@alt", variaveis.altFuncionario);
                cmd.Parameters.AddWithValue("@cargo", variaveis.cargoFuncionario);
                cmd.Parameters.AddWithValue("@dataNasc", variaveis.dataNascFuncionario);
                cmd.Parameters.AddWithValue("@email", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@nivel", variaveis.nivelFuncionario);
                cmd.Parameters.AddWithValue("@dataAdmissao", variaveis.dataAdmissaoFuncionario);
                cmd.Parameters.AddWithValue("@endereco", variaveis.enderecoFuncionario);
                cmd.Parameters.AddWithValue("@cep", variaveis.cepFuncionario);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telFuncionario);
                cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@facebook", variaveis.linkFaceFuncionario);
                cmd.Parameters.AddWithValue("@instagram", variaveis.linkInstaFuncionario);
                cmd.Parameters.AddWithValue("@whats", variaveis.linkWhatsFuncionario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFuncionario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário Alterado Com Sucesso!", "CADASTRO FUNCIONÁRIO");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar o Funcionário!\n\n" + erro.Message, "ERRO");
            }
        }


        public static void AlterarFotoFuncionario()
        {
            try
            {




                conexao.Conectar();
                string alterar = "UPDATE tblfuncionarios SET fotoFuncionario = @foto WHERE idFuncionario = @codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoFuncionario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFuncionario);
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoFuncionario))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "funcionario/" + Path.GetFileName(variaveis.fotoFuncionario);
                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoFuncionario, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Foto não Selecionada ou foto já existente no servidor.\n\n " + ex.Message, "Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }


                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar a Foto do Funcionario! \n\n" + erro.Message, "Erro");
            }
        }
      
        public static void DesativarFuncionario()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblfuncionarios SET statusFuncionario='DESATIVADO' WHERE idFuncionario = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parâmetros 

                cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFuncionario); // Correção do parâmetro
                                                                                  //fim parâmetros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário Desativado Com Sucesso!", " DESATIVADO FUNCIONÁRIO");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao desativar o Funcionário!\n\n" + erro.Message, "ERRO");
            }
        }
        // Fim do Formulário Funcionário //

        // Inicio do Formulário Produtos //

        public static void CarregarProdutos()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblprodutos";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgProdutos.DataSource = dt;

                dgProdutos.Columns[0].Visible = false;
                dgProdutos.Columns[1].HeaderText = "NOME";
                dgProdutos.Columns[2].HeaderText = "DESCRIÇÃO";
                dgProdutos.Columns[3].HeaderText = "CATEGORIA";
                dgProdutos.Columns[4].HeaderText = "STATUS";
                dgProdutos.Columns[5].HeaderText = "PREÇO DE COMPRA";
                dgProdutos.Columns["precoCompraProduto"].DefaultCellStyle.Format = "c";
                dgProdutos.Columns[6].HeaderText = "PREÇO DE VENDA";
                dgProdutos.Columns[7].HeaderText = "FORNECEDOR";
                dgProdutos.Columns[8].HeaderText = "DATA RECEBIMENTO";
                dgProdutos.Columns["dataReceProduto"].DefaultCellStyle.Format = "d";
                dgProdutos.Columns[9].HeaderText = "HORA RECEBIMENTO";




                dgProdutos.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Produtos!\n\n" + erro);
            }
        }

        public static void CarregarProdutosNome()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblprodutos WHERE nomeProduto LIKE '%" + variaveis.nomeProduto + "%' ORDER BY nomeProduto;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgProdutos.DataSource = dt;

                dgProdutos.Columns[0].Visible = false;
                dgProdutos.Columns[1].HeaderText = "NOME";
                dgProdutos.Columns[2].HeaderText = "DESCRIÇÃO";
                dgProdutos.Columns[3].HeaderText = "CATEGORIA";
                dgProdutos.Columns[4].HeaderText = "STATUS";
                dgProdutos.Columns[5].HeaderText = "PREÇO DE COMPRA";
                dgProdutos.Columns[6].HeaderText = "PREÇO DE VENDA";
                dgProdutos.Columns[7].HeaderText = "FORNECEDOR";
                dgProdutos.Columns[8].HeaderText = "DATA RECEBIMENTO";
                dgProdutos.Columns[9].HeaderText = "HORA RECEBIMENTO";


                dgProdutos.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Produtos pelo nome!\n\n" + erro);
            }
        }


        public static void CarregarStatusProdutos()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblprodutos WHERE statusProduto =  'ATIVO' ORDER BY nomeProduto;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgProdutos.DataSource = dt;

                dgProdutos.Columns[0].Visible = false;
                dgProdutos.Columns[1].HeaderText = "NOME";
                dgProdutos.Columns[2].HeaderText = "DESCRIÇÃO";
                dgProdutos.Columns[3].HeaderText = "CATEGORIA";
                dgProdutos.Columns[4].HeaderText = "STATUS";
                dgProdutos.Columns[5].HeaderText = "PREÇO DE COMPRA";
                dgProdutos.Columns[6].HeaderText = "PREÇO DE VENDA";
                dgProdutos.Columns[7].HeaderText = "FORNECEDOR";
                dgProdutos.Columns[8].HeaderText = "DATA RECEBIMENTO";
                dgProdutos.Columns[9].HeaderText = "HORA RECEBIMENTO";


                dgProdutos.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os status do produto!\n\n" + erro);
            }
        }

        public static void InserirProdutos()
        {
            try
            {
                conexao.Conectar();
                string inserir = "INSERT INTO tblprodutos(nomeProduto, descricaoProduto, categoriaProduto, statusProduto, precoCompraProduto, precoVendaProduto, fornecedorProduto, dataReceProduto, horaProduto) VALUES (@nome,@descricao,@categoria,@status,@precoCompra,@precoVenda,@fornecedor,@data,@hora); ";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                //parâmetros 
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeProduto);
                cmd.Parameters.AddWithValue("@descricao", variaveis.descricaoProduto);
                cmd.Parameters.AddWithValue("@categoria", variaveis.categoriaProduto);
                cmd.Parameters.AddWithValue("@@status", variaveis.statusProduto);
                cmd.Parameters.AddWithValue("@precoCompra", variaveis.precoCompraProduto);
                cmd.Parameters.AddWithValue("@precoVenda", variaveis.precoVendaProduto);
                cmd.Parameters.AddWithValue("@fornecedor", variaveis.fornecedorProduto);
                cmd.Parameters.AddWithValue("@data", variaveis.dataReceProduto);
                cmd.Parameters.AddWithValue("@hora", variaveis.horaProduto);

                //fim parâmetros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Cadastrado Com Sucesso!", "CADASTRO PRODUTO");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar o produto!\n\n" + erro.Message, "ERRO");
            }
        }

        public static void CarregarDadosProdutos()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblprodutos WHERE idProduto = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codProduto);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.nomeProduto = reader.GetString(1);
                    variaveis.descricaoProduto = reader.GetString(2);
                    variaveis.categoriaProduto = reader.GetString(3);
                    variaveis.statusProduto = reader.GetString(4);
                    variaveis.precoCompraProduto = (int)reader.GetDecimal(5);
                    variaveis.precoVendaProduto = (int)reader.GetDecimal(6);
                    variaveis.fornecedorProduto = reader.GetString(7);
                    variaveis.dataReceProduto = reader.GetDateTime(8);

                    // Obter valor TimeSpan da coluna 9
                    TimeSpan horaRecebida = reader.GetTimeSpan(9);

                    // Atribuir valor a variável
                    variaveis.horaProduto = DateTime.Today.Add(horaRecebida);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Produtos!\n\n" + erro);
            }
        }
        public static void AlterarProdutos()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblprodutos SET nomeProduto=@nome,descricaoProduto=@descricao, categoriaProduto=@categoria, statusProduto=@status, precoCompraProduto=@precoCompra, precoVendaProduto=@precoVenda, fornecedorProduto=@fornecedor,dataReceProduto=@dataRecebimento, horaProduto=@hora WHERE idProduto=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parâmetros 
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeProduto);
                cmd.Parameters.AddWithValue("@descricao", variaveis.descricaoProduto);
                cmd.Parameters.AddWithValue("@categoria", variaveis.categoriaProduto);
                cmd.Parameters.AddWithValue("@status", variaveis.statusProduto);
                cmd.Parameters.AddWithValue("@precoCompra", variaveis.precoCompraProduto);
                cmd.Parameters.AddWithValue("@precoVenda", variaveis.precoVendaProduto);
                cmd.Parameters.AddWithValue("@fornecedor", variaveis.fornecedorProduto);
                cmd.Parameters.AddWithValue("@dataRecebimento", variaveis.dataReceProduto);
                cmd.Parameters.AddWithValue("@hora", variaveis.horaProduto);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codProduto);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Alterado Com Sucesso!", "CADASTRO PRODUTO");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterado o Produto!\n\n" + erro.Message, "ERRO");
            }
        }
        public static void DesativarProdutos()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblprodutos SET statusProduto='DESATIVADO' WHERE idProduto = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parâmetros 

                cmd.Parameters.AddWithValue("@status", variaveis.statusProduto);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codProduto); // Correção do parâmetro
                                                                                  //fim parâmetros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Desativado Com Sucesso!", " DESATIVADO PRODUTO");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao desativar o Produto!\n\n" + erro.Message, "ERRO");
            }
        }

        // Fim Formulário Produtos //


        // Inicio Formulário Emails //

        public static void CarregarEmails()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblcontato";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgEmails.DataSource = dt;

                dgEmails.Columns[0].Visible = false;
                dgEmails.Columns[1].HeaderText = "NOME";
                dgEmails.Columns[2].HeaderText = "EMAIL";
                dgEmails.Columns[3].HeaderText = "TELEFONE";
                dgEmails.Columns[4].HeaderText = "MENSAGEM";
                dgEmails.Columns[5].HeaderText = "DATA";
                dgEmails.Columns[6].HeaderText = "STATUS";
                dgEmails.Columns[7].HeaderText = "HORA";



                dgEmails.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os emails!\n\n" + erro);
            }
        }


        public static void CarregarEmailsNome()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblcontato WHERE nomeContato LIKE '%" + variaveis.nomeContato + "%' ORDER BY nomeContato;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgEmails.DataSource = dt;

                dgEmails.Columns[0].Visible = false;
                dgEmails.Columns[1].HeaderText = "NOME";
                dgEmails.Columns[2].HeaderText = "EMAIL";
                dgEmails.Columns[3].HeaderText = "TELEFONE";
                dgEmails.Columns[4].HeaderText = "MENSAGEM";
                dgEmails.Columns[5].HeaderText = "DATA";
                dgEmails.Columns[6].HeaderText = "STATUS";
                dgEmails.Columns[7].HeaderText = "HORA";



                dgEmails.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os emails!\n\n" + erro);
            }
        }

        public static void CarregarStatusEmails()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblcontato WHERE statusContato =  'ATIVO' ORDER BY nomeContato;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgEmails.DataSource = dt;

                dgEmails.Columns[0].Visible = false;
                dgEmails.Columns[1].HeaderText = "NOME";
                dgEmails.Columns[2].HeaderText = "EMAIL";
                dgEmails.Columns[3].HeaderText = "TELEFONE";
                dgEmails.Columns[4].HeaderText = "MENSAGEM";
                dgEmails.Columns[5].HeaderText = "DATA";
                dgEmails.Columns[6].HeaderText = "STATUS";
                dgEmails.Columns[7].HeaderText = "HORA";



                dgEmails.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar Status do email!\n\n" + erro);
            }

        }

        public static void InserirEmails()
        {
            try
            {
                conexao.Conectar();
                string inserir = "INSERT INTO tblcontato(nomeContato, emailContato, telefoneContato, mensagemContato, statusContato) VALUES (@nome,@email,@telefone,@mensagem,@status); ";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                //parâmetros 
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeContato);
                cmd.Parameters.AddWithValue("@email", variaveis.emailContato);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneContato);
                cmd.Parameters.AddWithValue("@mensagem", variaveis.mensagemContato);
                cmd.Parameters.AddWithValue("@status", variaveis.statusContato);
               
               
                //fim parâmetros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Email Cadastrado Com Sucesso!", "Emails");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar o Email!\n\n" + erro.Message, "ERRO");
            }

        }

        public static void CarregarDadosEmails()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblcontato WHERE idContato = @codigo; ";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codContatos);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.nomeContato = reader.GetString(1);
                    variaveis.emailContato = reader.GetString(2);
                    variaveis.telefoneContato = reader.GetString(3);
                    variaveis.mensagemContato = reader.GetString(4);
                    variaveis.statusContato = reader.GetString(6);
                   

                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Emails!\n\n" + erro);
            }
        }

        public static void AlterarEmails()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblcontato SET nomeContato = @nome, emailContato = @email, telefoneContato = @telefone, mensagemContato = @mensagem, statusContato = @status WHERE idContato = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parâmetros 
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeContato);
                cmd.Parameters.AddWithValue("@email", variaveis.emailContato);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneContato);
                cmd.Parameters.AddWithValue("@mensagem", variaveis.mensagemContato);
                cmd.Parameters.AddWithValue("@status", variaveis.statusContato);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codContatos);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Email Alterado Com Sucesso!", "CADASTRO EMAILS");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterado o E-mails!\n\n" + erro.Message, "ERRO");
            }
        }


        public static void DesativarEmails()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblcontato SET statusContato='DESATIVADO' WHERE idContato = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parâmetros 

                cmd.Parameters.AddWithValue("@status", variaveis.statusContato);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codContatos); 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contato Desativado Com Sucesso!", " DESATIVADO CONTATO");
                conexao.Desconectar();
             }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao desativar o Email!\n\n" + erro.Message, "ERRO");
            }
        }

        // Fim métodos do Email //


        // Inicio Formulario Estoque

        public static void CarregarEstoque()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT m.idEstoque, m.nomeEstoque,m.quantidadeEstoque,m.dataCadastroEstoque,m.dataAtualiEstoque, m.statusEstoque, m.horaEstoque,   a.nomeProduto FROM tblestoque m INNER JOIN     tblprodutos a ON m.idProduto = a.idProduto ORDER BY m.idEstoque ASC;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgEstoque.DataSource = dt;

                dgEstoque.Columns[0].Visible = false;
                dgEstoque.Columns[1].HeaderText = "NOME";
                dgEstoque.Columns[2].HeaderText = "QUANTIDADE";
                dgEstoque.Columns[3].HeaderText = "DATA DE CADASTRO";
                dgEstoque.Columns[4].HeaderText = "DATA DE ATUALIZAÇÃO";
                dgEstoque.Columns[5].HeaderText = "STATUS";
                dgEstoque.Columns[6].HeaderText = "HORA";
                dgEstoque.Columns[7].HeaderText = "PRODUTO";
               


                dgEstoque.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar Estoque!\n\n" + erro);
            }
        }

        public static void CarregarEstoqueNome()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblestoque WHERE nomeEstoque LIKE '%" + variaveis.nomeEstoque + "%' ORDER BY nomeEstoque;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgEstoque.DataSource = dt;

                dgEstoque.Columns[0].Visible = false;
                dgEstoque.Columns[1].HeaderText = "NOME";
                dgEstoque.Columns[2].HeaderText = "QUANTIDADE";
                dgEstoque.Columns[3].HeaderText = "DATA DE CADASTRO";
                dgEstoque.Columns[4].HeaderText = "DATA DE ATUALIZAÇÃO";
                dgEstoque.Columns[5].HeaderText = "STATUS";
                dgEstoque.Columns[6].HeaderText = "HORA";
                dgEstoque.Columns[7].HeaderText = "PRODUTO";




                dgEstoque.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os estoques pelo nome!\n\n" + erro);
            }


        }

        public static void CarregarStatusEstoque()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblestoque WHERE statusEstoque =  'ATIVO' ORDER BY nomeEstoque;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgEstoque.DataSource = dt;

                dgEstoque.Columns[0].Visible = false;
                dgEstoque.Columns[1].HeaderText = "NOME";
                dgEstoque.Columns[2].HeaderText = "QUANTIDADE";
                dgEstoque.Columns[3].HeaderText = "DATA DE CADASTRO";
                dgEstoque.Columns[4].HeaderText = "DATA DE ATUALIZAÇÃO";
                dgEstoque.Columns[5].HeaderText = "STATUS";
                dgEstoque.Columns[6].HeaderText = "HORA";
                dgEstoque.Columns[7].HeaderText = "PRODUTO";




                dgEstoque.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os status do Estoque!\n\n" + erro);
            }
        }

        public static void InserirEstoque()
        {
            try
            {
                conexao.Conectar();
                string inserir = "INSERT INTO tblestoque(nomeEstoque, quantidadeEstoque, statusEstoque, idProduto) SELECT @nome, @quantidade, @status p.idProduto FROM tblprodutos p WHERE p.nomeProduto = @nomeDoProduto; ";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                //parâmetros 
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeEstoque);
                cmd.Parameters.AddWithValue("@quantidade", variaveis.quantidadeEstoque);
                cmd.Parameters.AddWithValue("@status", variaveis.statusEstoque);
                cmd.Parameters.AddWithValue("@nomeDoproduto", variaveis.nomeProduto);
               
                //fim parâmetros
                cmd.ExecuteNonQuery();
                MessageBox.Show("ESTOQUE Cadastrado Com Sucesso!", "CADASTRO ESTOQUE");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar o estoque!\n\n" + erro.Message, "ERRO");
            }
        }
        public static void CarregarDadosEstoque()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT e.*, p.nomeProduto FROM tblestoque e INNER JOIN tblprodutos p ON e.idProduto = p.idProduto WHERE e.idEstoque = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codEstoque);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.nomeEstoque = reader.GetString(1);

                    // Convertendo a string para inteiro corretamente
                    if (!reader.IsDBNull(2)) // Verifica se o valor não é nulo
                    {
                        variaveis.quantidadeEstoque = reader.GetInt32(2);
                    }
                    else
                    {
                        // Tratar o caso em que a quantidade de estoque é nula
                        // Por exemplo, definir um valor padrão
                        variaveis.quantidadeEstoque = 0; // ou outro valor padrão desejado
                    }

                    variaveis.statusEstoque = reader.GetString(5);

                    // Ajustando o índice para obter o nome do produto corretamente
                    variaveis.nomeProduto = reader.GetString(6); // Supondo que 6 é o índice correto para o nome do produto
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Funcionários!\n\n" + erro);
            }
        }



        public static void AlterarEstoque()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblestoque SET nomeEstoque= @nome, quantidadeEstoque=@quantidade,statusEstoque=@status, idProduto=@produto WHERE idEstoque =@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parâmetros 
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeEstoque);
                cmd.Parameters.AddWithValue("@quantidade", variaveis.quantidadeEstoque); 
                cmd.Parameters.AddWithValue("@status", variaveis.statusEstoque);
                cmd.Parameters.AddWithValue("@produto", variaveis.nomeProduto);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codEstoque);
               
                //fim parâmetros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Estoque Alterado Com Sucesso!", "CADASTRO ESTOQUE");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterado o ESTOQUE!\n\n" + erro.Message, "ERRO");
            }
        }

        public static void DesativarEstoque()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblestoque SET statusEstoque='DESATIVADO' WHERE idEstoque = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parâmetros 

                cmd.Parameters.AddWithValue("@status", variaveis.statusEstoque);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codEstoque); 
                                                                             
                cmd.ExecuteNonQuery();
                MessageBox.Show("Estoque Desativado Com Sucesso!", " DESATIVADO ESTOQUE");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao desativar o Estoque!\n\n" + erro.Message, "ERRO");
            }
        }

        // Fim Formulário Estoque //


        // Inicio Formulario Vendas //

        public static void CarregarTblVenda()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT v.idVenda, f.nomeFuncionario AS FUNCIONÁRIO, v.dataVenda AS 'DATA DA VENDA', v.horaVenda AS 'HORA DA VENDA', v.statusVenda AS STATUS, v.valorTotalVenda AS 'VALOR TOTAL', p.nomeProduto AS PRODUTO FROM tblvendas v INNER JOIN tblfuncionarios f ON v.idFuncionario = f.idFuncionario INNER JOIN tblprodutos p ON v.idProduto = p.idProduto ORDER BY v.idVenda ASC;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                dgVendas.DataSource = dt;

                dgVendas.Columns[0].Visible = false;
                dgVendas.Columns[1].HeaderText = "FUNCIONÁRIO";
                dgVendas.Columns[2].HeaderText = "DATA DA VENDA";
                dgVendas.Columns[3].HeaderText = "HORA DA VENDA";
                dgVendas.Columns[4].HeaderText = "STATUS";
                dgVendas.Columns[5].HeaderText = "VALOR TOTAL";
                dgVendas.Columns[6].HeaderText = "PRODUTO";
               
                dgVendas.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar Vendas!\n\n" + erro);
            }
        }

        public static void CarregarVendasNome()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT v.idVenda, f.nomeFuncionario AS FUNCIONÁRIO, v.dataVenda AS 'DATA DA VENDA', v.horaVenda AS 'HORA DA VENDA', v.statusVenda AS STATUS, v.valorTotalVenda AS 'VALOR TOTAL', p.nomeProduto AS PRODUTO FROM tblvendas v INNER JOIN tblfuncionarios f ON v.idFuncionario = f.idFuncionario INNER JOIN tblprodutos p ON v.idProduto = p.idProduto WHERE f.nomeFuncionario LIKE @nomeFuncionario ORDER BY v.idVenda ASC;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("@nomeFuncionario", "%" + variaveis.nomeFuncionario + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVendas.DataSource = dt;




                dgVendas.Columns[0].Visible = false;
                dgVendas.Columns[1].HeaderText = "FUNCIONÁRIO";
                dgVendas.Columns[2].HeaderText = "DATA DA VENDA";
                dgVendas.Columns[3].HeaderText = "HORA DA VENDA";
                dgVendas.Columns[4].HeaderText = "STATUS";
                dgVendas.Columns[5].HeaderText = "VALOR TOTAL";
                dgVendas.Columns[6].HeaderText = "PRODUTO";




                dgVendas.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Vendas pelo nome!\n\n" + erro);
            }
        }

        public static void CarregarStatusVendas()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT v.idVenda, v.statusVenda, v.valorTotalVenda, v.horaVenda, v.dataVenda, f.nomeFuncionario, p.nomeProduto, p.precoCompraProduto FROM tblvendas v INNER JOIN tblfuncionarios f ON v.idFuncionario = f.idFuncionario INNER JOIN tblprodutos p ON v.idProduto = p.idProduto WHERE v.statusVenda = 'ATIVO';";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgVendas.DataSource = dt;

                dgVendas.Columns[0].Visible = false;
                dgVendas.Columns[1].HeaderText = "FUNCIONÁRIO";
                dgVendas.Columns[2].HeaderText = "DATA DA VENDA";
                dgVendas.Columns[3].HeaderText = "HORA DA VENDA";
                dgVendas.Columns[4].HeaderText = "STATUS";
                dgVendas.Columns[5].HeaderText = "VALOR TOTAL";
                dgVendas.Columns[6].HeaderText = "PRODUTO";

                dgVendas.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os status da Vendas!\n\n" + erro);
            }
        }

        public static void InserirVendas()
        {
            try
            {
                conexao.Conectar();
                string inserir = "INSERT INTO tblvendas(idFuncionario,statusVenda, valorTotalVenda, idProduto) VALUES (@funcionario,@status,@valor,@produto);";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                // Parâmetros 
                cmd.Parameters.AddWithValue("@funcionario", variaveis.idFuncionario);
                cmd.Parameters.AddWithValue("@status", variaveis.statusVenda);
                cmd.Parameters.AddWithValue("@valor", variaveis.valorTotalVenda);
                cmd.Parameters.AddWithValue("@produto", variaveis.nomeProduto);

                // Fim parâmetros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vendas Cadastradada Com Sucesso!", "CADASTRO VENDAS");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar o Vendas!\n\n" + erro.Message, "ERRO");
            }
        }

        public static void CarregarDadosVendas()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT v.*, p.nomeProduto " +
                                    "FROM tblvendas v " +
                                    "INNER JOIN tblprodutos p ON v.idProduto = p.idProduto " +
                                    "WHERE v.idVenda = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codVendas);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.nomeFuncionario = reader.GetString(1);
                    variaveis.statusVenda = reader.GetString(4);
                    variaveis.valorTotalVenda = reader.GetString(5);
                    variaveis.nomeProduto = reader.GetString(6);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar vendas!\n\n" + erro);
            }
        }


        public static void AlterarVendas()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblvendas SET idFuncionario=@funcionario, statusVenda=@status, valorTotalVenda=@valorVenda, idProduto=@produto WHERE idVenda=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parâmetros 
                cmd.Parameters.AddWithValue("@funcionario", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@status", variaveis.statusVenda);
                cmd.Parameters.AddWithValue("@valorVenda",variaveis.valorTotalVenda);
                cmd.Parameters.AddWithValue("@produto", variaveis.nomeProduto);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codVendas);

                //fim parâmetros
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vendas Alterado Com Sucesso!", "CADASTRO VENDAS");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar as Vendas!\n\n" + erro.Message, "ERRO");
            }
        }

        public static void DesativarVendas()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblvendas SET statusVenda='DESATIVADO' WHERE idVenda = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                
                cmd.Parameters.AddWithValue("@status", variaveis.statusVenda);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codVendas);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Vendas Desativado Com Sucesso!", " DESATIVADO VENDAS");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao desativar o Vendas!\n\n" + erro.Message, "ERRO");
            }
        }

        // Inicio Formulário Cliente-Usuário Menu Principal //

        public static void CarregarCliente()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblusuarios";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgClientes.DataSource = dt;

                dgClientes.Columns[0].Visible = false;
                dgClientes.Columns[1].HeaderText = "NOME";
                dgClientes.Columns[2].HeaderText = "EMAIL";
                dgClientes.Columns[3].HeaderText = "SENHA";
                dgClientes.Columns[4].HeaderText = "STATUS";
                dgClientes.Columns[5].HeaderText = "FOTO";

                dgClientes.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os clientes!\n\n" + erro);
            }
        }

        public static void CarregarClienteNome()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblusuarios WHERE nomeUsuario LIKE '%" + variaveis.nomeUsuario + "%' ORDER BY nomeUsuario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgClientes.DataSource = dt;

                dgClientes.Columns[0].Visible = false;
                dgClientes.Columns[1].HeaderText = "NOME";
                dgClientes.Columns[2].HeaderText = "EMAIL";
                dgClientes.Columns[3].HeaderText = "SENHA";
                dgClientes.Columns[4].HeaderText = "STATUS";
                dgClientes.Columns[5].HeaderText = "FOTO";

                dgClientes.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os clientes pelo nome!\n\n" + erro);
            }
        }

        public static void CarregarStatusCliente()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblusuarios WHERE statusUsuario =  'ATIVO' ORDER BY nomeUsuario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgClientes.DataSource = dt;

                dgClientes.Columns[0].Visible = false;
                dgClientes.Columns[1].HeaderText = "NOME";
                dgClientes.Columns[2].HeaderText = "EMAIL";
                dgClientes.Columns[3].HeaderText = "SENHA";
                dgClientes.Columns[4].HeaderText = "STATUS";
                dgClientes.Columns[5].HeaderText = "FOTO";
               
                dgClientes.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar status do Cliente!\n\n" + erro);
            }

            // Inicio Cadastro Usuario Alteração e Exclusão //

        }
        public static void InserirCliente()
        {
            try
            {
                conexao.Conectar();
                string inserir = "INSERT INTO tblusuarios (nomeUsuario,emailUsuario, senhaUsuario, statusUsuario, fotoUsuario) VALUES (@nome, @email, @senha, @status, @foto)";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeUsuario);
                cmd.Parameters.AddWithValue("@email", variaveis.emailUsuario);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaUsuario);
                cmd.Parameters.AddWithValue("@status", variaveis.statusUsuario);
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoUsuario);
               
               
                cmd.ExecuteNonQuery();
                MessageBox.Show("USUÁRIO Cadastrado Com Sucesso!", "CADASTRO USUÁRIO");
                conexao.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoUsuario))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "Usuario/" + Path.GetFileName(variaveis.fotoUsuario);
                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoUsuario, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch
                        {
                            MessageBox.Show("Foto não Selecionada ou Existente.", "FOTO");
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Cadastrar o Usuário!\n\n" + erro.Message, "ERRO");
            }
        }

        public static void CarregarDadosCliente()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblusuarios WHERE idUsuario = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codUsuario);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // Lê a próxima linha do resultado da consulta
                {
                    variaveis.nomeUsuario = reader.GetString(1);
                    variaveis.emailUsuario = reader.GetString(2);
                    variaveis.senhaUsuario = reader.GetString(3);
                    variaveis.statusUsuario = reader.GetString(4);
                    variaveis.fotoUsuario = reader.GetString(5);
                    variaveis.fotoUsuario = variaveis.fotoUsuario.Remove(0, 8);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Usuários!\n\n" + erro);
            }
        }

        public static void AlterarCliente()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblusuarios SET nomeUsuario = @nome, emailUsuario = @email, senhaUsuario = @senha, statusUsuario = @status WHERE idUsuario = @codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);

                // Parâmetros
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeUsuario);
                cmd.Parameters.AddWithValue("@email", variaveis.emailUsuario);
                cmd.Parameters.AddWithValue("@senha", variaveis.senhaUsuario);
                cmd.Parameters.AddWithValue("@status", variaveis.statusUsuario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codUsuario);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário Alterado Com Sucesso!", "CADASTRO Cliente");
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar o Usuário!\n\n" + erro.Message, "ERRO");
            }
        }

        public static void AlterarFotoCliente()
        {
            try
            {

                conexao.Conectar();
                string alterar = "UPDATE tblusuarios SET fotoUsuario = @foto WHERE idUsuario = @codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                cmd.Parameters.AddWithValue("@foto", variaveis.fotoUsuario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codUsuario);
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoUsuario))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "Usuario/" + Path.GetFileName(variaveis.fotoUsuario);
                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoUsuario, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Foto não Selecionada ou foto já existente no servidor.\n\n " + ex.Message, "Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }


                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar a Foto do Cliente! \n\n" + erro.Message, "Erro");
            }
        }
        public static void DesativarCliente()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblusuarios SET statusUsuario='DESATIVADO' WHERE idUsuario = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parâmetros 

                cmd.Parameters.AddWithValue("@status", variaveis.statusUsuario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codUsuario); 
                                                                                 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Desativado Com Sucesso!", " DESATIVADO CLIENTE");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao desativar o cliente!\n\n" + erro.Message, "ERRO");
            }
        }

        // Fim Métodos do Clientes //



    }
}












