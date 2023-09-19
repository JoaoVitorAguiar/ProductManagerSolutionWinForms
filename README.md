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

- **Padrão Repository**: O `ProdutoRepository` separa a lógica de acesso aos dados do restante da aplicação, promovendo a separação de preocupações.
- **Padrão Console UI**: Para a versão Console Application, o projeto segue um padrão simples de interface do usuário baseada em console.

## Boas Práticas

O código é escrito seguindo boas práticas, incluindo:

- Comentários explicativos para tornar o código mais compreensível.
- Nomes de variáveis e métodos significativos e autoexplicativos.
- Tratamento de erros adequado com mensagens de erro claras.

## Conclusão

Este projeto demonstra a capacidade de desenvolver um CRUD de produtos em C#, seguindo boas práticas, padrões de projeto e orientação a objetos. Ele é uma oportunidade para avaliar as habilidades do desenvolvedor em criar uma aplicação funcional e bem estruturada.

Para qualquer dúvida ou esclarecimento adicional, sinta-se à vontade para entrar em contato. Agradecemos por considerar este projeto e desejamos boa sorte!

