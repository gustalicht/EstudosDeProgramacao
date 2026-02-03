using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Simular uma fila de mensagens (thread-safe).
// ======================================================

// PASSO A PASSO
// 1) Gerador cria mensagens.
// 2) Fila armazena.
// 3) Consumidor remove e processa.

class GeradorDeMensagens
{
    private int _contador = 0;

    public string GerarMensagem()
    {
        _contador++;
        return $"Mensagem {_contador} gerada em {DateTime.Now}";
    }
}

class FilaDeMensagens
{
    private readonly Queue<string> _fila = new Queue<string>();
    private readonly object _lockObj = new object();

    public void Enfileirar(string mensagem)
    {
        lock (_lockObj)
        {
            _fila.Enqueue(mensagem);
            Console.WriteLine($"Enfileirado: {mensagem}");
        }
    }

    public string? Desenfileirar()
    {
        lock (_lockObj)
        {
            if (_fila.Count > 0)
            {
                var mensagem = _fila.Dequeue();
                Console.WriteLine($"Desenfileirado: {mensagem}");
                return mensagem;
            }
            return null;
        }
    }

    public int ContarMensagens()
    {
        lock (_lockObj)
        {
            return _fila.Count;
        }
    }
}

class Program
{
    static void Main()
    {
        var gerador = new GeradorDeMensagens();
        var fila = new FilaDeMensagens();

        fila.Enfileirar(gerador.GerarMensagem());
        fila.Enfileirar(gerador.GerarMensagem());

        fila.Desenfileirar();
        fila.Desenfileirar();
    }
}

// DESAFIO
// 1) Criar um loop produtor/consumidor.
// 2) Limitar o tamanho da fila.
