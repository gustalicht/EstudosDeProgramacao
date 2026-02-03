# APIs GraphQL - Guia Profundo (Sem Resumo)

## O que e GraphQL?
GraphQL e uma linguagem de consulta para APIs. O cliente descreve exatamente os dados que quer.

------------------------------------------------------------

## Como funciona (passo a passo)
1. Cliente envia uma query.
2. Servidor valida no schema.
3. Resolver busca os dados.
4. Servidor responde somente com o que foi pedido.

------------------------------------------------------------

## Componentes essenciais
- **Schema**: define tipos e operacoes.
- **Query**: leitura.
- **Mutation**: escrita.
- **Resolver**: logica que busca dados.

------------------------------------------------------------

## Exemplo de schema simples
```graphql
type User {
  id: ID!
  name: String!
  email: String!
}

type Query {
  user(id: ID!): User
}
```

## Exemplo de query
```graphql
{
  user(id: "1") {
    id
    name
  }
}
```

------------------------------------------------------------

## Vantagens
- Evita dados a mais.
- Frontend controla o formato.
- Reduz numero de endpoints.

## Desvantagens
- Pode gerar queries complexas.
- Precisa de controle de custo.

------------------------------------------------------------

## Quando usar?
- Frontend com telas variadas.
- Muitos consumidores com necessidades diferentes.

------------------------------------------------------------

## Exercicios
1. Criar schema User e Post.
2. Criar mutation CreateUser.
3. Implementar resolver com lista.
