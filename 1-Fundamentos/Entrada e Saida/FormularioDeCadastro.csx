using System;

// ======================================================
// OBJETIVO
// Criar um formulario simples com validacao.
// ======================================================

static bool ValidarNome(string? nome) => !string.IsNullOrWhiteSpace(nome) && nome.Trim().Length >= 3;

static bool ValidarIdade(int idade) => idade >= 0 && idade <= 120;

static bool ValidarEmail(string? email)
{
    if (string.IsNullOrWhiteSpace(email)) return false;
    var e = email.Trim();
    var at = e.IndexOf('@');
    var dot = e.LastIndexOf('.');
    return at > 0 && dot > at + 1 && dot < e.Length - 1;
}

static void RodarInterativo()
{
    Console.WriteLine("Formulario de cadastro");

    Console.Write("Nome: ");
    var nome = Console.ReadLine();
    if (!ValidarNome(nome))
    {
        Console.WriteLine("Nome invalido.");
        return;
    }

    Console.Write("Idade: ");
    var idadeInput = Console.ReadLine();
    if (!int.TryParse(idadeInput, out var idade) || !ValidarIdade(idade))
    {
        Console.WriteLine("Idade invalida.");
        return;
    }

    Console.Write("Email: ");
    var email = Console.ReadLine();
    if (!ValidarEmail(email))
    {
        Console.WriteLine("Email invalido.");
        return;
    }

    Console.WriteLine("Cadastro OK!");
}

RodarInterativo();

// DESAFIO
// 1) Validar telefone com DDD.
// 2) Salvar cadastro em arquivo txt.
