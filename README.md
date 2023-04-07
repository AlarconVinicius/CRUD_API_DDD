# CRUD_API_DDD
# Documentação de API CRUD DDD

Esta API é uma aplicação desenvolvida com o framework .NET Core 6 e segue os conceitos de Domain Driven Design (DDD), com o objetivo de permitir a gestão de produtos e categorias cadastrados no sistema. O DDD é uma abordagem de desenvolvimento de software que busca modelar o domínio do negócio de forma clara e expressiva, facilitando a evolução e manutenção da aplicação. Através das API's de Produtos e Categorias, é possível realizar operações como cadastro, atualização, exclusão e consulta de usuários (C.R.U.D.), por meio de endpoints HTTP bem definidos e com respostas padronizadas.

## Produtos
### Endpoints

* **GET /produtos**

    Retorna uma lista de todos os produtos cadastrados no sistema com status ativo.

* **POST /produtos**

    Cria um novo produto com as informações fornecidas.

* **PUT /produtos**

    Atualiza um produto específico.


### Retornos

* **GET /produtos**

    Retorna uma lista de objetos de produto no seguinte formato:

    ```json
        [
            {
                "id": "29740AE1-485E-4477-98BD-8AF547F4BB3E",
                "nome": "Produto 1",
                "categoria": "Category 1",
                "status": "Ativo",
                "statusNum": "1",
                "dataCriacao": "2022-03-01T10:00:00Z",
                "dataAtualizacao": "2022-03-01T10:00:00Z"
            },
            {
                "id": "835EB349-E6EB-4E15-A153-59C45FFBD447",
                "nome": "Produto 2",
                "categoria": "Category 2",
                "status": "Ativo",
                "statusNum": "1",
                "dataCriacao": "2022-03-01T10:00:00Z",
                "dataAtualizacao": "2022-03-01T10:00:00Z"
            }
        ]
    ```
    
* **PUT /produtos**

    Retorna um objeto de produto atualizado no seguinte formato:

    ```json
        {
            "id": "835EB349-E6EB-4E15-A153-59C45FFBD447",
            "nome": "Produto Upd",
            "categoriaId": "043E4700-B2FC-4D37-A667-EDFF833A2F17",
            "statusNum": "2"
        }
    ```
    
* **POST /produtos**

    Retorna um objeto de produto criado no seguinte formato (por padrão o status é setado como ativo):

    ```json
        {
            "id": "22AE209B-3975-489A-9D66-4BC4B7192025",
            "nome": "Produto 3",
            "categoriaId": "9EC34CD3-5D36-4F8D-BBE0-21ED1CC431AA"
        }
    ```
    
## Categorias
### Endpoints

* **GET /categorias**

    Retorna uma lista de todas as categorias cadastradas no sistema.

* **POST /categorias**

    Cria uma nova categoria com as informções fornecidas.

* **PUT /categorias**

    Atualiza uma categoria específica.

* **DELETE /categorias**

    Exclui uma categoria específica.

### Retornos

* **GET /categorias**

    Retorna uma lista de objetos de categoria no seguinte formato:

    ```json
        [
            {
                "id": "E3585C2D-586C-4528-96FC-E8FC0E3622A9",
                "nome": "Category 1",
                "dataCriacao": "2022-03-01T10:00:00Z",
                "dataAtualizacao": "2022-03-01T10:00:00Z"
            },
            {
                "id": "E56B7980-B297-4487-81ED-BF33198FD580",
                "name": "Category 2",
                "dataCriacao": "2022-03-01T10:00:00Z",
                "dataAtualizacao": "2022-03-01T10:00:00Z"
            }
        ]
    ```


* **PUT /categorias**

    Retorna um objeto de categoria atualizada no seguinte formato:

    ```json
        {
            "id": "E56B7980-B297-4487-81ED-BF33198FD580",
            "nome": "Category Upd"
        }
    ```
    
* **POST /categorias**

    Retorna um objeto de categoria criada no seguinte formato:

    ```json
        {
            "id": 3,
            "nome": "Category 3"
        }
    ```

* **DELETE /categorias**
    
    ```json
        {
            "id": "E3585C2D-586C-4528-96FC-E8FC0E3622A9",
            "nome": "Category 1",
            "dataCriacao": "2022-03-01T10:00:00Z",
            "dataAtualizacao": "2022-03-01T10:00:00Z"
        }
    ```

    Retorna um status de sucesso (204 - No Content) se a categoria foi excluída com sucesso.

## Clonando e Testando a Aplicação

Você pode clonar e testar a API de Usuários na sua própria máquina seguindo estes passos:

1. Abra o terminal na sua máquina e navegue até o diretório onde deseja armazenar a aplicação.

2. Execute o seguinte comando para clonar o repositório da aplicação:

    ```bash
    git clone https://github.com/AlarconVinicius/CRUD_API_DDD.git
    ```

3. Navegue até o diretório raiz da aplicação:

    ```bash
    cd api-usuarios
    ```
4. Execute o seguinte comando para instalar as dependências da aplicação:

    ```bash
    dotnet restore
    ```

5. Execute o seguinte comando para compilar a aplicação:

    ```bash
    dotnet build
    ```

6. Execute o seguinte comando para rodar a aplicação:

    ```bash
    dotnet run
    ```

A aplicação deverá estar sendo executada na porta 7203.

Abra o navegador e acesse a URL http://localhost:7203/produtos para testar o endpoint GET /produtos e verificar se a aplicação está funcionando corretamente.
