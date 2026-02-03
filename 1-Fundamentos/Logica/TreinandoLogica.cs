// ======================================================
// OBJETIVO
// Treinar logica com exercicios simples.
// ======================================================

using System;
using System.Collections.Generic;

class TreinamentoDelogica
{
    static void Main(string[] args)
    {
        Console.WriteLine("Treinando Lógica de Programação");

        // Exemplo 1: Par ou impar
        int numero = 7;
        if (numero % 2 == 0)
            Console.WriteLine($"{numero} e par.");
        else
            Console.WriteLine($"{numero} e impar.");

        // Exemplo 2: Soma de 1 a 10
        int soma = 0;
        for (int i = 1; i <= 10; i++)
            soma += i;
        Console.WriteLine($"Soma de 1 a 10 = {soma}.");

        // Exemplo 3: Maior numero em uma lista
        List<int> numeros = new List<int> { 3, 5, 2, 8, 1 };
        int maior = numeros[0];
        foreach (var num in numeros)
        {
            if (num > maior)
                maior = num;
        }
        Console.WriteLine($"Maior numero: {maior}.");
    }
}
