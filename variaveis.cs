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

        // FORMULARIO FUNCIONÁRIOS //
        public static int codFuncionario;

        public static string nomeFuncionario,altFuncionario, cargoFuncionario,  emailFuncionario, senhaFuncionario, nivelFuncionario, enderecoFuncionario, cepFuncionario, telFuncionario, statusFuncionario, linkFaceFuncionario, linkInstaFuncionario, linkWhatsFuncionario, fotoFuncionario, atFotoFuncionario, caminhoFotoFuncionario;

        public static DateTime dataNascFuncionario, dataAdmissaoFuncionario;

        public static string enderecoServidorFtp = "ftp://127.0.0.1/img/";
        public static string usuarioFtp = "adegairmandade";
        public static string senhaFtp = "123";

        // FIM FORMULÁRIO FUNCIONARIO //

        // FORMULÁRIO PRODUTOS //

        public static int codProduto;

        public static string nomeProduto, descricaoProduto,categoriaProduto,statusProduto,precoCompraProduto,precoVendaProduto,fornecedorProduto;
        public static DateTime dataReceProduto, horaProduto;

        // FORMULÁRIO ESTOQUE //

        public static int codEstoque;

        public static string nomeEstoque,quantidadeEstoque, statusEstoque,  idProduto;
        public static DateTime dataCadastroEstoque, dataAtualiEstoque, horaEstoque;

        // FORMULÁRIO VENDAS //

        public static int codVendas;


        // FORMULÁRIO EMAIL //

        public static int codContatos;

        public static string nomeContato,emailContato, telefoneContato, mensagemContato,statusContato;

        public static DateTime dataContato, horaContato;

        // FORMULARIO CLIENTE-USUÁRIO //

        public static int codUsuario;

        public static string nomeUsuario, emailUsuario, senhaUsuario, fotoUsuario, statusUsuario, atFotoUsuario, caminhoFotoUsuario;

        










    }
}
