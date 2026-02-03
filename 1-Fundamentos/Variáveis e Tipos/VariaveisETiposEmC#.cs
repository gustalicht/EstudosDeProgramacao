// Exemplos basicos de tipos em C# (top-level).
int idade = 25;
double altura = 1.75;
bool aprovado = true;
char inicial = 'G';
string nome = "Gustavo";
var teste = 55; // tipo inferido
const double ValorConstante = 3.14; // constante

Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}");
Console.WriteLine($"Aprovado: {aprovado}, Inicial: {inicial}");
Console.WriteLine($"Tipo de 'teste': {teste.GetType().Name}");
Console.WriteLine($"Constante: {ValorConstante}");

// DESAFIO
// 1) Criar exemplos com decimal, long e DateTime.
// 2) Diferenca entre var e dynamic.
