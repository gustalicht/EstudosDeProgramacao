using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Criar um quiz simples com pontuacao.
// ======================================================

record Pergunta(string Enunciado, string[] Opcoes, char RespostaCerta);

static List<Pergunta> CriarPerguntas()
{
    return new List<Pergunta>
    {
        new Pergunta("Qual a saida de 2 + 2?", new[] { "A) 3", "B) 4", "C) 5" }, 'B'),
        new Pergunta("Qual o operador de AND logico em C#?", new[] { "A) &&", "B) ||", "C) !" }, 'A'),
        new Pergunta("Qual estrutura repete enquanto condicao e verdadeira?", new[] { "A) if", "B) while", "C) switch" }, 'B')
    };
}

static int CalcularPontuacao(List<(Pergunta pergunta, char resposta)> respostas)
{
    int pontos = 0;
    foreach (var item in respostas)
    {
        if (char.ToUpperInvariant(item.resposta) == char.ToUpperInvariant(item.pergunta.RespostaCerta))
            pontos++;
    }
    return pontos;
}

static void RodarInterativo()
{
    var perguntas = CriarPerguntas();
    var respostas = new List<(Pergunta, char)>();

    foreach (var p in perguntas)
    {
        Console.WriteLine(p.Enunciado);
        foreach (var opcao in p.Opcoes)
            Console.WriteLine(opcao);

        Console.Write("Resposta: ");
        var r = Console.ReadLine();
        var resp = string.IsNullOrWhiteSpace(r) ? ' ' : r.Trim()[0];
        respostas.Add((p, resp));
        Console.WriteLine();
    }

    var pontos = CalcularPontuacao(respostas);
    Console.WriteLine($"Pontuacao final: {pontos}/{perguntas.Count}");
}

RodarInterativo();

// DESAFIO
// 1) Mostrar feedback por pergunta.
// 2) Salvar pontuacao em arquivo.
