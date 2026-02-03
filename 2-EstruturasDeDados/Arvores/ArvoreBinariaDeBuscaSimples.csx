using System;

// ======================================================
// OBJETIVO
// Implementar uma Arvore Binaria de Busca (BST).
// ======================================================

// PASSO A PASSO
// 1) Cada no tem um valor, esquerda e direita.
// 2) Valores menores vao para a esquerda.
// 3) Valores maiores vao para a direita.

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

class ArvoreBinariaBusca
{
    public No? Raiz;

    public void Inserir(int valor)
    {
        Raiz = InserirRec(Raiz, valor);
    }

    private No InserirRec(No? atual, int valor)
    {
        if (atual == null) return new No(valor);

        if (valor < atual.Valor)
            atual.Esquerda = InserirRec(atual.Esquerda, valor);
        else if (valor > atual.Valor)
            atual.Direita = InserirRec(atual.Direita, valor);
        // se for igual, ignoramos

        return atual;
    }

    public bool Buscar(int valor)
    {
        return BuscarRec(Raiz, valor);
    }

    private bool BuscarRec(No? atual, int valor)
    {
        if (atual == null) return false;
        if (atual.Valor == valor) return true;

        if (valor < atual.Valor)
            return BuscarRec(atual.Esquerda, valor);
        else
            return BuscarRec(atual.Direita, valor);
    }

    public void InOrder(No? atual)
    {
        if (atual == null) return;
        InOrder(atual.Esquerda);
        Console.Write(atual.Valor + " ");
        InOrder(atual.Direita);
    }
}

// ===================
// EXEMPLO
// ===================
var arvore = new ArvoreBinariaBusca();
arvore.Inserir(8);
arvore.Inserir(3);
arvore.Inserir(10);
arvore.Inserir(1);
arvore.Inserir(6);

Console.WriteLine("InOrder:");
arvore.InOrder(arvore.Raiz);
Console.WriteLine();

Console.WriteLine("Buscar 6: " + arvore.Buscar(6));
Console.WriteLine("Buscar 99: " + arvore.Buscar(99));

// DESAFIO
// 1) Implementar Remover.
// 2) Calcular altura da arvore.
