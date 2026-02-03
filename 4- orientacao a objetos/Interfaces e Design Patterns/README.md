# Interfaces e Design Patterns - Guia Detalhado

## O que e uma interface?
Interface define um contrato. Ela diz **o que** uma classe precisa fazer, mas nao diz **como**.

Exemplo:
```csharp
interface IImprimivel
{
    void Imprimir();
}
```

## Por que usar interfaces?
- Permitem classes diferentes seguirem o mesmo contrato.
- Facilita testes (mock).
- Reduz acoplamento.

## O que sao Design Patterns?
Padroes de projeto sao solucoes reutilizaveis para problemas comuns.

## Como estudar patterns (passo a passo)
1. Entenda o problema que o pattern resolve.
2. Aprenda a estrutura (classes principais).
3. Implemente um exemplo pequeno.
4. Compare com a solucao sem pattern.

## Patterns desta pasta
- Simple Factory
- Factory Method
- Singleton
- Adapter
- Command
- Observer
- Mediator
- Template Method

## Dica
Nao use pattern por moda. Use quando realmente simplifica.
