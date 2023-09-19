# Documentação do Projeto - CRUD de Produtos em C#

##
<p align="center">
  <img src="https://github.com/JoaoVitorAguiar/ProductManagerSolutionWinForms/blob/main/scr/img/ProductManagerJoaoVitorAguiarDemonstracao.gif" width="450" />
</p>

## Descrição do Projeto

Este projeto é um CRUD (Create, Read, Update, Delete) para o cadastro de produtos, desenvolvido em C#. O objetivo é criar uma aplicação que permita adicionar, remover, editar e visualizar produtos. O projeto foi implementado em Windows Forms.

## Tecnologias Utilizadas

### Boas Práticas e Padrões de Programação
- O projeto segue boas práticas de programação, incluindo a organização do código, nomenclatura consistente e comentários explicativos.
- Padrões de projeto são aplicados conforme necessário para garantir uma arquitetura sólida e escalável.
- Apliquei a abordagem Code First para gerar o banco de dados por meio do modelo, aplicando as migrations pelo Entity Framework Core.

### Orientação a Objetos
- A orientação a objetos é fundamental no projeto, com a criação de classes e objetos para representar produtos e gerenciar operações CRUD.

## Funcionalidades

O CRUD de produtos oferece as seguintes funcionalidades:

### Adicionar um Item
- Permite adicionar um novo produto, especificando seu nome, preço e outros detalhes relevantes.

### Remover um Item pelo ID
- Permite remover um produto com base no seu ID único.

### Editar o Nome de um Item
- Permite editar o nome de um produto após informar o ID correspondente.

### Visualizar Todos os Itens Cadastrados
- Exibe uma lista de todos os produtos cadastrados, incluindo seus detalhes.

## Estrutura do Código

O projeto está organizado da seguinte maneira:

- **Classe Produto**: Representa um produto e inclui propriedades como ID, nome e preço.
- **Classe ProdutoRepository**: Gerencia a lógica de armazenamento e operações CRUD dos produtos.
- **Program.cs**: O ponto de entrada da aplicação, onde o menu principal e interações com o usuário são tratados.

## Padrões de Projeto

O projeto segue os seguintes padrões de projeto:

- **Padrão Repository**: O `ProdutoRepository` separa a lógica de acesso aos dados do restante da a  plicação, promovendo a separação de preocupações.
- **Padrão UI**: Projeto segue um padrão simples de interface do usuário baseada em Windows Forms.

## Boas Práticas

O código é escrito seguindo boas práticas, incluindo:

- Comentários explicativos para tornar o código mais compreensível.
- Nomes de variáveis e métodos significativos e autoexplicativos.
- Tratamento de erros adequado com mensagens de erro claras.

## Execução

A seguir, apresentamos as instruções para executar a aplicação:

### Windows Forms

1. Abra o Visual Studio ou a IDE de sua escolha.
2. Abra o projeto da aplicação Windows Forms.
3. Aplique as migrations para gerar o banco Sqlite, caso necessário.
4. Pressione F5 ou inicie a depuração para iniciar a aplicação Windows Forms, pode ser em modo debug ou release.
5. Use a interface do aplicativo para interagir com o CRUD de produtos.


Lembre-se de que a execução da aplicação pode variar dependendo do ambiente de desenvolvimento e das configurações específicas do projeto. Certifique-se de seguir as instruções adequadas ao seu cenário.
*OBS*: Para editar um produto, e posteriormente poder deletar ou salvar a edição, clique duas vezes no indicador esquerdo do grid do registro desejado;


