//todos os tipos de loops
Console.WriteLine("Loops em C#");

//Loop While
Console.WriteLine("Loop While");
int contadorWhile = 1;
while (contadorWhile <= 10)
{
    Console.WriteLine($"Contador While: {contadorWhile}");
    contadorWhile++;
}
//Loop Do While
Console.WriteLine("Loop Do While");
int contadorDoWhile = 1;
do
{
    Console.WriteLine($"Contador Do While: {contadorDoWhile}");
    contadorDoWhile++;
} while (contadorDoWhile <= 10);
//Loop For Each
Console.WriteLine("Loop For Each");
string[] frutas = { "Maçã", "Banana", "Laranja", "Uva", "Manga" };
foreach (var fruta in frutas)
{
    Console.WriteLine($"Fruta: {fruta}");
}
//Loop For
Console.WriteLine("Loop For");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Contador For: {i}");
}

