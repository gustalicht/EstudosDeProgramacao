using System;
using System.Text;

// ======================================================
// OBJETIVO
// Converter numeros entre bases (2 a 36).
// ======================================================

const string Digitos = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

static string ParaBase(int numero, int baseDestino)
{
    if (baseDestino < 2 || baseDestino > 36)
        throw new ArgumentOutOfRangeException(nameof(baseDestino));

    if (numero == 0) return "0";

    var n = Math.Abs(numero);
    var sb = new StringBuilder();
    while (n > 0)
    {
        var resto = n % baseDestino;
        sb.Insert(0, Digitos[resto]);
        n /= baseDestino;
    }

    return numero < 0 ? "-" + sb.ToString() : sb.ToString();
}

static int DeBase(string valor, int baseOrigem)
{
    if (string.IsNullOrWhiteSpace(valor))
        throw new ArgumentException("valor invalido");
    if (baseOrigem < 2 || baseOrigem > 36)
        throw new ArgumentOutOfRangeException(nameof(baseOrigem));

    var v = valor.Trim().ToUpperInvariant();
    var negativo = v.StartsWith("-");
    if (negativo) v = v[1..];

    var resultado = 0;
    foreach (var c in v)
    {
        var idx = Digitos.IndexOf(c);
        if (idx < 0 || idx >= baseOrigem)
            throw new ArgumentException("digito invalido");
        resultado = resultado * baseOrigem + idx;
    }

    return negativo ? -resultado : resultado;
}

static void RodarInterativo()
{
    Console.Write("Numero decimal: ");
    var nOk = int.TryParse(Console.ReadLine(), out var n);
    Console.Write("Base destino (2-36): ");
    var bOk = int.TryParse(Console.ReadLine(), out var b);

    if (!nOk || !bOk)
    {
        Console.WriteLine("Entrada invalida.");
        return;
    }

    Console.WriteLine($"Resultado: {ParaBase(n, b)}");
}

RodarInterativo();

// DESAFIO
// 1) Converter de qualquer base para qualquer base.
// 2) Validar bases com mensagens de erro amigaveis.
