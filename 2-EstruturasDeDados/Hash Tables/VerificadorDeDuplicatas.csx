using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Verificar se um array possui duplicatas.
// ======================================================

// PASSO A PASSO
// 1) Criar HashSet para guardar valores vistos.
// 2) Percorrer o array.
// 3) Se Add retornar false, ja era duplicata.

static bool TemDuplicatas(int[] numeros)
{
    var vistos = new HashSet<int>();

    foreach (var n in numeros)
    {
        if (!vistos.Add(n))
            return true; // duplicata encontrada
    }

    return false;
}

// ===================
// EXEMPLO
// ===================
int[] a = { 1, 2, 3, 4 };
int[] b = { 1, 2, 2, 3 };

Console.WriteLine(TemDuplicatas(a)); // false
Console.WriteLine(TemDuplicatas(b)); // true

// DESAFIO
// 1) Retornar quais numeros sao duplicados.
// 2) Fazer o mesmo com strings.
