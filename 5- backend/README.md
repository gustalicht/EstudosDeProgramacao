# Backend - Guia Profundo (Sem Resumo)

## O que e backend (definicao precisa)
Backend e a parte do software que recebe requisicoes, aplica regras de negocio, acessa dados e devolve respostas. Ele lida com:
- Protocolo de comunicacao (HTTP, WebSocket, filas)
- Validacao e regras
- Persistencia (banco, cache, arquivos)
- Observabilidade (logs, metricas, tracing)
- Seguranca (autenticacao, autorizacao)

## Como pensar backend como profissional

### 1) Entrada
Tudo comeca com um sinal externo:
- Requisicao HTTP
- Mensagem em fila
- Evento (webhook)

### 2) Validacao
Antes de processar, validar:
- Tipos e formatos
- Regras (ex: campo obrigatorio)
- Permissao

### 3) Regras de negocio
Aqui mora o "valor" do backend. Regra clara, separada e testavel.

### 4) Persistencia
- Banco relacional (SQL) ou NoSQL
- Transacoes
- Consistencia

### 5) Resposta
- Status code correto
- JSON limpo
- Mensagens de erro padronizadas

## Protocolos que voce precisa dominar (resumo completo)
- **HTTP/HTTPS**: verbos, headers, status, TLS, cache, CORS
- **TCP/UDP**: confiabilidade vs latencia
- **DNS**: como nome vira IP
- **REST**: recursos e verbs
- **GraphQL**: queries e schema
- **gRPC**: protobuf e streaming
- **WebSocket**: conexao persistente
- **AMQP**: mensageria (RabbitMQ)
- **SSE**: streaming unidirecional

Veja: `5- backend/PROTOCOLOS.md`

## Estrutura tipica de um backend profissional
- Controllers (entrada HTTP)
- Services (regras)
- Repositories (dados)
- DTOs (contratos)
- Middlewares (cross-cutting)

## Fluxo real de uma requisicao HTTP
1. DNS resolve o dominio.
2. Cliente abre conexao TCP.
3. TLS handshake (HTTPS).
4. HTTP request e enviada.
5. Servidor parseia headers e body.
6. Pipeline de middlewares executa.
7. Controller recebe e chama service.
8. Service chama repository.
9. Repository executa SQL/ORM.
10. Resposta volta com status code.

## Erros comuns (que senior evita)
- Retornar 200 para erro.
- Expor campos internos no DTO.
- Misturar regra de negocio no controller.
- Sem testes de integracao.
- Sem logs com contexto.

## O que um senior domina
- Design de API
- Performance (cache, batch, indices)
- Observabilidade
- Seguranca
- Confiabilidade (retries, timeouts)
- Escalabilidade

## Onde estudar no repo
- REST: `5- backend/Apis Rest`
- GraphQL: `5- backend/APIs GraphQL`
- Mensageria: `5- backend/RabbitMq`

## Proximo passo
Leia o guia completo de protocolos e o guia de API do zero.
