using System;
using System.Collections.Generic;

// ======================================================
// PATTERN: Command
// ======================================================
// OBJETIVO
// Transformar uma acao em objeto (facilita desfazer).
// ======================================================

interface ICommand
{
    void Executar();
}

class Luz
{
    public void Ligar() => Console.WriteLine("Luz ligada");
    public void Desligar() => Console.WriteLine("Luz desligada");
}

class LigarLuzCommand : ICommand
{
    private readonly Luz _luz;
    public LigarLuzCommand(Luz luz) => _luz = luz;
    public void Executar() => _luz.Ligar();
}

class DesligarLuzCommand : ICommand
{
    private readonly Luz _luz;
    public DesligarLuzCommand(Luz luz) => _luz = luz;
    public void Executar() => _luz.Desligar();
}

class ControleRemoto
{
    private readonly List<ICommand> _historico = new List<ICommand>();

    public void Pressionar(ICommand comando)
    {
        comando.Executar();
        _historico.Add(comando);
    }
}

// ===================
// EXEMPLO
// ===================
var luz = new Luz();
var ligar = new LigarLuzCommand(luz);
var desligar = new DesligarLuzCommand(luz);

var controle = new ControleRemoto();
controle.Pressionar(ligar);
controle.Pressionar(desligar);

// DESAFIO
// 1) Adicionar comando de desfazer.
// 2) Criar comandos para ventilador.
