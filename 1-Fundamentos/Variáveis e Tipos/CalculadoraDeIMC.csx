//  CalculadoraDeIMC.csx
// Resumo: Calcula o IMC da pessoa com base no peso e altura.
// Fórmula:

// csharp
// Copiar
// Editar
// IMC = peso / (altura * altura)
// Classificação:

// < 18.5: Abaixo do peso

// 18.5 – 24.9: Normal

// 25 – 29.9: Sobrepeso

// 30+: Obesidade



Console.WriteLine("Calculadora de IMC");

Console.WriteLine("Digite a sua altura");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o seu peso");
double peso = double.Parse(Console.ReadLine());

double IMC = peso / (altura * altura);

string rank = "";

if (IMC < 18.5)
{
    rank = "magrelo";
}
else if (IMC >= 18.5 && IMC < 25)
{
    rank = "peso normal";
}
else if (IMC >= 25 && IMC < 30)
{
    rank = "gordo";
}
else if (IMC > 30)
{
    rank = "Obesao";
}
// < 18.5: Abaixo do peso

// 18.5 – 24.9: Normal

// 25 – 29.9: Sobrepeso

// 30+: Obesidade



Console.WriteLine($"O seu IMC é {IMC:F2} e sua classificação é {rank}");
