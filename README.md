#  API de Gerenciamento de Estoque
É uma API RESTful simples para gerenciar produtos em um sistema de estoque. A API permite criar, atualizar, listar e excluir produtos, bem como autenticar e autorizar usuários usando o JWT.

## Dependências
1- .NET 7.0 SDK.

2- Entity Framework Core.

3- JWT (JSON Web Tokens).

4- Swashbuckle.AspNetCore.

## Endpoints
A API possui os seguintes endpoints:

1- POST /api/produtos: Cria um novo produto com nome, descrição e preço.

2- PUT /api/produtos/{id}: Atualiza um produto existente com nome, descrição e preço.

3- GET /api/produtos: Lista todos os produtos existentes.

4- GET /api/produtos/{id}: Retorna um produto específico pelo ID.

5- DELETE /api/produtos/{id}: Exclui um produto pelo ID.

6- POST /api/auth/login: Autentica um usuário e retorna um token JWT.

## Autenticação e Autorização

A API utiliza o JWT para autenticar e autorizar usuários. Apenas usuários autenticados podem criar, editar, visualizar e excluir produtos.

Para obter um token JWT, os usuários devem fazer uma solicitação POST para o endpoint /api/auth/login, fornecendo suas credenciais (nome de usuário e senha). Se as credenciais estiverem corretas, a API retornará um token JWT que deve ser incluído no cabeçalho Authorization das solicitações subsequentes.



