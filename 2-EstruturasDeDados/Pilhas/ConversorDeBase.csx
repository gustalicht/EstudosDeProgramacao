using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Converter um numero decimal para outra base usando pilha.
// ======================================================

// PASSO A PASSO
// 1) Dividir o numero pela base e pegar o resto.
// 2) Empilhar cada resto.
// 3) Desempilhar para formar o numero na ordem correta.

static string ConverterParaBase(int numero, int baseDestino)
{
    if (baseDestino < 2 || baseDestino > 16)
        throw new ArgumentOutOfRangeException(nameof(baseDestino));

    const string digitos = "0123456789ABCDEF";

    if (numero == 0) return "0";

    var pilha = new Stack<int>();
    int n = Math.Abs(numero);

    while (n > 0)
    {
        pilha.Push(n % baseDestino);
        n /= baseDestino;
    }

    var resultado = "";
    while (pilha.Count > 0)
        resultado += digitos[pilha.Pop()];

    return numero < 0 ? "-" + resultado : resultado;
}

// ===================
// EXEMPLO
// ===================
Console.WriteLine(ConverterParaBase(10, 2));  // 1010
Console.WriteLine(ConverterParaBase(255, 16)); // FF

// DESAFIO
// 1) Permitir bases ate 36.
// 2) Converter de base X para base Y.
