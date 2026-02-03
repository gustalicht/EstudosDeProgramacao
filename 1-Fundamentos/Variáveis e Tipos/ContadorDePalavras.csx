using System;

// ======================================================
// OBJETIVO
// Contar palavras em uma frase.
// ======================================================

static int ContarPalavras(string? frase)
{
    if (string.IsNullOrWhiteSpace(frase)) return 0;
    var parts = frase.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    return parts.Length;
}

Console.Write("Digite uma frase: ");
var frase = Console.ReadLine();
Console.WriteLine($"Palavras: {ContarPalavras(frase)}");

// DESAFIO
// 1) Contar caracteres sem espacos.
// 2) Contar frases por pontuacao.
