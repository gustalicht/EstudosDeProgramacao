# APIs GraphQL - Guia Detalhado

## O que e GraphQL?
GraphQL e uma linguagem de consulta para APIs. O cliente pede exatamente os dados que precisa.

## Diferenca principal para REST
- REST: o servidor define respostas fixas por endpoint.
- GraphQL: o cliente monta a resposta desejada na consulta.

## Conceitos principais
- **Schema**: define os tipos e as operacoes disponiveis.
- **Query**: leitura de dados.
- **Mutation**: alteracao de dados.
- **Resolver**: funcao que busca o dado.

## Modelo mental (passo a passo)
1. O cliente envia uma query.
2. O servidor valida no schema.
3. O resolver busca os dados.
4. O servidor responde apenas com o que foi pedido.

## Exemplo de query
```
{
  user(id: "1") {
    id
    name
    email
  }
}
```

## Quando usar?
- Quando o frontend precisa de dados flexiveis.
- Quando existe muito overfetch (dados a mais).

## Exercicios
1. Criar um schema simples (User, Post).
2. Implementar uma query e uma mutation.
