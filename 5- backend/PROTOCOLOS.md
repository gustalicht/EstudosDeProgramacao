# Protocolos e Fundamentos de Rede para Backend

## 1) DNS (Domain Name System)
### O que e?
Traduz nomes (ex: api.meusite.com) para IPs (ex: 142.250.x.x).

### Passo a passo (simples)
1. Cliente pergunta ao DNS local.
2. Se nao sabe, pergunta a servidores raiz.
3. Caminha ate o servidor autoritativo.
4. Recebe o IP e cacheia.

### Por que importa?
- Latencia inicial.
- Failover de dominios.

------------------------------------------------------------

## 2) TCP vs UDP
### TCP
- Confiavel, ordenado, com handshake.
- Usado por HTTP/HTTPS.

### UDP
- Rapido, sem garantia.
- Usado por streaming, jogos.

------------------------------------------------------------

## 3) HTTP/HTTPS (fundamental)

### HTTP = protocolo de aplicacao
- Cliente envia request.
- Servidor responde response.

### Componentes de uma request
- Metodo: GET, POST, PUT, DELETE
- URL
- Headers
- Body (JSON, etc.)

### Componentes da response
- Status code
- Headers
- Body

### Status codes importantes
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

### HTTPS
- HTTP + TLS (criptografia)
- Garante confidencialidade e integridade

------------------------------------------------------------

## 4) REST

### Conceito
API baseada em recursos (URI) + verbos HTTP.

### Exemplo
- GET /users
- POST /users
- GET /users/10
- PUT /users/10
- DELETE /users/10

### Ponto de senior
- Idempotencia
- Versionamento
- Paginacao e filtro

------------------------------------------------------------

## 5) GraphQL

### Conceito
O cliente escolhe o que quer.

### Quando usar
- Muitas combinacoes de dados
- Frontend com necessidade flexivel

------------------------------------------------------------

## 6) gRPC

### Conceito
RPC baseado em Protobuf.

### Quando usar
- Microservicos internos
- Baixa latencia

------------------------------------------------------------

## 7) WebSocket

### Conceito
Conexao persistente, full-duplex.

### Quando usar
- Chat em tempo real
- Dashboard ao vivo

------------------------------------------------------------

## 8) SSE (Server-Sent Events)

### Conceito
Servidor envia eventos em fluxo unidirecional.

### Quando usar
- Atualizacoes ao vivo (sem bidirecionalidade)

------------------------------------------------------------

## 9) AMQP (RabbitMQ)

### Conceito
Mensageria baseada em filas.

### Quando usar
- Processamento assincrono
- Integracao entre sistemas

------------------------------------------------------------

## 10) Serializacao (JSON / Protobuf)

### JSON
- Humano legivel, mais pesado.

### Protobuf
- Compacto, rapido, binario.

------------------------------------------------------------

## Desafios
1. Criar um servidor HTTP simples e inspecionar headers.
2. Criar um exemplo de WebSocket (mensagem ida e volta).
3. Criar uma fila com RabbitMQ e medir latencia.
