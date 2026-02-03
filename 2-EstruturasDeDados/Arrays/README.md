# Arrays - Guia Detalhado

## O que e um array?
Array e uma colecao de elementos do mesmo tipo, guardados em memoria **de forma contigua**. Cada elemento tem um indice (0, 1, 2...).

## Modelo mental
Imagine uma linha de caixas numeradas:
```
indice:  0   1   2   3
valor : [A] [B] [C] [D]
```
- Acesso direto: `array[2]` pega o valor na posicao 2.

## Como funciona por baixo dos panos
- O array guarda todos os elementos lado a lado na memoria.
- Para acessar o indice `i`, o computador calcula:
  `endereco = endereco_base + (i * tamanho_do_tipo)`
- Isso torna o acesso **O(1)** (tempo constante).

## Operacoes basicas (e custo)
- **Ler por indice**: O(1)
- **Escrever por indice**: O(1)
- **Inserir no meio**: O(n) (precisa mover elementos)
- **Remover do meio**: O(n) (precisa mover elementos)

## Como criar um array em C#
```csharp
int[] numeros = new int[5];      // tamanho fixo
int[] pares = new int[] { 2, 4 };
string[] nomes = { "Ana", "Joao" };
```

## Exemplo completo (passo a passo)
1. Criar o array.
2. Preencher valores.
3. Percorrer com for.
```csharp
int[] numeros = { 10, 20, 30 };
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
```

## Quando usar?
- Quando o tamanho e fixo.
- Quando o acesso por indice precisa ser rapido.
- Quando a insercao/remoção no meio nao e frequente.

## Erros comuns
- Indice fora do limite (ex: `numeros[5]` em array de tamanho 5).
- Esquecer que o primeiro indice e 0.

## Exercicios sugeridos
1. Somar elementos.
2. Maior e menor numero.
3. Remover duplicados.
