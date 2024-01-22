# JobsApi


API RESTful para uma lista de empregos. A API permite que os usuários visualizem, criem, atualizem e excluam anúncios de emprego.


## Endpoints

- GET /jobs: retorna uma lista de todos os anúncios de emprego disponíveis
- GET /jobs/{id}: retorna um único anúncio de emprego com o ID correspondente
- POST /jobs: cria um novo anúncio de emprego
- PUT /jobs/{id}: atualiza um anúncio de emprego existente com o ID correspondente
- DELETE /jobs/{id}: exclui um anúncio de emprego existente com o ID
correspondente

## Entidades
- Job
    - Id: int (gerado automaticamente pelo servidor)
    - Title: string (título do anúncio de emprego)
    - Description: string (descrição do anúncio de emprego)
    - Location: string (localização do trabalho)
    - Salary: decimal (salário oferecido)


## Tech

- A API foi desenvolvida usando ASP.NET Core utilizando .NET 8.
- Foi utilizado o banco de dados InMemory com Entity Framework Core.
- Possui as operações CRUD básicas e retorno de respostas HTTP apropriadas (ex: 200 OK, 404 Not Found, etc.).
- Os dados enviados e recebidos são formatados como JSON.
