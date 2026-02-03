using System;
using System.Collections.Generic;

// ======================================================
// OBJETIVO
// Verificar se uma expressao tem parenteses balanceados.
// ======================================================

// PASSO A PASSO
// 1) Criar uma pilha (stack).
// 2) Percorrer cada caractere.
// 3) Se for abertura, empilha.
// 4) Se for fechamento, desempilha e confere.
// 5) No final, a pilha deve estar vazia.

static bool ParentesesBalanceados(string texto)
{
    var pilha = new Stack<char>();

    foreach (var c in texto)
    {
        if (c == '(' || c == '[' || c == '{')
        {
            pilha.Push(c);
        }
        else if (c == ')' || c == ']' || c == '}')
        {
            if (pilha.Count == 0) return false;

            var topo = pilha.Pop();
            if (!Combina(topo, c)) return false;
        }
    }

    return pilha.Count == 0;
}

static bool Combina(char abertura, char fechamento)
{
    return (abertura == '(' && fechamento == ')')
        || (abertura == '[' && fechamento == ']')
        || (abertura == '{' && fechamento == '}');
}

// ===================
// EXEMPLO
// ===================
Console.WriteLine(ParentesesBalanceados("(a + b)"));   // true
Console.WriteLine(ParentesesBalanceados("(a + b]"));   // false
Console.WriteLine(ParentesesBalanceados("([{}])"));    // true

// DESAFIO
// 1) Ignorar parenteses dentro de aspas.
// 2) Retornar a posicao do erro.
