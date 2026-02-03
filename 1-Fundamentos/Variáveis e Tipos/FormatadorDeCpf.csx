using System;
using System.Linq;

// ======================================================
// OBJETIVO
// Formatar CPF no padrao ###.###.###-##.
// ======================================================

static string? FormatarCpf(string? cpf)
{
    if (string.IsNullOrWhiteSpace(cpf)) return null;

    var digits = new string(cpf.Where(char.IsDigit).ToArray());
    if (digits.Length != 11) return null;

    return $"{digits[..3]}.{digits.Substring(3, 3)}.{digits.Substring(6, 3)}-{digits.Substring(9, 2)}";
}

Console.Write("Digite o CPF: ");
var cpf = Console.ReadLine();
var formatado = FormatarCpf(cpf);
Console.WriteLine(formatado ?? "CPF invalido");

// DESAFIO
// 1) Validar CPF usando digitos verificadores.
// 2) Remover formatacao (somente numeros).
