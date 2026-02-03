# Dicionarios (Map) - Guia Detalhado

## O que e um dicionario?
Dicionario guarda pares **chave -> valor**. A chave identifica o valor.

Exemplo:
```
"nome" -> "Gustavo"
"idade" -> 25
```

## Como funciona por baixo dos panos
Dicionarios usam **hash table**:
1. A chave vira um numero (hash).
2. O hash aponta para um indice interno.
3. Isso permite acesso rapido.

## Operacoes basicas (e custo)
- **Add**: O(1) medio
- **Update**: O(1) medio
- **ContainsKey**: O(1) medio
- **Remove**: O(1) medio

## Como criar em C#
```csharp
var dict = new Dictionary<string, int>();
dict["mae"] = 1;
dict["pai"] = 2;

if (dict.ContainsKey("mae"))
    Console.WriteLine(dict["mae"]);
```

## Quando usar?
- Contar frequencias.
- Associar nomes a valores.
- Tradutor simples.
- Cache.

## Erros comuns
- Achar que a ordem importa (na maioria dos casos, nao).
- Usar chave duplicada sem atualizar.

## Exercicios
1. Contador de palavras.
2. Tradutor simples.
3. Agrupar anagramas.
