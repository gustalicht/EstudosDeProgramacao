using System;

// ======================================================
// OBJETIVO
// Converter reais para outra moeda usando cotacao fixa.
// ======================================================

static double ConverterMoeda(double valorEmReais, double cotacao)
{
    if (cotacao <= 0) return double.NaN;
    return valorEmReais / cotacao;
}

Console.Write("Valor em reais: ");
var valorOk = double.TryParse(Console.ReadLine(), out var valor);
Console.Write("Cotacao da moeda: ");
var cotOk = double.TryParse(Console.ReadLine(), out var cotacao);

if (!valorOk || !cotOk)
{
    Console.WriteLine("Entrada invalida.");
    return;
}

var convertido = ConverterMoeda(valor, cotacao);
Console.WriteLine($"Convertido: {convertido:F2}");

// DESAFIO
// 1) Aceitar 3 moedas diferentes.
// 2) Ler cotacao de arquivo txt.
