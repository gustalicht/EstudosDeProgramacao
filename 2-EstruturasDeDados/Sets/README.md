# Sets - Guia Detalhado

## O que e um set?
Set (conjunto) guarda elementos **unicos**. Se voce tentar inserir repetido, ele ignora.

## Modelo mental
```
Entrada: [1, 2, 2, 3]
Set:     {1, 2, 3}
```

## Como funciona por baixo dos panos
Set geralmente usa uma **hash table**.
- Cada elemento tem um hash.
- O hash aponta para um "balde" (bucket).
- Isso permite busca rapida.

## Operacoes basicas (e custo)
- **Add**: O(1) medio
- **Remove**: O(1) medio
- **Contains**: O(1) medio

## Como criar em C#
```csharp
var set = new HashSet<int>();
set.Add(1);
set.Add(2);
set.Add(2); // ignorado
```

## Operacoes de conjuntos
- **Uniao**: junta todos sem repetir
- **Intersecao**: apenas os comuns
- **Diferenca**: elementos de A que nao estao em B

## Quando usar?
- Remover duplicados.
- Verificar pertencimento rapido.
- Comparar conjuntos.

## Erros comuns
- Achar que mantem ordem (nao mantem).
- Usar set quando precisa de duplicatas.

## Exercicios
1. Uniao e intersecao.
2. Verificar subconjunto.
3. Remover duplicados de uma lista.
