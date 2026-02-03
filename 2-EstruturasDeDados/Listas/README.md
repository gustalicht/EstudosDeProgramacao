# Listas Encadeadas - Guia Detalhado

## O que e uma lista encadeada?
E uma estrutura em que cada elemento (no) guarda um valor e um ponteiro para o proximo (e/ou anterior). Nao ha indices fixos.

## Modelo mental
```
[10] -> [20] -> [30] -> null
```
Cada no sabe quem vem depois.

## Como funciona por baixo dos panos
- Cada no fica em uma posicao separada da memoria.
- O acesso a um elemento precisa seguir os ponteiros.
- Isso torna a busca **O(n)**, mas a insercao no meio pode ser **O(1)** (se voce ja tiver o no anterior).

## Tipos
### 1) Lista simples
Cada no aponta apenas para o proximo.

### 2) Lista dupla
Cada no aponta para o proximo e para o anterior.

## Operacoes basicas (e custo)
- **Inserir no inicio**: O(1)
- **Inserir no fim**: O(n) (ou O(1) se tiver ponteiro para o fim)
- **Buscar**: O(n)
- **Remover**: O(n) (precisa encontrar o no anterior)

## Como criar (passo a passo)
1. Criar classe No (valor + proximo).
2. Guardar o primeiro no (head).
3. Percorrer ate achar o final.
4. Ligar o novo no no final.

Exemplo simplificado:
```csharp
class No { public int Valor; public No Proximo; }
```

## Quando usar?
- Quando precisa inserir/remover com frequencia no meio.
- Quando o tamanho varia muito e indices nao sao essenciais.

## Erros comuns
- Esquecer de ajustar ponteiros ao remover.
- Perder referencia do head.
- Criar loops (apontar para si mesmo sem querer).

## Exercicios
1. Implementar lista simples.
2. Implementar lista dupla.
3. Adicionar remove e busca.
