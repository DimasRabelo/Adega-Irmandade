using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Adega_Irmandade
{
    public static class banco
    {
        public static DataGridView dgProdutosVendidos, dgContato, dgFuncionario, dgProdutos, dgEmails, dgEstoque;


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

        // Converter a Imagem de Byte para IMGSystem.Net.WebException: 'O servidor remoto retornou um erro: (530) Não conectado(a).'

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream memoryStream = new MemoryStream();
            byte[] pData = blob;
            memoryStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(memoryStream, false);
            memoryStream.Dispose();
            return bm;
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


        // Fim do Formulário do Funcionario //

        // Inicio do Cadastro dos Funcionarios//

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

        // Fim do Cadastro dos Funcionários //

        // Inicio do Alterar Funcionários //

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
                MessageBox.Show("Erro ao carregar os Instrutores!\n\n" + erro);
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
                MessageBox.Show("Erro ao Alterado o Funcionário!\n\n" + erro.Message, "ERRO");
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

        // Fim do Alterar Funcionário //

        // Inicio do Excluir Funcionário //

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
                dgProdutos.Columns[6].HeaderText = "PREÇO DE VENDA";
                dgProdutos.Columns[7].HeaderText = "FORNECEDOR";
                dgProdutos.Columns[8].HeaderText = "DATA RECEBIMENTO";
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
                dgProdutos.Columns[5].DefaultCellStyle.Format = "C";
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


    }
}









// Fim do Excluir Funcionário //


