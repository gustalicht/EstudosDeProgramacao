using System;

// ======================================================
// OBJETIVO
// Mostrar TODOS os tipos de loops em C# e quando usar.
// ======================================================

Console.WriteLine("Loops em C#");

// 1) WHILE
// - Use quando NAO sabe quantas repeticoes vao acontecer.
Console.WriteLine("Loop While");
int contadorWhile = 1; // passo 1: inicializar
while (contadorWhile <= 5) // passo 2: condicao
{
    Console.WriteLine($"Contador While: {contadorWhile}");
    contadorWhile++; // passo 3: atualizar para evitar loop infinito
}

// 2) DO WHILE
// - Sempre executa pelo menos 1 vez.
Console.WriteLine("Loop Do While");
int contadorDoWhile = 1;
do
{
    Console.WriteLine($"Contador Do While: {contadorDoWhile}");
    contadorDoWhile++;
} while (contadorDoWhile <= 5);

// 3) FOREACH
// - Melhor para percorrer colecoes.
Console.WriteLine("Loop For Each");
string[] frutas = { "Maca", "Banana", "Laranja" };
foreach (var fruta in frutas)
{
    Console.WriteLine($"Fruta: {fruta}");
}

// 4) FOR
// - Use quando sabe o numero de repeticoes.
Console.WriteLine("Loop For");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Contador For: {i}");
}

// DESAFIOS
// 1) Repetir um menu ate a opcao "sair".
// 2) Percorrer uma lista de numeros e somar os pares.
