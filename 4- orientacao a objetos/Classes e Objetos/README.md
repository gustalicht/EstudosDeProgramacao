# Classes e Objetos - Guia Detalhado

## O que e uma classe?
Classe e um molde que define como um objeto deve ser.

## O que e um objeto?
Objeto e uma instancia de uma classe (um "exemplar" do molde).

## Partes de uma classe
- **Atributos**: dados (ex: nome, idade)
- **Metodos**: acoes (ex: andar, falar)
- **Construtor**: inicializa o objeto

## Exemplo basico
```csharp
class Pessoa
{
    public string Nome;
    public int Idade;

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Ola, meu nome e {Nome}");
    }
}
```

## Encapsulamento (proteger dados)
Use propriedades para controlar acesso:
```csharp
public int Idade { get; private set; }
```

## Exercicios
1. Criar classe ContaBancaria.
2. Criar metodo Depositar e Sacar.
3. Impedir saldo negativo.
