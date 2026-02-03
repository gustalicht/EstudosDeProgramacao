using System;

// ======================================================
// OBJETIVO
// Mostrar abstracao com classe abstrata + classes concretas.
// ======================================================

// PASSO A PASSO
// 1) Criar classe abstrata com um metodo abstrato.
// 2) Criar classes filhas que implementam o metodo.
// 3) Usar a classe base para trabalhar com todas.

abstract class AvaliadorDeNotas
{
    public abstract string Avaliar(int nota);
}

class AvaliadorSimples : AvaliadorDeNotas
{
    public override string Avaliar(int nota)
    {
        if (nota >= 90) return "A";
        if (nota >= 80) return "B";
        if (nota >= 70) return "C";
        if (nota >= 60) return "D";
        return "F";
    }
}

class AvaliadorComSwitch : AvaliadorDeNotas
{
    public override string Avaliar(int nota)
    {
        return nota switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F",
        };
    }
}

// ===================
// EXEMPLO
// ===================
AvaliadorDeNotas avaliador = new AvaliadorComSwitch();
Console.WriteLine(avaliador.Avaliar(85)); // B

// DESAFIO
// 1) Criar AvaliadorCustomizado com regras diferentes.
// 2) Criar metodo que recebe AvaliadorDeNotas e aplica em lista.
