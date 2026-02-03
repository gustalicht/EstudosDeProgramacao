using System;
using System.Globalization;

// ======================================================
// OBJETIVO
// Criar uma calculadora simples com entrada de dados.
// ======================================================

static bool TentarCalcular(double a, double b, string? operacao, out double resultado)
{
    resultado = 0;
    if (string.IsNullOrWhiteSpace(operacao)) return false;

    switch (operacao.Trim())
    {
        case "+": resultado = a + b; return true;
        case "-": resultado = a - b; return true;
        case "*": resultado = a * b; return true;
        case "/":
            if (b == 0) return false;
            resultado = a / b;
            return true;
        default:
            return false;
    }
}

static bool TryParseDouble(string? input, out double valor)
    => double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out valor)
       || double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out valor);

static void RodarInterativo()
{
    Console.Write("Digite o primeiro numero: ");
    if (!TryParseDouble(Console.ReadLine(), out var primeiro))
    {
        Console.WriteLine("Entrada invalida.");
        return;
    }

    Console.Write("Escolha a operacao (+,-,*,/): ");
    var operacao = Console.ReadLine();

    Console.Write("Digite o segundo numero: ");
    if (!TryParseDouble(Console.ReadLine(), out var segundo))
    {
        Console.WriteLine("Entrada invalida.");
        return;
    }

    if (!TentarCalcular(primeiro, segundo, operacao, out var resultado))
    {
        Console.WriteLine("Operacao invalida ou divisao por zero.");
        return;
    }

    Console.WriteLine($"Resultado: {resultado}");
}

RodarInterativo();

// DESAFIO
// 1) Adicionar potencia e raiz.
// 2) Aceitar expressao inteira em uma linha.
