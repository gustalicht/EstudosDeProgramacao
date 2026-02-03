using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Criar um grafo usando lista de adjacencia.
// ======================================================

// PASSO A PASSO
// 1) Usar Dictionary<int, List<int>>.
// 2) Cada chave e um vertice.
// 3) A lista guarda seus vizinhos.

class Grafo
{
    private readonly Dictionary<int, List<int>> _adj = new Dictionary<int, List<int>>();

    public void AdicionarAresta(int u, int v, bool bidirecional = true)
    {
        if (!_adj.ContainsKey(u)) _adj[u] = new List<int>();
        _adj[u].Add(v);

        if (bidirecional)
        {
            if (!_adj.ContainsKey(v)) _adj[v] = new List<int>();
            _adj[v].Add(u);
        }
    }

    public void Imprimir()
    {
        foreach (var par in _adj)
        {
            Console.WriteLine($"{par.Key} -> {string.Join(", ", par.Value)}");
        }
    }
}

// ===================
// EXEMPLO
// ===================
var g = new Grafo();
g.AdicionarAresta(1, 2);
g.AdicionarAresta(1, 3);
g.AdicionarAresta(2, 4);

g.Imprimir();

// DESAFIO
// 1) Implementar aresta direcionada.
// 2) Remover aresta.
