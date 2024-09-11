
# InventoryManagementAPI

Este projeto é uma simples API de gerenciamento de inventário desenvolvida em .NET, criada para permitir o controle de produtos, categorias e estoque. A API é flexível, podendo ser integrada a outros sistemas e expandida para atender às necessidades de diferentes tipos de negócios.

## Sumário

- [Tecnologias](#tecnologias)
- [Recursos](#recursos)
- [Como Usar](#como-usar)
- [Configurações do Projeto](#configurações-do-projeto)
- [Rotas](#rotas)
- [Contribuições](#contribuições)
- [Licença](#licença)

## Tecnologias

- .NET
- MongoDB (como banco de dados)
- Swagger (documentação da API)

## Recursos

- Gerenciamento de produtos e categorias
- Controle de estoque
- Operações CRUD (Create, Read, Update, Delete) para produtos e categorias
- Documentação via Swagger

## Como Usar

1. Clone o repositório:

   ```bash
   git clone https://github.com/eliasprates/InventoryManagementAPI.git
   ```

2. Navegue até o diretório do projeto:

   ```bash
   cd InventoryManagementAPI
   ```

3. Configure as variáveis de ambiente para conexão com o MongoDB e JWT, ou ajuste o arquivo `appsettings.json` conforme suas necessidades.

4. Restaure as dependências do projeto:

   ```bash
   dotnet restore
   ```

5. Compile o projeto:

   ```bash
   dotnet build
   ```

6. Execute a aplicação:

   ```bash
   dotnet run
   ```

7. Acesse a documentação do Swagger em `https://localhost:5001/swagger` para testar as rotas disponíveis.

## Configurações do Projeto

No arquivo `appsettings.json`, você pode configurar a conexão com o MongoDB:

```json
{
  "MongoDB": {
    "ConnectionString": "mongodb://localhost:27017",
    "DatabaseName": "InventoryDB"
  }
}
```

## Rotas

### Produtos

- **GET** `/api/products` - Retorna todos os produtos
- **GET** `/api/products/{id}` - Retorna um produto específico
- **POST** `/api/products` - Cria um novo produto
- **PUT** `/api/products/{id}` - Atualiza um produto existente
- **DELETE** `/api/products/{id}` - Exclui um produto

### Categorias

- **GET** `/api/categories` - Retorna todas as categorias
- **GET** `/api/categories/{id}` - Retorna uma categoria específica
- **POST** `/api/categories` - Cria uma nova categoria
- **PUT** `/api/categories/{id}` - Atualiza uma categoria existente
- **DELETE** `/api/categories/{id}` - Exclui uma categoria

## Contribuições

Contribuições são bem-vindas! Se você quiser sugerir melhorias ou adicionar novas funcionalidades, sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Licença

Este projeto está licenciado sob a licença Apache 2.0.
