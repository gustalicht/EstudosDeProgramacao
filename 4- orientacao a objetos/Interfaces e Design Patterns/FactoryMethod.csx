using System;

// ======================================================
// PATTERN: Factory Method
// ======================================================
// OBJETIVO
// Delegar a criacao de objetos para subclasses.
// ======================================================

interface ITransporte
{
    void Entregar();
}

class Caminhao : ITransporte
{
    public void Entregar() => Console.WriteLine("Entrega por caminhao");
}

class Navio : ITransporte
{
    public void Entregar() => Console.WriteLine("Entrega por navio");
}

abstract class Logistica
{
    public void PlanejarEntrega()
    {
        var transporte = CriarTransporte();
        transporte.Entregar();
    }

    // Metodo de fabrica
    protected abstract ITransporte CriarTransporte();
}

class LogisticaTerrestre : Logistica
{
    protected override ITransporte CriarTransporte() => new Caminhao();
}

class LogisticaMaritima : Logistica
{
    protected override ITransporte CriarTransporte() => new Navio();
}

// ===================
// EXEMPLO
// ===================
Logistica log1 = new LogisticaTerrestre();
log1.PlanejarEntrega();

Logistica log2 = new LogisticaMaritima();
log2.PlanejarEntrega();

// DESAFIO
// 1) Criar LogisticaAerea.
// 2) Comparar com SimpleFactory.
