# Hash Tables - Guia Detalhado

## O que e uma hash table?
Uma hash table guarda dados usando uma funcao hash para localizar rapidamente onde cada item esta.

## Modelo mental
1. A chave vira um numero (hash).
2. O hash escolhe um "balde" (bucket).
3. O item fica naquele balde.

```
chave -> hash -> bucket
"ana" -> 42 -> bucket[42]
```

## Como funciona por baixo dos panos
- **Hash**: transforma a chave em numero.
- **Buckets**: cada posicao armazena um item ou uma lista.
- **Colisao**: quando duas chaves geram o mesmo hash.

### Colisoes: duas abordagens
1. **Encadeamento** (chaining): cada bucket guarda uma lista.
2. **Enderecamento aberto** (open addressing): procura a proxima posicao livre.

## Operacoes basicas (e custo)
- **Inserir**: O(1) medio
- **Buscar**: O(1) medio
- **Remover**: O(1) medio
- **Pior caso**: O(n) se muitas colisoes.

## Quando usar?
- Quando voce precisa de busca muito rapida por chave.
- Base para Dictionary e HashSet.

## Erros comuns
- Achar que sempre e O(1) (pior caso existe).
- Usar chave mutavel (hash muda).

## Exercicios
1. Verificar duplicatas.
2. Agrupar itens por categoria.
