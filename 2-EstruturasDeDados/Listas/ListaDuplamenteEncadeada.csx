using System;

// ======================================================
// OBJETIVO
// Implementar uma lista duplamente encadeada.
// ======================================================

// PASSO A PASSO
// 1) Cada no aponta para proximo e anterior.
// 2) Mantemos referencias para head e tail.
// 3) AddLast fica O(1) usando tail.

class NoDuplo
{
    public int Valor;
    public NoDuplo? Proximo;
    public NoDuplo? Anterior;

    public NoDuplo(int valor)
    {
        Valor = valor;
    }
}

class ListaDupla
{
    private NoDuplo? _head;
    private NoDuplo? _tail;

    public void AddLast(int valor)
    {
        var novo = new NoDuplo(valor);

        if (_tail == null)
        {
            _head = _tail = novo;
            return;
        }

        _tail.Proximo = novo;
        novo.Anterior = _tail;
        _tail = novo;
    }

    public void PrintForward()
    {
        var atual = _head;
        while (atual != null)
        {
            Console.Write(atual.Valor + " <-> ");
            atual = atual.Proximo;
        }
        Console.WriteLine("null");
    }
}

// ===================
// EXEMPLO
// ===================
var lista = new ListaDupla();
lista.AddLast(10);
lista.AddLast(20);
lista.AddLast(30);
lista.PrintForward();

// DESAFIO
// 1) Implementar Remove(valor).
// 2) Imprimir de tras para frente usando tail.
