using System;

// ======================================================
// OBJETIVO
// Somar todos os numeros de 1 ate N.
// ======================================================

// PASSO A PASSO (loop)
// 1) Criar variavel soma = 0.
// 2) Repetir de 1 ate N.
// 3) Somar cada numero.

static int SomaAteN(int n)
{
    if (n <= 0) return 0;

    int soma = 0;
    for (int i = 1; i <= n; i++)
    {
        soma += i; // acumulamos o valor
    }
    return soma;
}

// PASSO A PASSO (formula)
// 1) Usar a formula matematica n*(n+1)/2
// 2) Evita loop quando o objetivo e apenas o valor final.

static int SomaAteNFormula(int n)
{
    if (n <= 0) return 0;
    return n * (n + 1) / 2;
}

// ===================
// TESTES
// ===================
static void AssertEq(string nome, int atual, int esperado)
{
    var ok = atual == esperado;
    Console.WriteLine($"{nome}: {(ok ? "OK" : "FALHA")} (atual={atual}, esperado={esperado})");
}

static void RodarTestes()
{
    Console.WriteLine("== Testes Soma ate N ==");
    AssertEq("N=1", SomaAteN(1), 1);
    AssertEq("N=10", SomaAteN(10), 55);
    AssertEq("Formula", SomaAteNFormula(10), 55);
}

static void RodarInterativo()
{
    Console.Write("Digite N: ");
    var input = Console.ReadLine();
    if (!int.TryParse(input, out var n))
    {
        Console.WriteLine("Entrada invalida.");
        return;
    }
    Console.WriteLine($"Soma (loop): {SomaAteN(n)}");
    Console.WriteLine($"Soma (formula): {SomaAteNFormula(n)}");
}

bool executarTestes = true;
bool executarInterativo = false;

if (executarTestes) RodarTestes();
if (executarInterativo) RodarInterativo();

// DESAFIOS
// 1) Validar se N e positivo.
// 2) Calcular soma apenas dos pares.
