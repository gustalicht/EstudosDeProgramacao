using System;
using System.Collections.Generic;

// ======================================================
// PATTERN: Observer
// ======================================================
// OBJETIVO
// Notificar varios observadores quando algo muda.
// ======================================================

interface IObservador
{
    void Atualizar(string mensagem);
}

class ObservadorConsole : IObservador
{
    private readonly string _nome;
    public ObservadorConsole(string nome) => _nome = nome;

    public void Atualizar(string mensagem)
    {
        Console.WriteLine($"{_nome} recebeu: {mensagem}");
    }
}

class Sujeito
{
    private readonly List<IObservador> _observadores = new List<IObservador>();

    public void Inscrever(IObservador obs) => _observadores.Add(obs);
    public void Remover(IObservador obs) => _observadores.Remove(obs);

    public void Notificar(string msg)
    {
        foreach (var obs in _observadores)
            obs.Atualizar(msg);
    }
}

// ===================
// EXEMPLO
// ===================
var sujeito = new Sujeito();
sujeito.Inscrever(new ObservadorConsole("A"));
sujeito.Inscrever(new ObservadorConsole("B"));

sujeito.Notificar("Evento ocorreu");

// DESAFIO
// 1) Criar um observador que salva em arquivo.
// 2) Notificar apenas observadores filtrados.
