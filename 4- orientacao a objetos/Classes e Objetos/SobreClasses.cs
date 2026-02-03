using System;

// ======================================================
// OBJETIVO
// Mostrar como criar classes e objetos.
// ======================================================

class ContaBancaria
{
    // ATRIBUTOS (estado)
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }

    // CONSTRUTOR
    public ContaBancaria(string titular, decimal saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }

    // METODO (comportamento)
    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor invalido");
            return;
        }
        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor invalido");
            return;
        }
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente");
            return;
        }
        Saldo -= valor;
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Titular: {Titular} | Saldo: {Saldo}");
    }
}

class Program
{
    static void Main()
    {
        // CRIANDO OBJETOS (instancias)
        var conta = new ContaBancaria("Gustavo", 100);
        conta.MostrarSaldo();

        conta.Depositar(50);
        conta.Sacar(30);
        conta.MostrarSaldo();

        conta.Sacar(500); // saldo insuficiente
    }
}

// DESAFIO
// 1) Criar uma classe Produto (nome, preco, estoque).
// 2) Criar metodo Comprar(qtd) que reduz estoque.
