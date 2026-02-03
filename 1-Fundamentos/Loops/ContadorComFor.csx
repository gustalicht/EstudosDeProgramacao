using System;

// ======================================================
// OBJETIVO
// Treinar o uso do loop FOR para repetir uma acao
// um numero conhecido de vezes.
//
// PASSO A PASSO
// 1) Criar um contador iniciando em 1.
// 2) Executar o bloco enquanto o contador <= 10.
// 3) Imprimir o valor atual.
// 4) Incrementar o contador.
// ======================================================

Console.WriteLine("Contador com for");

for (int i = 1; i <= 10; i++)
{
    // Aqui mostramos o valor atual do contador
    Console.WriteLine($"Contador: {i}");
}

// POR QUE USAR FOR?
// - Quando sabemos exatamente quantas repeticoes queremos.
// - A estrutura fica organizada: inicio, condicao, incremento.

// DESAFIOS
// 1) Conte de 10 ate 1.
// 2) Conte apenas numeros pares.
