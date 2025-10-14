int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

int maior = numeros[0]; // o que significa? 
int menor = numeros[0];

for (int i = 1; i < numeros.Length; i++)
{
    if (numeros[i] > maior)
        maior = numeros[i];

    if (numeros[i] < menor)
        menor = numeros[i];
}

Console.WriteLine($"Maior: {maior}, Menor: {menor}");



//forma mais direta usando LINQ 

//using System.Linq;

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

int maior = numeros.Max();
int menor = numeros.Min();

Console.WriteLine($"Maior: {maior}, Menor: {menor}");



// DESAFIO, TENTANDO FAZER SEM FOR, FOREACH. APENAS LÓGICA
//using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 4, 12, 1, 8, 7, 15, 2 };

        // Chamada da função recursiva começando do índice 0
        var resultado = EncontrarMaiorMenor(numeros, 0, numeros[0], numeros[0]);

        Console.WriteLine($"Maior: {resultado.maior}, Menor: {resultado.menor}");
    }

    // Função recursiva
    static (int maior, int menor) EncontrarMaiorMenor(int[] arr, int index, int maiorAtual, int menorAtual)
    {
        // Caso base: fim do array
        if (index == arr.Length)
        {
            return (maiorAtual, menorAtual);
        }

        // Atualiza maior e menor se necessário
        if (arr[index] > maiorAtual)
        {
            maiorAtual = arr[index];
        }
        if (arr[index] < menorAtual)
        {
            menorAtual = arr[index];
        }

        // Chamada recursiva para o próximo índice
        return EncontrarMaiorMenor(arr, index + 1, maiorAtual, menorAtual);
    }
}
