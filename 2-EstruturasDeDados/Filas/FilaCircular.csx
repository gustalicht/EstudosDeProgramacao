using System;

// ======================================================
// OBJETIVO
// Implementar uma fila circular simples.
// ======================================================

// PASSO A PASSO
// 1) Usar um array fixo para armazenar elementos.
// 2) Usar dois indices: frente e fim.
// 3) Quando chegar ao final, voltar ao inicio (circular).
// 4) Controlar o tamanho atual da fila.

class FilaCircular
{
    private int[] _dados;
    private int _frente;
    private int _fim;
    private int _tamanho;

    public FilaCircular(int capacidade)
    {
        _dados = new int[capacidade];
        _frente = 0;
        _fim = 0;
        _tamanho = 0;
    }

    public bool Enfileirar(int valor)
    {
        if (_tamanho == _dados.Length) return false; // fila cheia

        _dados[_fim] = valor;
        _fim = (_fim + 1) % _dados.Length; // volta ao inicio
        _tamanho++;
        return true;
    }

    public int? Desenfileirar()
    {
        if (_tamanho == 0) return null; // fila vazia

        int valor = _dados[_frente];
        _frente = (_frente + 1) % _dados.Length;
        _tamanho--;
        return valor;
    }

    public int Count => _tamanho;
}

// ===================
// EXEMPLO
// ===================
var fila = new FilaCircular(3);
Console.WriteLine(fila.Enfileirar(10));
Console.WriteLine(fila.Enfileirar(20));
Console.WriteLine(fila.Enfileirar(30));
Console.WriteLine(fila.Enfileirar(40)); // false (cheia)

Console.WriteLine(fila.Desenfileirar()); // 10
Console.WriteLine(fila.Enfileirar(40)); // true

// DESAFIO
// 1) Implementar Peek (ver o primeiro).
// 2) Tornar generica (FilaCircular<T>).
