using System;

// ======================================================
// OBJETIVO
// Simular um login com limite de tentativas.
// ======================================================

const string UsuarioCorreto = "admin";
const string SenhaCorreta = "1234";

static bool Autenticar(string? usuario, string? senha)
{
    return string.Equals(usuario, UsuarioCorreto, StringComparison.Ordinal)
        && string.Equals(senha, SenhaCorreta, StringComparison.Ordinal);
}

static void RodarInterativo()
{
    int tentativas = 3;
    while (tentativas > 0)
    {
        Console.Write("Usuario: ");
        var usuario = Console.ReadLine();
        Console.Write("Senha: ");
        var senha = Console.ReadLine();

        if (Autenticar(usuario, senha))
        {
            Console.WriteLine("Login OK");
            return;
        }

        tentativas--;
        Console.WriteLine($"Falha. Tentativas restantes: {tentativas}");
    }

    Console.WriteLine("Conta bloqueada por tentativas.");
}

RodarInterativo();

// DESAFIO
// 1) Implementar bloqueio por tempo.
// 2) Usar hash simples de senha.
