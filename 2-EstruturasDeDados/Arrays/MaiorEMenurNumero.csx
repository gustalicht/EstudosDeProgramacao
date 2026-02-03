using System;
using System.Linq;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Encontrar o maior e o menor numero de um array.
// ======================================================

// PASSO A PASSO (loop)
// 1) Assumir que o primeiro elemento e o maior e o menor.
//    Motivo: precisamos de um valor inicial valido.
// 2) Percorrer do segundo elemento em diante.
// 3) Atualizar maior/menor quando encontrar valores melhores.

static (int maior, int menor) MaiorMenorLoop(int[] numeros)
{
    if (numeros == null || numeros.Length == 0)
        throw new ArgumentException("Array vazio");

    int maior = numeros[0];
    int menor = numeros[0];

    for (int i = 1; i < numeros.Length; i++)
    {
        if (numeros[i] > maior)
            maior = numeros[i];

        if (numeros[i] < menor)
            menor = numeros[i];
    }

    return (maior, menor);
}

// PASSO A PASSO (LINQ)
// 1) Usar metodos prontos Max e Min.
// 2) Mais curto, mas esconde o loop interno.

static (int maior, int menor) MaiorMenorLinq(int[] numeros)
{
    if (numeros == null || numeros.Length == 0)
        throw new ArgumentException("Array vazio");

    return (numeros.Max(), numeros.Min());
}

// ===================
// EXEMPLO
// ===================
int[] valores = { 4, 12, 1, 8, 7, 15, 2 };

var resultado1 = MaiorMenorLoop(valores);
Console.WriteLine($"Loop -> Maior: {resultado1.maior}, Menor: {resultado1.menor}");

var resultado2 = MaiorMenorLinq(valores);
Console.WriteLine($"LINQ -> Maior: {resultado2.maior}, Menor: {resultado2.menor}");

// DESAFIO
// 1) Implementar a versao recursiva.
// 2) Encontrar maior/menor sem usar Max/Min.
