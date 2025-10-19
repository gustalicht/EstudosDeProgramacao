// a ideia é criar um avaliador de nota.
//Resumo: Recebe a nota do aluno e retorna o conceito (A, B, C, D ou F).
// Lógica:

// Nota ≥ 90: A

// 80–89: B

// 70–79: C

// 60–69: D

// < 60: F



Console.WriteLine("Avaliador de Notas Primeira versão");
int notaDoAluno = 85;

if (notaDoAluno >= 90)
{
    Console.WriteLine("Conceito A");
}
else if (notaDoAluno >= 80)
{
    Console.WriteLine("Conceito B");
}
else if (notaDoAluno >= 70)
{
    Console.WriteLine("Conceito C");
}
else if (notaDoAluno >= 60)
{
    Console.WriteLine("Conceito D");
}
else
{
    Console.WriteLine("Conceito F");
}
// a ideia aqui é ser super simples e direto. Depois eu vou evoluir esse código.


// aqui nesta versão a ideia é ler a nota via console e diminuir o uso de if else.
Console.WriteLine("Avaliador de Notas versão 2.0");
Console.Write("Digite a nota do aluno: ");
var input = Console.ReadLine();

// seguindo algumas convenções para validar antes de condicionais, assim diminui a complexidade ciclomática.
if (!int.TryParse(input, out int nota))
{
    Console.WriteLine("Entrada inválida. Por favor digite um número inteiro entre 0 e 100.");
}
else if (nota < 0 || nota > 100)
{
    Console.WriteLine("Nota fora do intervalo esperado (0-100). Selecione um valor válido.");
}
else
{
    string conceito = nota switch
    {
        >= 90 => "Conceito A",
        >= 80 => "Conceito B",
        >= 70 => "Conceito C",
        >= 60 => "Conceito D",
        _ => "Conceito F",
    };

    Console.WriteLine(conceito);
}

//Um switch expression em C# precisa produzir um valor compatível com o contexto de retorno — no seu caso cada branch estava chamando Console.WriteLine(...), que retorna void. Não existe um valor do tipo void que possa ser retornado por uma switch expression. Por isso o padrão correto é:
//Fazer o switch expression retornar um valor (por exemplo uma string) e depois chamar Console.WriteLine(...) com esse valor.
//Ou usar um switch statement tradicional (não expression) e dentro das cases chamar Console.WriteLine(...).
//existem alguns tipos de Switch;