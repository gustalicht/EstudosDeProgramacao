# APIs REST - Guia Detalhado

## O que e REST?
REST e um estilo para criar APIs usando HTTP.
Cada recurso tem uma URL e voce usa os metodos HTTP para agir nele.

## Metodos principais
- **GET**: ler
- **POST**: criar
- **PUT/PATCH**: atualizar
- **DELETE**: remover

## Respostas (status codes)
- 200 OK
- 201 Created
- 400 Bad Request
- 404 Not Found
- 500 Server Error

## Fluxo basico (passo a passo)
1. Cliente envia requisicao HTTP.
2. Controller recebe e valida.
3. Service executa a regra.
4. Repositorio acessa dados.
5. Controller retorna resposta JSON.

## Pastas aqui
- TodoApi (API simples com EF InMemory)
- ApiWebRest (Razor Pages)
- ApiBlazor (Blazor Server)

## Exercicios
1. Criar um endpoint GET.
2. Criar POST com validacao.
