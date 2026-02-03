using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Gerar a tabuada de um numero ate um limite.
// ======================================================

// PASSO A PASSO
// 1) Receber o numero base.
// 2) Repetir de 1 ate o limite.
// 3) Multiplicar base x i e guardar o texto.

static List<string> GerarTabuada(int n, int ate)
{
    var linhas = new List<string>();
    for (int i = 1; i <= ate; i++)
    {
        linhas.Add($"{n} x {i} = {n * i}");
    }
    return linhas;
}

// ===================
// TESTES
// ===================
static void AssertEq(string nome, string atual, string esperado)
{
    var ok = string.Equals(atual, esperado, StringComparison.Ordinal);
    Console.WriteLine($"{nome}: {(ok ? "OK" : "FALHA")} (atual='{atual}', esperado='{esperado}')");
}

static void RodarTestes()
{
    Console.WriteLine("== Testes Tabuada ==");
    var t = GerarTabuada(3, 5);
    AssertEq("3x2", t[1], "3 x 2 = 6");
    AssertEq("3x5", t[4], "3 x 5 = 15");
}

static void RodarInterativo()
{
    Console.Write("Digite o numero: ");
    var input = Console.ReadLine();
    if (!int.TryParse(input, out var n))
    {
        Console.WriteLine("Entrada invalida.");
        return;
    }

    Console.Write("Ate: ");
    var inputAte = Console.ReadLine();
    if (!int.TryParse(inputAte, out var ate))
    {
        Console.WriteLine("Entrada invalida.");
        return;
    }

    foreach (var linha in GerarTabuada(n, ate))
        Console.WriteLine(linha);
}

bool executarTestes = true;
bool executarInterativo = false;

if (executarTestes) RodarTestes();
if (executarInterativo) RodarInterativo();

// DESAFIOS
// 1) Gerar tabuada de 1 a 10.
// 2) Usar while em vez de for.
