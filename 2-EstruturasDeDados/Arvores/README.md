# Arvores - Guia Detalhado

## O que e uma arvore?
Estrutura hierarquica feita de **nos**. Cada no pode ter filhos.

## Modelo mental
```
        8
       / \
      3   10
     / \
    1   6
```

## Termos importantes
- **Raiz**: primeiro no.
- **Filhos**: nos abaixo.
- **Folhas**: nos sem filhos.
- **Altura**: maior caminho da raiz ate uma folha.

## Tipos comuns
### 1) Arvore Binaria
Cada no tem no maximo 2 filhos.

### 2) Arvore Binaria de Busca (BST)
- Valores menores vao para a esquerda.
- Valores maiores vao para a direita.

## Como funciona por baixo dos panos (BST)
**Inserir:**
1. Comparar com a raiz.
2. Se menor, ir para a esquerda.
3. Se maior, ir para a direita.
4. Repetir ate achar um lugar vazio.

**Buscar:**
1. Comparar com o no atual.
2. Se igual, achou.
3. Se menor, ir para a esquerda.
4. Se maior, ir para a direita.

## Percursos (traversals)
- **InOrder**: esquerda -> raiz -> direita (ordena em BST)
- **PreOrder**: raiz -> esquerda -> direita
- **PostOrder**: esquerda -> direita -> raiz

## Complexidade
- Em arvore balanceada: O(log n)
- Em arvore desbalanceada: O(n)

## Erros comuns
- Arvore desbalanceada vira lista.
- Esquecer de tratar null.

## Exercicios
1. Implementar BST.
2. Fazer InOrder/PreOrder/PostOrder.
3. Arvore de expressao.
