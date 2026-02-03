# Grafos - Guia Detalhado

## O que e um grafo?
Grafo e uma estrutura com **vertices** (nos) e **arestas** (ligacoes).

Exemplo:
```
A --- B
|     |
C --- D
```

## Tipos de grafo
- **Direcionado**: arestas tem direcao (A -> B).
- **Nao direcionado**: A <-> B.
- **Ponderado**: arestas tem peso.

## Representacoes
### 1) Lista de adjacencia
Mais economica em memoria.
```
1 -> 2, 3
2 -> 4
```

### 2) Matriz de adjacencia
Mais simples de visualizar, mas gasta mais memoria.

## Algoritmos basicos

### BFS (Busca em Largura)
**Ideia:** visita por camadas.
**Usa:** fila.

Passo a passo:
1. Marcar origem como visitada.
2. Enfileirar origem.
3. Enquanto houver elementos na fila:
   - Desenfileirar
   - Visitar vizinhos nao visitados
   - Enfileirar vizinhos

### DFS (Busca em Profundidade)
**Ideia:** vai o mais fundo possivel.
**Usa:** recursao ou pilha.

Passo a passo:
1. Visitar origem.
2. Para cada vizinho nao visitado, chamar DFS.

### Dijkstra (menor caminho)
**Ideia:** sempre escolhe o no com menor distancia conhecida.
**Usa:** pesos positivos.

## Complexidade
- BFS/DFS: O(V + E)
- Dijkstra (sem fila de prioridade): O(V^2)

## Erros comuns
- Esquecer de marcar como visitado (loop infinito).
- Misturar grafo direcionado com nao direcionado.

## Exercicios
1. Implementar lista de adjacencia.
2. BFS e DFS.
3. Dijkstra simples.
