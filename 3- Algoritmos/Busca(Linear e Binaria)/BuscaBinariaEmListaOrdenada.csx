using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Implementar busca binaria em um array ORDENADO.
// ======================================================

// PASSO A PASSO (iterativo)
// 1) Definir inicio = 0 e fim = ultimo indice.
// 2) Calcular meio.
// 3) Comparar o meio com o alvo.
// 4) Ajustar inicio/fim.
// 5) Repetir ate encontrar ou acabar.

static int BuscaBinaria(int[] numeros, int alvo)
{
    int inicio = 0;
    int fim = numeros.Length - 1;

    while (inicio <= fim)
    {
        int meio = inicio + (fim - inicio) / 2; // evita overflow

        if (numeros[meio] == alvo)
            return meio;

        if (alvo < numeros[meio])
            fim = meio - 1;
        else
            inicio = meio + 1;
    }

    return -1; // nao encontrado
}

// ===================
// EXEMPLO
// ===================
int[] dados = { 1, 3, 5, 7, 9, 11, 13 };

Console.WriteLine(BuscaBinaria(dados, 7));  // indice 3
Console.WriteLine(BuscaBinaria(dados, 2));  // -1

// DESAFIO
// 1) Implementar a versao recursiva.
// 2) Adaptar para lista de strings ordenada.
