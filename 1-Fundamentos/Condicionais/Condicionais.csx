using System;

// ======================================================
// OBJETIVO
// Mostrar exemplos de condicionais em C#.
// ======================================================

// 1) IF / ELSE IF / ELSE
int nota = 85;
if (nota >= 90)
    Console.WriteLine("A");
else if (nota >= 80)
    Console.WriteLine("B");
else
    Console.WriteLine("C");

// 2) SWITCH
string cor = "verde";
switch (cor)
{
    case "vermelho":
        Console.WriteLine("Pare");
        break;
    case "amarelo":
        Console.WriteLine("Atencao");
        break;
    case "verde":
        Console.WriteLine("Siga");
        break;
    default:
        Console.WriteLine("Cor invalida");
        break;
}

// 3) Ternario
int idade = 18;
string status = idade >= 18 ? "Maior" : "Menor";
Console.WriteLine(status);

// 4) Operadores logicos
bool temCarteira = true;
if (idade >= 18 && temCarteira)
    Console.WriteLine("Pode dirigir");

// DESAFIO
// 1) Transformar os exemplos acima em funcoes.
// 2) Criar um menu de opcoes usando switch.
