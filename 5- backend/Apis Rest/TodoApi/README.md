# TodoApi - Guia Profundo (Sem Resumo)

## Objetivo
Ensinar como uma API REST funciona do inicio ao fim usando um exemplo simples (tarefas).

------------------------------------------------------------

## Estrutura de pastas (o que cada parte faz)
- `Program.cs`: configura o servidor e o pipeline HTTP.
- `Controllers/`: endpoints da API (rotas).
- `Models/`: entidades, DTOs e DbContext.
- `TodoApi.http`: exemplos de requisicoes.

------------------------------------------------------------

## Fluxo de uma requisicao (passo a passo)
1. Cliente envia `POST /api/todoitems`.
2. ASP.NET recebe e faz model binding (JSON -> objeto).
3. Controller cria entidade.
4. DbContext salva no banco em memoria.
5. API retorna `201 Created` com o item.

------------------------------------------------------------

## O que e DTO e por que usar?
DTO (Data Transfer Object) evita expor campos sensiveis.
Exemplo: `TodoItem` tem `Secret`, mas o DTO nao expõe.

------------------------------------------------------------

## Arquivos principais explicados

### 1) `Models/TodoItem.cs`
- Representa a entidade no banco.

### 2) `Models/TodoItemDTO.cs`
- Representa o que sai/entra da API.

### 3) `Models/TodoContext.cs`
- DbContext do EF Core.
- Define `DbSet<TodoItem>`.

### 4) `Controllers/TodoItemsController.cs`
- Endpoints CRUD:
  - GET /api/todoitems
  - GET /api/todoitems/{id}
  - POST /api/todoitems
  - PUT /api/todoitems/{id}
  - DELETE /api/todoitems/{id}

------------------------------------------------------------

## Como criar uma API igual do zero (resumo pratico)
1. `dotnet new webapi`
2. Criar Model.
3. Criar DTO.
4. Criar DbContext.
5. Criar Controller.
6. Testar no Swagger.

Veja o guia completo: `5- backend/GUIA_API_DO_ZERO.md`

------------------------------------------------------------

## Como rodar
```bash
dotnet run
```
Abra `http://localhost:xxxx/swagger`.

------------------------------------------------------------

## Exercicios (nivel junior -> pleno)
1. Validar campo Name (nao vazio).
2. Criar endpoint PATCH para marcar completa.
3. Implementar paginação no GET.
4. Adicionar ordenacao e filtro.
5. Adicionar autenticação simples.

## Exercicios (nivel senior)
1. Trocar InMemory por SQL real.
2. Adicionar migrations.
3. Criar testes de integracao.
4. Criar logs estruturados.
5. Implementar rate limiting.
