﻿using System;

namespace Adega_Irmandade
{
    public static class variaveis
    {
        public static int linhaSelecionada;
        public static string funcao;
        // LOGIN
        public static string usuario, senha, nivel;

        // MENU
        public static int maisVendidos, qtdFuncionarios, qtdProdutos, qtdEstoque,qtdCliente,qtdVendas,qtdEmails, codContato;
        
     
        public static string enderecoServidorFtp = "ftp://127.0.0.1/img/";
        public static string usuarioFtp = "adegairmandade";
        public static string senhaFtp = "123";

        // IDS  REFERENTE A CADA TABELA //
        public static int codFuncionario, codProduto, codVendas, codEstoque, codContatos, codUsuario;

        // FORMULARIO FUNCIONÁRIOS //

        public static string idFuncionario, nomeFuncionario, altFuncionario, cargoFuncionario, emailFuncionario, senhaFuncionario, nivelFuncionario, enderecoFuncionario, cepFuncionario, telFuncionario, statusFuncionario, linkFaceFuncionario, linkInstaFuncionario, linkWhatsFuncionario, fotoFuncionario, atFotoFuncionario, caminhoFotoFuncionario;

        public static DateTime dataNascFuncionario, dataAdmissaoFuncionario;


        // FORMULÁRIO PRODUTOS //

        public static string nomeProduto, descricaoProduto,categoriaProduto,statusProduto,precoCompraProduto,precoVendaProduto,fornecedorProduto;
        public static DateTime dataReceProduto, horaProduto;

      
        // FORMULÁRIO ESTOQUE //

        public static string nomeEstoque,quantidadeEstoque, statusEstoque,  idProduto;
        public static DateTime dataCadastroEstoque, dataAtualiEstoque, horaEstoque;

        // FORMULÁRIO VENDAS //

        public static string statusVenda, valorTotalVenda;
        public static DateTime dataVenda, horaVenda;

        
        // FORMULÁRIO EMAIL //

        public static string nomeContato,emailContato, telefoneContato, mensagemContato,statusContato;

        public static DateTime dataContato, horaContato;

        // FORMULARIO CLIENTE-USUÁRIO //

        public static string nomeUsuario, emailUsuario, senhaUsuario, fotoUsuario, statusUsuario, atFotoUsuario, caminhoFotoUsuario;
      

    }
}
