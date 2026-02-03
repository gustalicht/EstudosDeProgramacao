# Busca (Linear e Binaria) - Guia Detalhado

## O que e busca?
Buscar e encontrar um elemento dentro de uma colecao (array, lista, etc.).

## Tipos principais
### 1) Busca linear
- Percorre elemento por elemento.
- Funciona em qualquer lista (ordenada ou nao).
- Complexidade: O(n).

### 2) Busca binaria
- So funciona em lista **ordenada**.
- Divide o problema ao meio.
- Complexidade: O(log n).

## Busca linear (passo a passo)
1. Comece no indice 0.
2. Compare com o valor procurado.
3. Se encontrou, pare.
4. Se nao, avance e continue.

## Busca binaria (passo a passo)
1. Defina inicio e fim.
2. Calcule o meio.
3. Compare o valor do meio com o alvo.
4. Se o alvo for menor, reduza o fim.
5. Se o alvo for maior, aumente o inicio.
6. Repita ate achar ou terminar.

## Erros comuns
- Usar busca binaria em lista nao ordenada.
- Calcular o meio errado.

## Exercicios
1. Busca linear em lista de alunos.
2. Busca binaria em lista ordenada.
