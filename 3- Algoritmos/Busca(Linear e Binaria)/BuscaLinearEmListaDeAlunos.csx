using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Implementar busca linear em uma lista de alunos.
// ======================================================

// PASSO A PASSO
// 1) Percorrer a lista do inicio ao fim.
// 2) Comparar cada nome com o alvo.
// 3) Se encontrar, retornar a posicao.

static int BuscaLinear(List<string> alunos, string alvo)
{
    for (int i = 0; i < alunos.Count; i++)
    {
        if (string.Equals(alunos[i], alvo, StringComparison.OrdinalIgnoreCase))
            return i;
    }

    return -1; // nao encontrado
}

// ===================
// EXEMPLO
// ===================
var alunos = new List<string> { "Ana", "Bruno", "Carlos", "Diana" };

Console.WriteLine(BuscaLinear(alunos, "Carlos")); // 2
Console.WriteLine(BuscaLinear(alunos, "Pedro"));  // -1

// DESAFIO
// 1) Retornar o nome e a posicao.
// 2) Contar quantas comparacoes foram feitas.
