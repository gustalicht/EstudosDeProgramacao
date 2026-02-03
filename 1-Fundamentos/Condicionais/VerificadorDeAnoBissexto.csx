using System;

// ======================================================
// OBJETIVO
// Verificar se um ano e bissexto.
// ======================================================

static bool EhBissexto(int ano)
{
    // Regra: divisivel por 4 e nao por 100, ou divisivel por 400
    return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
}

static void RodarTestes()
{
    Console.WriteLine("== Testes Ano Bissexto ==");
    Console.WriteLine(EhBissexto(2000));
    Console.WriteLine(EhBissexto(1900));
    Console.WriteLine(EhBissexto(2024));
}

bool executarTestes = true;
if (executarTestes) RodarTestes();

// DESAFIO
// 1) aceitar somente anos positivos
// 2) gerar lista de anos bissextos em um intervalo
