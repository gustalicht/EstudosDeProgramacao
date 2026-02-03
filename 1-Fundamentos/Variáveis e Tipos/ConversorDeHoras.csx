using System;

// ======================================================
// OBJETIVO
// Converter horas em minutos e segundos.
// ======================================================

static (int minutos, int segundos) ConverterHoras(int horas)
{
    return (horas * 60, horas * 3600);
}

Console.Write("Digite horas: ");
var input = Console.ReadLine();
if (!int.TryParse(input, out var horas))
{
    Console.WriteLine("Entrada invalida.");
    return;
}
var (min, seg) = ConverterHoras(horas);
Console.WriteLine($"Minutos: {min}, Segundos: {seg}");

// DESAFIO
// 1) Aceitar horas com decimais.
// 2) Converter para dias e semanas.
