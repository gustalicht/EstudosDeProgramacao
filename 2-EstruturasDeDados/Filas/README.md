# Filas (Queue) - Guia Detalhado

## O que e uma fila?
Fila e uma estrutura **FIFO** (First In, First Out):
o primeiro a entrar e o primeiro a sair.

Pense numa fila de banco:
- Quem chega primeiro, e atendido primeiro.
- Quem chega depois, espera atras.

## Como pensar uma fila (modelo mental)
Uma fila tem dois pontos importantes:
- **Frente (front)**: de onde sai (dequeue).
- **Fim (rear)**: onde entra (enqueue).

Representacao simples:
```
frente --> [A] [B] [C] <-- fim
           ^            ^
         sai primeiro   entra por ultimo
```

## Operacoes basicas (com explicacao)

### 1) Enqueue (enfileirar)
**Objetivo:** colocar um elemento no fim da fila.

**Passo a passo:**
1. Achar a posicao do fim.
2. Inserir o novo elemento ali.
3. Avancar o ponteiro do fim.

### 2) Dequeue (desenfileirar)
**Objetivo:** remover o elemento da frente.

**Passo a passo:**
1. Verificar se a fila nao esta vazia.
2. Pegar o valor da frente.
3. Avancar o ponteiro da frente.
4. Devolver o valor removido.

### 3) Peek (ver frente)
**Objetivo:** olhar o primeiro elemento sem remover.

**Passo a passo:**
1. Verificar se a fila nao esta vazia.
2. Retornar o valor da frente.

## Como criar uma fila (na pratica)

### Usando a classe pronta do C#
```csharp
var fila = new Queue<string>();
fila.Enqueue("A");
fila.Enqueue("B");
fila.Enqueue("C");

Console.WriteLine(fila.Dequeue()); // A
Console.WriteLine(fila.Peek());    // B
```

### Criando uma fila "por baixo dos panos" (com array circular)
Aqui voce entende o algoritmo real.

**Ideia:**
- Usar um array fixo.
- Usar dois indices: `frente` e `fim`.
- Quando chegar no final, voltar pro comeco (circular).

```
Array: [ ] [ ] [ ] [ ]
frente = 0
fim = 0
```

**Enfileirar:**
1. colocar no `fim`
2. `fim = (fim + 1) % capacidade`

**Desenfileirar:**
1. pegar `frente`
2. `frente = (frente + 1) % capacidade`

Exemplo (simplificado):
```csharp
int[] dados = new int[3];
int frente = 0, fim = 0, tamanho = 0;

// Enqueue 10
dados[fim] = 10;
fim = (fim + 1) % 3;
tamanho++;
```

## Complexidade (custo)
- Enqueue: O(1)
- Dequeue: O(1)
- Peek: O(1)

## Erros comuns
- **Fila vazia:** tentar remover quando nao tem nada.
- **Fila cheia (array fixo):** tentar enfileirar sem espaco.
- **Esquecer de atualizar ponteiros:** gera loop infinito.

## Quando usar fila?
- Processamento por ordem (atendimento).
- Sistemas de tarefas (jobs).
- Mensageria (RabbitMQ, filas internas).

## Exercicios (sugeridos)
1. Simulador de fila de banco.
2. Fila circular.
3. Fila de mensagens.
4. Criar um menu interativo (enqueue/dequeue/peek).
