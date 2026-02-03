using System;
using System.Collections.Generic;
using System.Linq;

// ======================================================
// OBJETIVO
// Agrupar palavras que sao anagramas.
// ======================================================

// PASSO A PASSO
// 1) Para cada palavra, ordenar as letras.
// 2) Usar a palavra ordenada como chave.
// 3) Agrupar no Dictionary.

static Dictionary<string, List<string>> AgruparAnagramas(string[] palavras)
{
    var grupos = new Dictionary<string, List<string>>();

    foreach (var palavra in palavras)
    {
        var chave = new string(palavra.OrderBy(c => c).ToArray());

        if (!grupos.ContainsKey(chave))
            grupos[chave] = new List<string>();

        grupos[chave].Add(palavra);
    }

    return grupos;
}

// ===================
// EXEMPLO
// ===================
string[] dados = { "roma", "amor", "carro", "arco", "cora" };
var grupos = AgruparAnagramas(dados);

foreach (var grupo in grupos.Values)
    Console.WriteLine($"[{string.Join(", ", grupo)}]");

// DESAFIO
// 1) Ignorar maiusculas/minusculas.
// 2) Remover palavras repetidas antes de agrupar.
