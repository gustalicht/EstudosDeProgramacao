using System;

// ======================================================
// OBJETIVO
// Criar uma calculadora com funcoes separadas.
// ======================================================

static double Somar(double a, double b) => a + b;
static double Subtrair(double a, double b) => a - b;
static double Multiplicar(double a, double b) => a * b;
static double Dividir(double a, double b) => b == 0 ? double.NaN : a / b;

static void RodarInterativo()
{
    Console.Write("Primeiro numero: ");
    var aOk = double.TryParse(Console.ReadLine(), out var a);
    Console.Write("Segundo numero: ");
    var bOk = double.TryParse(Console.ReadLine(), out var b);
    Console.Write("Operacao (+ - * /): ");
    var op = Console.ReadLine();

    if (!aOk || !bOk || string.IsNullOrWhiteSpace(op))
    {
        Console.WriteLine("Entrada invalida.");
        return;
    }

    var resultado = op.Trim() switch
    {
        "+" => Somar(a, b),
        "-" => Subtrair(a, b),
        "*" => Multiplicar(a, b),
        "/" => Dividir(a, b),
        _ => double.NaN
    };

    Console.WriteLine(double.IsNaN(resultado) ? "Operacao invalida" : $"Resultado: {resultado}");
}

RodarInterativo();

// DESAFIO
// 1) Adicionar potencia e raiz.
// 2) Validar divisao por zero com mensagem clara.
