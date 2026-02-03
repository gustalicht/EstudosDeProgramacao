using System;
using System.Linq;

// ======================================================
// OBJETIVO
// Mostrar exemplos simples de funcoes.
// ======================================================

static int Soma(int a, int b) => a + b;

static double Media(params int[] valores)
{
    if (valores == null || valores.Length == 0) return 0;
    return valores.Average();
}

static string Saudacao(string nome, string prefixo = "Ola")
{
    return $"{prefixo}, {nome}!";
}

Console.WriteLine(Soma(3, 4));
Console.WriteLine(Media(2, 4, 6));
Console.WriteLine(Saudacao("Gustavo"));

// DESAFIO
// 1) Criar funcao que retorna o maior de 3 numeros.
// 2) Criar funcao para inverter string.
