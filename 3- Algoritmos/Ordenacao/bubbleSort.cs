using System;
using System.Linq;

// ======================================================
// OBJETIVO
// Implementar o algoritmo Bubble Sort.
// ======================================================

// PASSO A PASSO
// 1) Percorrer o array varias vezes.
// 2) Comparar pares vizinhos.
// 3) Trocar se estiverem fora de ordem.
// 4) A cada passada, o maior "borbulha" para o final.

class BubbleSortExample
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool trocou;

        for (int i = 0; i < n - 1; i++)
        {
            trocou = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    trocou = true;
                }
            }

            // Se nao houve troca, ja esta ordenado
            if (!trocou) break;
        }
    }

    static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        BubbleSort(arr);

        Console.WriteLine(string.Join(", ", arr));
    }
}

// DESAFIO
// 1) Contar quantas trocas foram feitas.
// 2) Ordenar em ordem decrescente.
