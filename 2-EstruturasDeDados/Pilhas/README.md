# Pilhas (Stack) - Guia Detalhado

## O que e uma pilha?
Pilha e uma estrutura **LIFO** (Last In, First Out):
o ultimo a entrar e o primeiro a sair.

## Modelo mental
Pense em uma pilha de pratos:
- Voce coloca pratos em cima (push).
- Voce tira sempre o de cima (pop).

```
Topo -> [C]
        [B]
        [A]
```

## Como funciona por baixo dos panos
Duas formas comuns:
1. **Array com indice de topo**
2. **Lista encadeada** (topo e o head)

### Algoritmo simples (array)
- `topo` guarda a posicao do ultimo elemento.
- **Push**: coloca em `topo + 1` e incrementa.
- **Pop**: pega `topo` e decrementa.

## Operacoes basicas (e custo)
- **Push**: O(1)
- **Pop**: O(1)
- **Peek**: O(1)

## Como criar em C#
```csharp
var pilha = new Stack<int>();
pilha.Push(10);
pilha.Push(20);
Console.WriteLine(pilha.Pop()); // 20
Console.WriteLine(pilha.Peek()); // 10
```

## Quando usar?
- Desfazer/refazer.
- Validar parenteses.
- Converter bases.
- Avaliar expressoes.

## Erros comuns
- Pop em pilha vazia.
- Esquecer de atualizar o topo.

## Exercicios
1. Verificar parenteses balanceados.
2. Conversor de base.
3. Implementar pilha com array.
