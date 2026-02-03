using System;

// ======================================================
// OBJETIVO
// Implementar uma lista encadeada simples.
// ======================================================

// PASSO A PASSO
// 1) Criar classe No (valor + proximo).
// 2) Manter referencia para o primeiro no (head).
// 3) Implementar AddLast e Print.

class No
{
    public int Valor;
    public No? Proximo;

    public No(int valor)
    {
        Valor = valor;
        Proximo = null;
    }
}

class ListaEncadeadaSimples
{
    private No? _head;

    public void AddLast(int valor)
    {
        var novo = new No(valor);

        if (_head == null)
        {
            _head = novo;
            return;
        }

        var atual = _head;
        while (atual.Proximo != null)
            atual = atual.Proximo;

        atual.Proximo = novo;
    }

    public void Print()
    {
        var atual = _head;
        while (atual != null)
        {
            Console.Write(atual.Valor + " -> ");
            atual = atual.Proximo;
        }
        Console.WriteLine("null");
    }
}

// ===================
// EXEMPLO
// ===================
var lista = new ListaEncadeadaSimples();
lista.AddLast(1);
lista.AddLast(2);
lista.AddLast(3);
lista.Print();

// DESAFIO
// 1) Implementar Remove(valor).
// 2) Implementar AddFirst(valor).
