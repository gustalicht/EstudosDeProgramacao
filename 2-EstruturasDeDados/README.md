# Estruturas de Dados - Guia Detalhado (Visao Geral)

## O que sao estruturas de dados?
Estruturas de dados sao formas organizadas de guardar, acessar e modificar dados. A escolha certa deixa o codigo mais simples e mais rapido.

## Como escolher a estrutura certa (passo a passo)
1. **O que eu preciso fazer com os dados?**
   - Acessar por indice? (array, list)
   - Acessar por chave? (dictionary, hash table)
   - Manter ordem? (list, tree)
   - Sempre pegar o primeiro ou o ultimo? (queue, stack)
2. **Quantos elementos?**
   - Quantidade fixa: array
   - Quantidade variavel: list, linked list
3. **Operacoes mais frequentes?**
   - Inserir/remover no meio: linked list
   - Buscar rapidamente: hash table, tree
   - Processar em ordem de chegada: queue

## Mapa rapido (quando usar)
- **Array**: tamanho fixo, acesso rapido por indice.
- **List** (lista encadeada): insercao/remoção no meio com menos custo.
- **Stack** (pilha): LIFO, desfazer/refazer.
- **Queue** (fila): FIFO, processamento em ordem.
- **Set**: itens unicos, remover duplicados.
- **Dictionary/Map**: chave -> valor.
- **Hash Table**: base para set/dictionary.
- **Tree**: hierarquia, busca organizada.
- **Graph**: conexoes complexas entre itens.

## Como estudar (roteiro simples)
1. Entenda o conceito e o modelo mental.
2. Veja as operacoes basicas (add, remove, buscar).
3. Aprenda a complexidade (Big-O) de cada operacao.
4. Implemente um exemplo simples.
5. Compare com outra estrutura parecida.

## Erros comuns
- Escolher uma estrutura sem entender o custo.
- Usar array quando precisa de insercao frequente.
- Usar lista quando precisa de busca rapida.

## Pastas desta secao
- Arrays
- Listas
- Pilhas
- Filas
- Sets
- Dicionarios
- Hash Tables
- Arvores
- Grafos

## Proximo passo
Abra cada README dentro das pastas e siga os exemplos passo a passo.
