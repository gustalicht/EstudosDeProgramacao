using System;
using System.Linq;

// ======================================================
// OBJETIVO
// Validar um CPF usando os digitos verificadores.
// ======================================================

// PASSO A PASSO (resumo do algoritmo)
// 1) Remover tudo que nao for numero.
// 2) Verificar se tem 11 digitos.
// 3) Rejeitar CPFs com todos os digitos iguais.
// 4) Calcular o 1o digito verificador.
// 5) Calcular o 2o digito verificador.
// 6) Comparar com os digitos informados.

static string ApenasDigitos(string? cpf)
{
    if (string.IsNullOrWhiteSpace(cpf)) return string.Empty;
    return new string(cpf.Where(char.IsDigit).ToArray());
}

static bool EhCpfValido(string? cpf)
{
    var digits = ApenasDigitos(cpf);
    if (digits.Length != 11) return false;
    if (digits.Distinct().Count() == 1) return false;

    var nums = digits.Select(c => c - '0').ToArray();

    // Digito 1
    int soma = 0;
    for (int i = 0; i < 9; i++)
        soma += nums[i] * (10 - i);
    int resto = soma % 11;
    int dig1 = resto < 2 ? 0 : 11 - resto;
    if (nums[9] != dig1) return false;

    // Digito 2
    soma = 0;
    for (int i = 0; i < 10; i++)
        soma += nums[i] * (11 - i);
    resto = soma % 11;
    int dig2 = resto < 2 ? 0 : 11 - resto;

    return nums[10] == dig2;
}

// ===================
// TESTES
// ===================
static void AssertEq(string nome, bool atual, bool esperado)
{
    var ok = atual == esperado;
    Console.WriteLine($"{nome}: {(ok ? "OK" : "FALHA")} (atual={atual}, esperado={esperado})");
}

static void RodarTestes()
{
    Console.WriteLine("== Testes CPF ==");
    AssertEq("52998224725", EhCpfValido("529.982.247-25"), true);
    AssertEq("11144477735", EhCpfValido("11144477735"), true);
    AssertEq("invalido", EhCpfValido("12345678900"), false);
}

static void RodarInterativo()
{
    Console.Write("Digite o CPF: ");
    var cpf = Console.ReadLine();
    Console.WriteLine(EhCpfValido(cpf) ? "CPF valido" : "CPF invalido");
}

bool executarTestes = true;
bool executarInterativo = false;

if (executarTestes) RodarTestes();
if (executarInterativo) RodarInterativo();

// DESAFIOS
// 1) Criar funcao que formata CPF (###.###.###-##)
// 2) Repetir ate o CPF ser valido
