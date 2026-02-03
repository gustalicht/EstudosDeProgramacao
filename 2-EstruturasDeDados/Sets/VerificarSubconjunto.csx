using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Verificar se um conjunto B e subconjunto de A.
// ======================================================

// PASSO A PASSO
// 1) Criar HashSet de A.
// 2) Usar IsSubsetOf para verificar.

static bool EhSubconjunto(HashSet<int> a, HashSet<int> b)
{
    return b.IsSubsetOf(a);
}

// ===================
// EXEMPLO
// ===================
var A = new HashSet<int> { 1, 2, 3, 4, 5 };
var B = new HashSet<int> { 2, 3 };
var C = new HashSet<int> { 2, 6 };

Console.WriteLine(EhSubconjunto(A, B)); // true
Console.WriteLine(EhSubconjunto(A, C)); // false

// DESAFIO
// 1) Verificar se dois conjuntos sao disjuntos.
// 2) Verificar se um conjunto e superconjunto de outro.
