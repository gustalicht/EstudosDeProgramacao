using System;

// ======================================================
// OBJETIVO
// Verificar se um numero e primo.
// ======================================================

static bool EhPrimo(int n)
{
    if (n <= 1) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;

    int limite = (int)Math.Sqrt(n);
    for (int i = 3; i <= limite; i += 2)
    {
        if (n % i == 0) return false;
    }
    return true;
}

static void RodarInterativo()
{
    Console.Write("Digite um numero: ");
    var input = Console.ReadLine();
    if (!int.TryParse(input, out var n))
    {
        Console.WriteLine("Entrada invalida.");
        return;
    }

    Console.WriteLine(EhPrimo(n) ? "Primo" : "Nao primo");
}

RodarInterativo();

// DESAFIO
// 1) Gerar todos os primos ate N.
// 2) Comparar tempo entre metodos.
