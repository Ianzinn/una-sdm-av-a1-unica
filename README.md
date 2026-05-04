# ValeAtivos324153108 — Avaliação A1

**Aluno:** Ian Pedro Barbosa de Santana  
**Professor:** Daniel Henrique Matos de Paiva  
**Data:** 04/05/2026

## Sobre o Projeto

API REST desenvolvida em ASP.NET Core para gerenciamento de equipamentos (ativos) da Vale, utilizando SQLite como banco de dados e Entity Framework Core como ORM. O projeto foi construído como parte da Avaliação A1 da disciplina Sistemas distribuidos e Mobile.




## Endpoints

`POST`   | `/api/equipamentos`     | Cadastra um novo equipamento     |
`GET`    | `/api/equipamentos`     | Lista todos os equipamentos      |
`GET`    | `/api/equipamentos/{id}`| Busca equipamento por ID         |
`PUT`    | `/api/equipamentos/{id}`| Atualiza um equipamento          |
`DELETE` | `/api/equipamentos/{id}`| Remove um equipamento            |

## Como Executar

**Pré-requisitos:** .NET 9 SDK instalado.


A API estará disponível em `https://localhost:{porta}`.  
O Swagger UI pode ser acessado em `https://localhost:{porta}/swagger`.

## Exemplo de Requisição

```json
POST /api/equipamentos
{
    "id": 2,
    "nome": "Carregador de Navios CN-01",
    "tipo": "Porto",
    "localizacao": "Porto de Tubarão",
    "capacidadeProcessamento": 36,
    "dataUltimaManutencao": "2025-12-20T00:00:00",
    "emOperacao": true
}
```
