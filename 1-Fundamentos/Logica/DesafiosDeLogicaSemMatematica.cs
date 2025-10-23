//aqui uns desafios de lógica sem ma´temática.
using System;

class DesafiosDeLogicaSemMatematica
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafios de Lógica sem Matemática");

        // Desafio 1: Inverter uma string
        string original = "programação";
        char[] charArray = original.ToCharArray();
        Array.Reverse(charArray);
        string invertida = new string(charArray);
        Console.WriteLine($"String original: {original}, String invertida: {invertida}");

        // Desafio 2: Contar vogais em uma frase
        string frase = "Desafios de lógica sem matemática";
        int contadorVogais = 0;
        foreach (char c in frase.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                contadorVogais++;
            }
        }
        Console.WriteLine($"Número de vogais na frase: {contadorVogais}");

        // Desafio 3: Verificar palíndromo
        string palavra = "radar";
        char[] arr = palavra.ToCharArray();
        Array.Reverse(arr);
        string reversa = new string(arr);
        bool ehPalindromo = palavra.Equals(reversa, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine($"A palavra '{palavra}' é palíndromo? {ehPalindromo}");
    }
}

public class DesafiosMaisDificeis
{
    // Implementar desafios mais difíceis aqui no futuro
    public static void Desafio1()
    {// a ideia deste desafio é 
        // Código do desafio 1
    }
}