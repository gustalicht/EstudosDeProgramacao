# APIs REST - Guia Profundo (Sem Resumo)

## O que e REST?
REST e um estilo de arquitetura para APIs usando HTTP. Cada recurso tem uma URL e voce usa metodos HTTP para operar sobre ele.

------------------------------------------------------------

## Como desenhar recursos (passo a passo)
1. Identifique o recurso principal (ex: tarefas = /todos).
2. Use plural para colecoes (ex: /users).
3. Use `/id` para um item especifico (ex: /users/10).
4. Evite verbos na URL (use o metodo HTTP).

------------------------------------------------------------

## Metodos HTTP e comportamento correto
- **GET**: ler (nao altera estado)
- **POST**: criar
- **PUT**: substituir
- **PATCH**: atualizar parcialmente
- **DELETE**: remover

### Idempotencia
- GET, PUT, DELETE sao idempotentes.
- POST nao e idempotente.

------------------------------------------------------------

## Status codes (o minimo que voce deve dominar)
- 200 OK
- 201 Created
- 204 No Content
- 400 Bad Request
- 401 Unauthorized
- 403 Forbidden
- 404 Not Found
- 409 Conflict
- 422 Unprocessable Entity
- 500 Internal Server Error

------------------------------------------------------------

## Corpo da resposta (JSON padrao)
Exemplo de sucesso:
```json
{ "id": 1, "name": "Tarefa" }
```

Exemplo de erro:
```json
{ "error": "Mensagem clara" }
```

------------------------------------------------------------

## Paginacao, filtro e ordenacao
- `GET /items?page=1&pageSize=10`
- `GET /items?status=done&sort=createdAt`

------------------------------------------------------------

## Versionamento
- URL: `/v1/items`
- Header: `Accept: application/vnd.minhaapi.v1+json`

------------------------------------------------------------

## Seguranca basica
- Validar entrada.
- Autenticacao (JWT).
- Autorizacao (roles, claims).

------------------------------------------------------------

## O que um senior presta atencao
- Logs estruturados
- Respostas consistentes
- Observabilidade
- Performance
- Rate limiting

------------------------------------------------------------

## Onde estudar aqui
- `TodoApi`: CRUD basico com EF InMemory
- `ApiWebRest`: Razor Pages
- `ApiBlazor`: UI com C#

------------------------------------------------------------

## Exercicios
1. Criar um endpoint GET que aceita filtro.
2. Criar POST com validacao.
3. Criar PUT idempotente.
4. Criar paginação.
