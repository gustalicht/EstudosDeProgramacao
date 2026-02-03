using System;

// ======================================================
// OBJETIVO
// Mostrar os percursos: InOrder, PreOrder, PostOrder.
// ======================================================

class No
{
    public int Valor;
    public No? Esquerda;
    public No? Direita;

    public No(int valor)
    {
        Valor = valor;
    }
}

// PASSO A PASSO
// InOrder: esquerda -> raiz -> direita
// PreOrder: raiz -> esquerda -> direita
// PostOrder: esquerda -> direita -> raiz

static void InOrder(No? no)
{
    if (no == null) return;
    InOrder(no.Esquerda);
    Console.Write(no.Valor + " ");
    InOrder(no.Direita);
}

static void PreOrder(No? no)
{
    if (no == null) return;
    Console.Write(no.Valor + " ");
    PreOrder(no.Esquerda);
    PreOrder(no.Direita);
}

static void PostOrder(No? no)
{
    if (no == null) return;
    PostOrder(no.Esquerda);
    PostOrder(no.Direita);
    Console.Write(no.Valor + " ");
}

// ===================
// EXEMPLO
// ===================
var raiz = new No(1)
{
    Esquerda = new No(2)
    {
        Esquerda = new No(4),
        Direita = new No(5)
    },
    Direita = new No(3)
};

Console.Write("InOrder: ");
InOrder(raiz);
Console.WriteLine();

Console.Write("PreOrder: ");
PreOrder(raiz);
Console.WriteLine();

Console.Write("PostOrder: ");
PostOrder(raiz);
Console.WriteLine();

// DESAFIO
// 1) Percurso em largura (BFS).
// 2) Calcular quantidade de nos.
