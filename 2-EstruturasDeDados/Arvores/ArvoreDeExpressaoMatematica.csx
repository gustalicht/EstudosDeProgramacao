using System;

// ======================================================
// OBJETIVO
// Criar e avaliar uma arvore de expressao matematica.
// ======================================================

// PASSO A PASSO
// 1) Cada no pode ser um numero ou operador.
// 2) Para avaliar, calcule recursivamente esquerda e direita.

class NoExpressao
{
    public string Valor;
    public NoExpressao? Esquerda;
    public NoExpressao? Direita;

    public NoExpressao(string valor)
    {
        Valor = valor;
    }
}

static double Avaliar(NoExpressao no)
{
    // Se for numero, retorna direto
    if (double.TryParse(no.Valor, out var numero))
        return numero;

    // Caso contrario, e operador
    var esquerda = Avaliar(no.Esquerda!);
    var direita = Avaliar(no.Direita!);

    return no.Valor switch
    {
        "+" => esquerda + direita,
        "-" => esquerda - direita,
        "*" => esquerda * direita,
        "/" => esquerda / direita,
        _ => throw new InvalidOperationException("Operador invalido")
    };
}

// ===================
// EXEMPLO
// Expressao: (3 + 4) * 5
// ===================
var raiz = new NoExpressao("*")
{
    Esquerda = new NoExpressao("+")
    {
        Esquerda = new NoExpressao("3"),
        Direita = new NoExpressao("4")
    },
    Direita = new NoExpressao("5")
};

Console.WriteLine(Avaliar(raiz)); // 35

// DESAFIO
// 1) Implementar parser simples para strings.
// 2) Suportar potencia.
