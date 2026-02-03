# Abstracao - Guia Detalhado

## O que e abstracao?
Abstracao e focar no que importa e esconder detalhes.

Exemplo do mundo real:
- Voce dirige um carro sem saber como o motor funciona.

## Por que usar?
- Reduz complexidade.
- Deixa o codigo mais facil de entender.
- Permite mudar detalhes internos sem quebrar o resto.

## Como fazer em C#
1. **Classes abstratas**: podem ter metodos com e sem implementacao.
2. **Interfaces**: definem apenas contratos.

## Exemplo simples
```csharp
abstract class Animal
{
    public abstract void FazerSom();
}

class Cachorro : Animal
{
    public override void FazerSom() => Console.WriteLine("Au");
}
```

## Quando usar classes abstratas?
- Quando existe comportamento comum.
- Quando voce quer forcar implementacoes nas classes filhas.

## Quando usar interfaces?
- Quando precisa de contrato sem implementacao.
- Quando uma classe pode ter varios "papéis".

## Exercicios
1. Criar classe abstrata Forma.
2. Criar classes Circulo e Retangulo.
3. Calcular area.
