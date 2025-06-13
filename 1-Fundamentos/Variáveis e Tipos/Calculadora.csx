Console.WriteLine("Calculadora");

Console.WriteLine("Digite o primeiro Número");
double primeiro = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escolha a operação:(+,-,*,/):");
string operacao = Console.ReadLine();

Console.WriteLine("Digite o Segundo Número");
double Segundo = Convert.ToDouble(Console.ReadLine());

double resultado = 0; 

switch (operacao) 
{
    case "+": 
        resultado = primeiro + Segundo;
        break;
    case "-":
        resultado = primeiro - Segundo;
        break;
    case "*":
        resultado = primeiro * Segundo;
        break;
    case "/":
       resultado = segundo != 0 ? primeiro / segundo : throw new DivideByZeroException("Não pode dividir por zero!");

        break;

    default:// além do default, eu consigo usar mais coisas aqui com switch?
        Console.WriteLine("Opção inválida!");
        return; // quando usar o return? 
}


Console.WriteLine($"Resultado {resultado}");