using System;
using System.Collections.Generic;
using System.Linq;

// ======================================================
// OBJETIVO
// Contar quantas vezes cada palavra aparece.
// ======================================================

// PASSO A PASSO
// 1) Separar a frase em palavras.
// 2) Usar Dictionary para contar.
// 3) Se a palavra ja existe, incrementar.

static Dictionary<string, int> ContarPalavras(string frase)
{
    var contagem = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

    var palavras = frase.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' },
        StringSplitOptions.RemoveEmptyEntries);

    foreach (var p in palavras)
    {
        if (contagem.ContainsKey(p))
            contagem[p]++;
        else
            contagem[p] = 1;
    }

    return contagem;
}

// ===================
// EXEMPLO
// ===================
string texto = "ola mundo ola";
var resultado = ContarPalavras(texto);
foreach (var item in resultado)
    Console.WriteLine($"{item.Key}: {item.Value}");

// DESAFIO
// 1) Remover acentos antes de contar.
// 2) Ordenar por frequencia.
