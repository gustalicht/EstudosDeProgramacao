using System;

// ======================================================
// OBJETIVO
// Classificar um numero como par/impar e positivo/negativo.
// ======================================================

static string ClassificarNumero(int n)
{
    if (n == 0) return "zero";

    var parOuImpar = (n % 2 == 0) ? "par" : "impar";
    var sinal = (n > 0) ? "positivo" : "negativo";
    return $"{parOuImpar} {sinal}";
}

static void RodarTestes()
{
    Console.WriteLine("== Testes Verificador de Numeros ==");
    Console.WriteLine(ClassificarNumero(-3));
    Console.WriteLine(ClassificarNumero(0));
    Console.WriteLine(ClassificarNumero(4));
}

bool executarTestes = true;
if (executarTestes) RodarTestes();

// DESAFIO
// 1) retornar se e multiplo de 3 e/ou 5
// 2) contar pares/impares em um array
