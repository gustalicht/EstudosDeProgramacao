# Backend - Guia Detalhado

## O que e backend?
Backend e a parte do sistema que roda no servidor. Ele recebe requisicoes, aplica regras de negocio, conversa com banco de dados e devolve respostas.

## O que o backend costuma fazer?
- Receber dados do frontend (HTTP, WebSocket, filas).
- Validar e aplicar regras.
- Salvar e buscar dados.
- Integrar com outros servicos.

## Como pensar um backend (passo a passo)
1. Defina as rotas (endpoints) e o que cada uma faz.
2. Modele os dados (entidades/DTOs).
3. Implemente a logica (servicos/handlers).
4. Persista os dados (banco ou memoria).
5. Responda com status e JSON.

## Pastas desta secao
- APIs GraphQL
- Apis Rest (TodoApi, ApiWebRest, ApiBlazor)
- RabbitMq

## Dica
Comece com um CRUD simples e evolua.
