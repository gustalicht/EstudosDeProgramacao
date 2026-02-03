using System;

// ======================================================
// OBJETIVO
// Calcular IMC e classificar o resultado.
// ======================================================

static double CalcularImc(double peso, double altura)
{
    return peso / (altura * altura);
}

static string ClassificarImc(double imc)
{
    if (imc < 18.5) return "abaixo do peso";
    if (imc < 25) return "normal";
    if (imc < 30) return "sobrepeso";
    return "obesidade";
}

static void RodarInterativo()
{
    Console.Write("Altura (ex: 1.70): ");
    if (!double.TryParse(Console.ReadLine(), out var altura) || altura <= 0)
    {
        Console.WriteLine("Altura invalida.");
        return;
    }

    Console.Write("Peso (ex: 65): ");
    if (!double.TryParse(Console.ReadLine(), out var peso) || peso <= 0)
    {
        Console.WriteLine("Peso invalido.");
        return;
    }

    var imc = CalcularImc(peso, altura);
    var classe = ClassificarImc(imc);

    Console.WriteLine($"IMC: {imc:F2} - {classe}");
}

RodarInterativo();

// DESAFIO
// 1) Validar limites humanos.
// 2) Usar tabela OMS detalhada.
