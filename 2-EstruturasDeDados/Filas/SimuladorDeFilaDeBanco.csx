using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Simular atendimento em uma fila de banco.
// ======================================================

// PASSO A PASSO
// 1) Criar uma Queue.
// 2) Enfileirar clientes.
// 3) Atender (desenfileirar) na ordem.

var filaBanco = new Queue<string>();

filaBanco.Enqueue("Cliente 1");
filaBanco.Enqueue("Cliente 2");
filaBanco.Enqueue("Cliente 3");

Console.WriteLine("Clientes na fila:");
foreach (var cliente in filaBanco)
    Console.WriteLine(cliente);

var atendido = filaBanco.Dequeue();
Console.WriteLine($"\nAtendendo: {atendido}");

Console.WriteLine("Clientes restantes:");
foreach (var cliente in filaBanco)
    Console.WriteLine(cliente);

// DESAFIO
// 1) Adicionar prioridade.
// 2) Simular chegada de novos clientes.
