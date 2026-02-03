using System;
using System.Globalization;

// ======================================================
// OBJETIVO
// Praticar entrada/saida e conversao segura de tipos.
// ======================================================

static bool TryParseInt(string? input, out int valor)
    => int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out valor)
       || int.TryParse(input, NumberStyles.Integer, CultureInfo.CurrentCulture, out valor);

static bool TryParseDouble(string? input, out double valor)
    => double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out valor)
       || double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out valor);

static void RodarInterativo()
{
    Console.Write("Digite sua idade: ");
    var idadeInput = Console.ReadLine();
    if (!TryParseInt(idadeInput, out var idade))
    {
        Console.WriteLine("Idade invalida.");
        return;
    }

    Console.Write("Digite sua altura (ex: 1.75): ");
    var alturaInput = Console.ReadLine();
    if (!TryParseDouble(alturaInput, out var altura))
    {
        Console.WriteLine("Altura invalida.");
        return;
    }

    Console.WriteLine($"Idade: {idade}, Altura: {altura:F2}");
}

RodarInterativo();

// DESAFIO
// 1) Ler nome, idade e email e validar.
// 2) Repetir ate a entrada ser valida.
