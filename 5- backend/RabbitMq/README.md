# RabbitMQ - Guia Profundo (Sem Resumo)

## O que e RabbitMQ?
RabbitMQ e um broker de mensagens. Ele recebe mensagens de produtores e entrega para consumidores via filas.

------------------------------------------------------------

## Por que usar?
- Desacopla sistemas.
- Permite processamento assincrono.
- Ajuda com picos de carga.

------------------------------------------------------------

## Conceitos principais
- **Producer**: envia mensagem.
- **Queue**: guarda mensagens.
- **Consumer**: recebe mensagem.
- **Exchange**: roteia mensagens.
- **Routing key**: caminho da mensagem.
- **Ack**: confirmacao de processamento.

------------------------------------------------------------

## Fluxo (passo a passo)
1. Producer conecta no broker.
2. Producer publica mensagem.
3. Broker guarda na fila.
4. Consumer pega mensagem.
5. Consumer processa.
6. Consumer envia ack.

------------------------------------------------------------

## Filas duraveis
- Mensagens persistentes sobrevivem a reinicio.
- Necessario marcar fila como durable.

------------------------------------------------------------

## Prefetch (controle de carga)
- Diz quantas mensagens o consumer pega de uma vez.
- Evita sobrecarga.

------------------------------------------------------------

## Erros comuns
- Esquecer de dar ack.
- Marcar fila como durable mas mensagem nao persistente.
- Consumidor lento sem prefetch.

------------------------------------------------------------

## Exercicios
1. Criar dois consumers e ver balanceamento.
2. Simular erro e reprocessar.
3. Criar exchange com routing.
