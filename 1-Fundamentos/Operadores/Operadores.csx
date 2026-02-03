// ======================================================
// RESUMO DE OPERADORES EM C#
// ======================================================

// 1) Aritmeticos: + - * / %
// 2) Relacionais: == != > < >= <=
// 3) Logicos: && || !
// 4) Atribuicao: = += -= *= /=
// 5) Ternario: condicao ? A : B

// EXEMPLOS RAPIDOS
int a = 10;
int b = 3;

Console.WriteLine(a + b); // 13
Console.WriteLine(a > b); // true
Console.WriteLine(a % b); // 1

string status = a > b ? "maior" : "menor";
Console.WriteLine(status);

// DESAFIO
// 1) Criar um menu que recebe uma operacao e aplica aos numeros.
// 2) Usar operadores logicos para validar idade e carteira.
