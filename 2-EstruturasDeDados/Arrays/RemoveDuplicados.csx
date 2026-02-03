using System;
using System.Collections.Generic;
using System.Linq;

// ======================================================
// OBJETIVO
// Remover elementos duplicados de um array.
// ======================================================

// PASSO A PASSO (HashSet)
// 1) Criar um HashSet para guardar os valores ja vistos.
// 2) Percorrer o array original.
// 3) Se o valor ainda nao existe no set, adicionar no resultado.

static int[] RemoverDuplicados(int[] numeros)
{
    var vistos = new HashSet<int>();
    var resultado = new List<int>();

    foreach (var n in numeros)
    {
        if (vistos.Add(n)) // Add retorna true se for novo
            resultado.Add(n);
    }

    return resultado.ToArray();
}

// PASSO A PASSO (LINQ)
// 1) Distinct remove duplicados.
// 2) ToArray para voltar a array.

static int[] RemoverDuplicadosLinq(int[] numeros)
{
    return numeros.Distinct().ToArray();
}

// ===================
// EXEMPLO
// ===================
int[] dados = { 1, 2, 2, 3, 3, 3, 4 };

var a = RemoverDuplicados(dados);
Console.WriteLine(string.Join(", ", a));

var b = RemoverDuplicadosLinq(dados);
Console.WriteLine(string.Join(", ", b));

// DESAFIO
// 1) Manter a ordem original sem usar LINQ.
// 2) Contar quantas vezes cada numero apareceu (use Dictionary).
