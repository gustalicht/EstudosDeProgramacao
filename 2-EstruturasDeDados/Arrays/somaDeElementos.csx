using System;
using System.Linq;

// ======================================================
// OBJETIVO
// Somar todos os elementos de um array.
// ======================================================

// PASSO A PASSO (loop)
// 1) Iniciar soma = 0.
// 2) Percorrer o array.
// 3) Somar cada elemento.

static int SomarElementos(int[] numeros)
{
    int soma = 0;
    foreach (var n in numeros)
        soma += n;
    return soma;
}

// PASSO A PASSO (LINQ)
// 1) Usar o metodo Sum.

static int SomarElementosLinq(int[] numeros)
{
    return numeros.Sum();
}

// ===================
// EXEMPLO
// ===================
int[] valores = { 1, 2, 3, 4, 5 };

Console.WriteLine(SomarElementos(valores));
Console.WriteLine(SomarElementosLinq(valores));

// DESAFIO
// 1) Somar apenas numeros pares.
// 2) Calcular a media.
