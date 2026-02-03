using System;

// ======================================================
// OBJETIVO
// Avaliar uma expressao simples no formato "a op b".
// ======================================================

static bool TentarAvaliar(string? expressao, out double resultado)
{
    resultado = 0;
    if (string.IsNullOrWhiteSpace(expressao)) return false;

    var parts = expressao.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if (parts.Length != 3) return false;

    if (!double.TryParse(parts[0], out var a)) return false;
    if (!double.TryParse(parts[2], out var b)) return false;

    resultado = parts[1] switch
    {
        "+" => a + b,
        "-" => a - b,
        "*" => a * b,
        "/" => b == 0 ? double.NaN : a / b,
        _ => double.NaN
    };

    return !double.IsNaN(resultado);
}

static void RodarInterativo()
{
    Console.Write("Digite a expressao (ex: 2 + 3): ");
    var expr = Console.ReadLine();
    if (TentarAvaliar(expr, out var resultado))
        Console.WriteLine($"Resultado: {resultado}");
    else
        Console.WriteLine("Expressao invalida.");
}

RodarInterativo();

// DESAFIO
// 1) Permitir entrada sem espacos (ex: 2+3).
// 2) Aceitar parenteses simples.
