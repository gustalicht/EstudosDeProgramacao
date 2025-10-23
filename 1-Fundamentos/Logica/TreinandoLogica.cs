//a ideia é treinar bem a lógica de programação com exercícios simples.

using System;Collections.Generic;

class TreinamentoDelogica
{
    static void Main(string[] args)
    {
        Console.WriteLine("Treinando Lógica de Programação");

        // Exemplo 1: Verificar se um número é par ou ímpar
        int numero = 7;
        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} é par.");
        }
        else
        {
            Console.WriteLine($"{numero} é ímpar.");
        }

        // Exemplo 2: Calcular a soma dos números de 1 a 10
        int soma = 0;
        for (int i = 1; i <= 10; i++)
        {
            soma += i;
        }
        Console.WriteLine($"A soma dos números de 1 a 10 é {soma}.");

        // Exemplo 3: Encontrar o maior número em uma lista
        List<int> numeros = new List<int> { 3, 5, 2, 8, 1 };
        int maior = numeros[0];
        foreach (var num in numeros)
        {
            if (num > maior)
            {
                maior = num;
            }
        }
        Console.WriteLine($"O maior número na lista é {maior}.");
    }
}