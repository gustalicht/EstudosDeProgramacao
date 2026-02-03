using System;

// ======================================================
// OBJETIVO
// Encontrar o maior de tres numeros.
// ======================================================

static int MaiorDeTres(int a, int b, int c)
{
    int maior = a;
    if (b > maior) maior = b;
    if (c > maior) maior = c;
    return maior;
}

static void RodarInterativo()
{
    Console.Write("Digite 3 numeros separados por espaco: ");
    var input = Console.ReadLine();
    var parts = input?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if (parts == null || parts.Length != 3)
    {
        Console.WriteLine("Entrada invalida.");
        return;
    }

    if (!int.TryParse(parts[0], out var a) || !int.TryParse(parts[1], out var b) || !int.TryParse(parts[2], out var c))
    {
        Console.WriteLine("Entrada invalida.");
        return;
    }

    Console.WriteLine($"Maior: {MaiorDeTres(a, b, c)}");
}

RodarInterativo();

// DESAFIO
// 1) Encontrar maior em uma lista.
// 2) Retornar tambem o menor.
