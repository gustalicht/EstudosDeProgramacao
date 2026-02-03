using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Implementar Dijkstra para menor caminho.
// ======================================================

// PASSO A PASSO
// 1) Guardar distancias iniciais (infinito).
// 2) Comecar pela origem (distancia 0).
// 3) Sempre escolher o no com menor distancia ainda nao visitado.
// 4) Relaxar arestas (tentar melhorar distancias).

var grafo = new Dictionary<string, List<(string destino, int peso)>>
{
    { "A", new List<(string,int)> { ("B", 4), ("C", 2) } },
    { "B", new List<(string,int)> { ("C", 5), ("D", 10) } },
    { "C", new List<(string,int)> { ("E", 3) } },
    { "D", new List<(string,int)> { ("F", 11) } },
    { "E", new List<(string,int)> { ("D", 4) } },
    { "F", new List<(string,int)> { } }
};

static Dictionary<string, int> Dijkstra(Dictionary<string, List<(string destino, int peso)>> g, string origem)
{
    var dist = new Dictionary<string, int>();
    var visitado = new HashSet<string>();

    foreach (var v in g.Keys)
        dist[v] = int.MaxValue;

    dist[origem] = 0;

    while (visitado.Count < g.Count)
    {
        // escolhe o no nao visitado com menor distancia
        string? atual = null;
        int menor = int.MaxValue;
        foreach (var v in g.Keys)
        {
            if (!visitado.Contains(v) && dist[v] < menor)
            {
                menor = dist[v];
                atual = v;
            }
        }

        if (atual == null) break; // desconectado

        visitado.Add(atual);

        foreach (var (destino, peso) in g[atual])
        {
            if (dist[atual] == int.MaxValue) continue;
            int nova = dist[atual] + peso;
            if (nova < dist[destino])
                dist[destino] = nova;
        }
    }

    return dist;
}

var resultado = Dijkstra(grafo, "A");
foreach (var par in resultado)
    Console.WriteLine($"{par.Key}: {par.Value}");

// DESAFIO
// 1) Guardar o caminho (predecessor).
// 2) Usar priority queue para otimizar.
