# TodoApi - Guia Detalhado

## O que e este projeto?
Uma API REST simples para gerenciar tarefas (Todo). Usa EF Core com banco em memoria.

## Estrutura basica
- **Program.cs**: configura a aplicacao.
- **Controllers/**: define endpoints.
- **Models/**: entidades e DTOs.
- **TodoApi.http**: exemplos de requisicao.

## Fluxo de uma requisicao (passo a passo)
1. Cliente faz POST /api/todoitems.
2. Controller recebe DTO.
3. Controller cria entidade.
4. DbContext salva no banco em memoria.
5. Retorna 201 Created.

## O que e um DTO?
DTO e um objeto simples usado para trafegar dados, evitando expor campos internos.

## Como rodar
1. `dotnet run`
2. Acessar /swagger
3. Testar endpoints.

## Exercicios
1. Adicionar validacao para Name.
2. Criar endpoint para marcar todas como completas.
