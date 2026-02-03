using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Implementar BFS (largura) e DFS (profundidade).
// ======================================================

Dictionary<int, List<int>> grafo = new Dictionary<int, List<int>>
{
    { 1, new List<int> { 2, 3 } },
    { 2, new List<int> { 4 } },
    { 3, new List<int> { 4, 5 } },
    { 4, new List<int> { } },
    { 5, new List<int> { } }
};

// BFS
static void BFS(Dictionary<int, List<int>> g, int inicio)
{
    var visitado = new HashSet<int>();
    var fila = new Queue<int>();

    fila.Enqueue(inicio);
    visitado.Add(inicio);

    while (fila.Count > 0)
    {
        int atual = fila.Dequeue();
        Console.Write(atual + " ");

        foreach (var vizinho in g[atual])
        {
            if (!visitado.Contains(vizinho))
            {
                visitado.Add(vizinho);
                fila.Enqueue(vizinho);
            }
        }
    }
}

// DFS
static void DFS(Dictionary<int, List<int>> g, int inicio, HashSet<int> visitado)
{
    if (visitado.Contains(inicio)) return;
    visitado.Add(inicio);
    Console.Write(inicio + " ");

    foreach (var vizinho in g[inicio])
    {
        DFS(g, vizinho, visitado);
    }
}

Console.Write("BFS: ");
BFS(grafo, 1);
Console.WriteLine();

Console.Write("DFS: ");
DFS(grafo, 1, new HashSet<int>());
Console.WriteLine();

// DESAFIO
// 1) Guardar distancia no BFS.
// 2) Fazer DFS iterativo usando pilha.
