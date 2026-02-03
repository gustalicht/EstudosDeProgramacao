using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Criar um tradutor simples (portugues -> ingles).
// ======================================================

// PASSO A PASSO
// 1) Criar Dictionary com as traducoes.
// 2) Ler a palavra do usuario.
// 3) Procurar no dicionario.

static void RodarTradutor()
{
    var tradutor = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "oi", "hello" },
        { "mundo", "world" },
        { "gato", "cat" },
        { "cachorro", "dog" }
    };

    Console.Write("Digite uma palavra: ");
    var palavra = Console.ReadLine();

    if (palavra == null)
    {
        Console.WriteLine("Entrada invalida.");
        return;
    }

    if (tradutor.TryGetValue(palavra, out var traducao))
        Console.WriteLine($"Traducao: {traducao}");
    else
        Console.WriteLine("Palavra nao encontrada.");
}

RodarTradutor();

// DESAFIO
// 1) Permitir frases (traduzir palavra por palavra).
// 2) Salvar as palavras em um arquivo.
