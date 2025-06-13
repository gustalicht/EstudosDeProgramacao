//Resumo: Um arquivo genérico para testar if, else if, else, switch.
//Lógica: Pode conter exemplos diversos com entrada de números, strings, etc.
// 🧠 RESUMO DE CONDICIONAIS EM C#
// 1. if, else if, else
// Quando usar:
// Quando você precisa de decisões simples ou múltiplas verificações em sequência.

// Exemplo:

// csharp
// Copiar
// Editar
// int nota = 85;

// if (nota >= 90)
//     Console.WriteLine("A");
// else if (nota >= 80)
//     Console.WriteLine("B");
// else
//     Console.WriteLine("C");
// Vantagens: Flexível, fácil de entender.
// Ideal para: Regras que mudam com base em valores.

// 2. switch
// Quando usar:
// Quando você quer comparar um valor com várias opções fixas (como strings ou números exatos).

// Exemplo:

// csharp
// Copiar
// Editar
// string cor = "verde";

// switch (cor)
// {
//     case "vermelho":
//         Console.WriteLine("Pare");
//         break;
//     case "amarelo":
//         Console.WriteLine("Atenção");
//         break;
//     case "verde":
//         Console.WriteLine("Siga");
//         break;
//     default:
//         Console.WriteLine("Cor inválida");
//         break;
// }
// Vantagens: Código mais limpo quando há muitas opções.
// Ideal para: Menus, cores, comandos.

// 3. Operador Ternário (? :)
// Quando usar:
// Para decisões rápidas em uma linha só.

// Exemplo:

// csharp
// Copiar
// Editar
// int idade = 18;
// string status = idade >= 18 ? "Maior de idade" : "Menor de idade";
// Vantagens: Compacto.
// Ideal para: Expressões curtas de decisão.

// 4. && (E) e || (OU)
// Quando usar:
// Quando você precisa de duas ou mais condições ao mesmo tempo.

// Exemplo:

// csharp
// Copiar
// Editar
// if (idade >= 18 && temCarteira)
//     Console.WriteLine("Pode dirigir");
