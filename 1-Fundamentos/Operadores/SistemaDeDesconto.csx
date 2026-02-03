using System;

// ======================================================
// OBJETIVO
// Aplicar descontos com base no valor e cupom.
// ======================================================

static double CalcularPrecoFinal(double valor, bool temCupom)
{
    if (valor < 0) return double.NaN;

    double desconto = 0.0;
    if (valor >= 200) desconto = 0.20;
    else if (valor >= 100) desconto = 0.10;
    else if (temCupom) desconto = 0.05;

    return valor * (1 - desconto);
}

static void RodarInterativo()
{
    Console.Write("Valor da compra: ");
    var valorOk = double.TryParse(Console.ReadLine(), out var valor);
    Console.Write("Tem cupom? (s/n): ");
    var cupom = Console.ReadLine();

    if (!valorOk)
    {
        Console.WriteLine("Valor invalido.");
        return;
    }

    var temCupom = string.Equals(cupom, "s", StringComparison.OrdinalIgnoreCase);
    var final = CalcularPrecoFinal(valor, temCupom);
    Console.WriteLine($"Preco final: {final:F2}");
}

RodarInterativo();

// DESAFIO
// 1) Adicionar descontos por categoria.
// 2) Aplicar cupom fixo (ex: -20 reais).
