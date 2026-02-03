// ======================================================
// GraphQL - Explicacao passo a passo (conceitual)
// ======================================================
// Este arquivo e um resumo didatico. Ele nao executa, serve como guia.
//
// 1) O cliente envia uma query dizendo exatamente o que quer:
//
// {
//   user(id: "1") {
//     id
//     name
//     email
//   }
// }
//
// 2) O servidor valida no schema:
//
// type User {
//   id: ID!
//   name: String!
//   email: String!
// }
//
// type Query {
//   user(id: ID!): User
// }
//
// 3) O resolver busca no banco e devolve os dados.
//
// Exemplo de resolver (pseudo C#):
//
// public class Query
// {
//     public User GetUser(string id) => repository.Find(id);
// }
//
// 4) A resposta vem exatamente no formato pedido.
//
// Por que isso e util?
// - Evita dados a mais.
// - O cliente monta a resposta.
// - Uma unica chamada pode trazer dados de varias tabelas.
//
// Desafios:
// 1) Criar types User e Post.
// 2) Criar uma mutation CreateUser.
// 3) Criar um resolver que retorna lista.
