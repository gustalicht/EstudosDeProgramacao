using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Calcular uniao e intersecao de dois conjuntos.
// ======================================================

// PASSO A PASSO
// 1) Criar HashSet com o primeiro conjunto.
// 2) Para uniao: adicionar todos do segundo.
// 3) Para intersecao: copiar e manter so os comuns.

static HashSet<int> Uniao(HashSet<int> a, HashSet<int> b)
{
    var resultado = new HashSet<int>(a);
    resultado.UnionWith(b);
    return resultado;
}

static HashSet<int> Intersecao(HashSet<int> a, HashSet<int> b)
{
    var resultado = new HashSet<int>(a);
    resultado.IntersectWith(b);
    return resultado;
}

// ===================
// EXEMPLO
// ===================
var conjuntoA = new HashSet<int> { 1, 2, 3, 4 };
var conjuntoB = new HashSet<int> { 3, 4, 5, 6 };

Console.WriteLine($"Uniao: {string.Join(", ", Uniao(conjuntoA, conjuntoB))}");
Console.WriteLine($"Intersecao: {string.Join(", ", Intersecao(conjuntoA, conjuntoB))}");

// DESAFIO
// 1) Calcular diferenca (A - B).
// 2) Verificar se dois conjuntos sao iguais.
