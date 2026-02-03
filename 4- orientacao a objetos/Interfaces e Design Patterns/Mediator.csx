using System;

// ======================================================
// PATTERN: Mediator
// ======================================================
// OBJETIVO
// Centralizar comunicacao entre objetos.
// ======================================================

interface IMediator
{
    void Enviar(string msg, Usuario usuario);
}

class ChatMediator : IMediator
{
    public void Enviar(string msg, Usuario usuario)
    {
        Console.WriteLine($"{usuario.Nome} disse: {msg}");
    }
}

class Usuario
{
    public string Nome { get; }
    private readonly IMediator _mediator;

    public Usuario(string nome, IMediator mediator)
    {
        Nome = nome;
        _mediator = mediator;
    }

    public void EnviarMensagem(string msg)
    {
        _mediator.Enviar(msg, this);
    }
}

// ===================
// EXEMPLO
// ===================
var mediator = new ChatMediator();
var u1 = new Usuario("Ana", mediator);
var u2 = new Usuario("Bruno", mediator);

u1.EnviarMensagem("Ola");
u2.EnviarMensagem("Oi");

// DESAFIO
// 1) Criar salas diferentes.
// 2) Guardar historico de mensagens.
