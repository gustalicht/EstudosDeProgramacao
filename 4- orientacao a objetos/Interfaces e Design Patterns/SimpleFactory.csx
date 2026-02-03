using System;

// ======================================================
// PATTERN: Simple Factory
// ======================================================
// OBJETIVO
// Criar objetos sem expor a logica de criacao para quem usa.
// ======================================================

interface IForma
{
    void Desenhar();
}

class Circulo : IForma
{
    public void Desenhar() => Console.WriteLine("Desenhando circulo");
}

class Quadrado : IForma
{
    public void Desenhar() => Console.WriteLine("Desenhando quadrado");
}

// PASSO A PASSO
// 1) Criar interface base.
// 2) Criar classes concretas.
// 3) Criar uma classe fabrica com metodo estatico.

static class FormaFactory
{
    public static IForma Criar(string tipo)
    {
        return tipo.ToLower() switch
        {
            "circulo" => new Circulo(),
            "quadrado" => new Quadrado(),
            _ => throw new ArgumentException("Tipo invalido")
        };
    }
}

// ===================
// EXEMPLO
// ===================
var forma = FormaFactory.Criar("circulo");
forma.Desenhar();

// DESAFIO
// 1) Adicionar triangulo.
// 2) Evitar string usando enum.
