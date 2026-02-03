using System;

// ======================================================
// OBJETIVO
// Converter temperaturas entre Celsius, Fahrenheit e Kelvin.
// ======================================================

static double CelsiusParaFahrenheit(double c) => (c * 9 / 5) + 32;
static double CelsiusParaKelvin(double c) => c + 273.15;
static double FahrenheitParaCelsius(double f) => (f - 32) * 5 / 9;

Console.Write("Temperatura em Celsius: ");
var input = Console.ReadLine();
if (!double.TryParse(input, out var c))
{
    Console.WriteLine("Entrada invalida.");
    return;
}

Console.WriteLine($"F: {CelsiusParaFahrenheit(c):F2}");
Console.WriteLine($"K: {CelsiusParaKelvin(c):F2}");
Console.WriteLine($"C (de F=32): {FahrenheitParaCelsius(32):F2}");

// DESAFIO
// 1) Criar menu para escolher conversao.
// 2) Converter K -> C e K -> F.
