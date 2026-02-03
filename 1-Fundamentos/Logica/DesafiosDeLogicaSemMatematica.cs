// ======================================================
// OBJETIVO
// Resolver desafios simples de logica sem matematica pesada.
// ======================================================

using System;

class DesafiosDeLogicaSemMatematica
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafios de Lógica sem Matemática");

        // Desafio 1: Inverter uma string
        // PASSO A PASSO
        // 1) Transformar a string em array de char.
        // 2) Inverter o array.
        // 3) Criar nova string.
        string original = "programacao";
        char[] charArray = original.ToCharArray();
        Array.Reverse(charArray);
        string invertida = new string(charArray);
        Console.WriteLine($"Original: {original}, Invertida: {invertida}");

        // Desafio 2: Contar vogais
        // PASSO A PASSO
        // 1) Percorrer cada letra.
        // 2) Verificar se esta em 'aeiou'.
        // 3) Contar.
        string frase = "Desafios de logica";
        int contadorVogais = 0;
        foreach (char c in frase.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                contadorVogais++;
            }
        }
        Console.WriteLine($"Vogais: {contadorVogais}");

        // Desafio 3: Verificar palindromo
        string palavra = "radar";
        char[] arr = palavra.ToCharArray();
        Array.Reverse(arr);
        string reversa = new string(arr);
        bool ehPalindromo = palavra.Equals(reversa, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine($"'{palavra}' e palindromo? {ehPalindromo}");
    }
}

public class DesafiosMaisDificeis
{
    // Espaço para desafios mais avancados
    public static void Desafio1()
    {
        // Implementar aqui
    }
}
