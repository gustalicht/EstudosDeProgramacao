# RabbitMQ - Guia Detalhado

## O que e RabbitMQ?
RabbitMQ e um broker de mensagens. Ele permite que sistemas se comuniquem usando filas.

## Conceitos basicos
- **Producer**: envia mensagem.
- **Queue**: fila que guarda mensagens.
- **Consumer**: recebe mensagens.

## Modelo mental (passo a passo)
1. Producer publica mensagem.
2. Broker guarda na fila.
3. Consumer pega da fila.
4. Consumer confirma (ack).

## Pastas
- Send: produtor simples
- Receive: consumidor simples
- NewTask/Worker: fila duravel com ack

## Exercicios
1. Criar fila duravel.
2. Criar varios consumers.
