#  Adega Irmandade - Sistema de Gestão Desktop

Este projeto é um sistema de gerenciamento desktop (ERP) para a "Adega Irmandade", desenvolvido em C# com Windows Forms. A aplicação permite o controle completo de clientes, fornecedores, produtos, usuários e vendas.

## Status do Projeto


:white_check_mark: **Projeto concluído** :white_check_mark:

## Funcionalidades Principais

Pela análise dos formulários do projeto, o sistema implementa as seguintes funcionalidades:

* **Autenticação:** Tela de Login (`Login.cs`) e gerenciamento de permissões.
* **Menu Principal:** Navegação central do sistema (`Menu.cs`).
* **Gestão de Cadastros (CRUD):**
    * Cadastro de Usuários (`CadastroUsuario.cs`, `ListarUsuario.cs`)
    * Cadastro de Clientes (`CadastroCliente.cs`, `ListarCliente.cs`)
    * Cadastro de Fornecedores (`CadastroFornecedor.cs`, `ListarFornecedor.cs`)
    * Cadastro de Produtos (`CadastroProduto.cs`, `ListarProduto.cs`)
* **Módulo de Vendas:** Formulário para registrar vendas (`Venda.cs`).
* **Relatórios:** Geração de relatórios gerenciais (`Relatorio.cs`).

## Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** .NET Framework [Complete com a versão, ex: 4.7.2]
* **UI:** Windows Forms
* **Banco de Dados:** [SQL Server / MySQL / Outro]

## Pré-requisitos

Para executar este projeto localmente, você precisará de:

* [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/vs/older-downloads/) (ou superior)
* .NET Framework [Mesma versão de cima]
* [SQL Server Management Studio](https://learn.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms) (ou o SGBD que você usou)

## Como Executar

1.  **Clonar o repositório:**
    ```bash
    git clone [https://github.com/](https://github.com/)dimasrabelo/Adega-Irmandade.git
    ```

2.  **Abrir a Solução:**
    * Abra o arquivo `Adega-Irmandade.sln` com o Visual Studio.

3.  **Configurar o Banco de Dados:**
    * Localize o arquivo `App.config` no projeto.
    * Altere a `connectionString` para apontar para o seu servidor de banco de dados local.
   

4.  **Executar o Projeto:**
    * Pressione `F5` ou clique no botão "Start" (Iniciar) no Visual Studio para compilar e executar a aplicação.

## Autor

* **Dimas Aparecido Rabelo de Souza**
* **GitHub:** `https://github.com/dimasrabelo`
* **LinkedIn:** `https://www.linkedin.com/in/dimasrabelo/`

## Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo `LICENSE.md` (se houver) para mais detalhes.
