using System;

// ======================================================
// PATTERN: Singleton
// ======================================================
// OBJETIVO
// Garantir apenas uma instancia de uma classe.
// ======================================================

class Configuracao
{
    // Instancia unica
    private static readonly Configuracao _instancia = new Configuracao();

    // Construtor privado impede new externo
    private Configuracao()
    {
        NomeApp = "MeuApp";
    }

    public string NomeApp { get; private set; }

    public static Configuracao Instancia => _instancia;
}

// ===================
// EXEMPLO
// ===================
var c1 = Configuracao.Instancia;
var c2 = Configuracao.Instancia;

Console.WriteLine(object.ReferenceEquals(c1, c2)); // true
Console.WriteLine(c1.NomeApp);

// DESAFIO
// 1) Tornar lazy (criar so quando for usado).
// 2) Adicionar thread-safety.
