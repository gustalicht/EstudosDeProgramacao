# RabbitMQ - Worker (Consumer duravel)

## O que faz?
Consome mensagens da fila "task_queue" e confirma quando termina.

## Passo a passo
1. Declarar fila duravel.
2. Definir prefetch (um por vez).
3. Processar e dar ack.

## Exercicios
1. Criar dois workers e ver balanceamento.
2. Simular erro e reprocessar.
