using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Agrupar itens por categoria.
// ======================================================

// PASSO A PASSO
// 1) Criar um Dictionary onde a chave e a categoria.
// 2) Para cada item, verificar se a categoria ja existe.
// 3) Se nao existir, criar a lista.
// 4) Adicionar o item na lista.

static Dictionary<string, List<string>> AgruparPorCategoria((string item, string categoria)[] dados)
{
    var grupos = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

    foreach (var (item, categoria) in dados)
    {
        if (!grupos.ContainsKey(categoria))
            grupos[categoria] = new List<string>();

        grupos[categoria].Add(item);
    }

    return grupos;
}

// ===================
// EXEMPLO
// ===================
var itens = new (string, string)[]
{
    ("Banana", "Fruta"),
    ("Macarrao", "Massa"),
    ("Maca", "Fruta"),
    ("Pao", "Padaria")
};

var grupos = AgruparPorCategoria(itens);
foreach (var g in grupos)
{
    Console.WriteLine($"{g.Key}: {string.Join(", ", g.Value)}");
}

// DESAFIO
// 1) Ordenar as categorias por nome.
// 2) Contar quantos itens existem em cada categoria.
