using System;

// ======================================================
// OBJETIVO
// Avaliar a nota de um aluno e retornar o conceito.
// ======================================================

// REGRA
// >= 90: A
// >= 80: B
// >= 70: C
// >= 60: D
// < 60: F

// PASSO A PASSO (versao IF)
// 1) Verificar se a nota e valida.
// 2) Testar as faixas da maior para a menor.
// 3) Retornar o conceito correto.

static string AvaliarNotaIf(int nota)
{
    if (nota >= 90) return "A";
    if (nota >= 80) return "B";
    if (nota >= 70) return "C";
    if (nota >= 60) return "D";
    return "F";
}

// PASSO A PASSO (switch expression)
// 1) Usar uma expressao que retorna um valor.
// 2) Cada caso retorna um conceito.

static string AvaliarNotaSwitch(int nota)
{
    return nota switch
    {
        >= 90 => "A",
        >= 80 => "B",
        >= 70 => "C",
        >= 60 => "D",
        _ => "F",
    };
}

static bool NotaValida(int nota) => nota >= 0 && nota <= 100;

// ===================
// TESTES
// ===================
static void AssertEq(string nome, string atual, string esperado)
{
    var ok = string.Equals(atual, esperado, StringComparison.Ordinal);
    Console.WriteLine($"{nome}: {(ok ? "OK" : "FALHA")} (atual={atual}, esperado={esperado})");
}

static void RodarTestes()
{
    Console.WriteLine("== Testes Avaliador de Notas ==");
    AssertEq("95", AvaliarNotaIf(95), "A");
    AssertEq("85", AvaliarNotaSwitch(85), "B");
    AssertEq("50", AvaliarNotaSwitch(50), "F");
}

static void RodarInterativo()
{
    Console.Write("Digite a nota (0-100): ");
    var input = Console.ReadLine();
    if (!int.TryParse(input, out var nota) || !NotaValida(nota))
    {
        Console.WriteLine("Nota invalida.");
        return;
    }

    var conceito = AvaliarNotaSwitch(nota);
    Console.WriteLine($"Conceito: {conceito}");
}

bool executarTestes = true;
bool executarInterativo = false;

if (executarTestes) RodarTestes();
if (executarInterativo) RodarInterativo();

// DESAFIOS
// 1) Mostrar mensagens diferentes para cada conceito.
// 2) Permitir notas com decimais.
