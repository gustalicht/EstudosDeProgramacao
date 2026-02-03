# Trilha Completa: do Junior ao Senior (Passo a Passo, Sem Resumo)

> Objetivo: transformar este repositorio em um guia de estudo completo para sair do nivel junior para senior.
> Leia na ordem. Execute os exemplos. Faça os desafios. Escreva respostas.

------------------------------------------------------------

## Como usar este repositorio

1) Leia o README de cada pasta antes de abrir os arquivos.
2) Rode o exemplo simples primeiro.
3) Reescreva com suas palavras o que o codigo faz.
4) Faça os desafios do arquivo.
5) Crie suas variantes (mude regras, dados, entradas).

Dica de estudo diario (rotina):
- 20 min leitura
- 40 min codigo
- 20 min desafios
- 10 min revisar erros

------------------------------------------------------------

# ETAPA 0 - Ferramentas e mentalidade (Fundacao)

## 0.1 Git e terminal
- Aprender comandos basicos: status, add, commit, branch, merge.
- Trabalhar sempre em pequenas mudancas.

Desafios:
1) Faça 3 commits pequenos.
2) Crie uma branch e faça merge.
3) Use git diff para entender mudancas.

## 0.2 Leitura de erros
- Leia mensagens de erro com calma.
- Identifique linha, arquivo, causa, contexto.

Desafios:
1) Provoque um erro de compilacao e corrija.
2) Provoque um erro de runtime e descubra a causa.

------------------------------------------------------------

# ETAPA 1 - Fundamentos (C# e JavaScript)

## 1.1 Variaveis e tipos (C# e JS)
- Entenda tipos primitivos (int, double, bool, string).
- Entenda conversao de tipos.
- Entenda diferença entre var e tipo explicito.

Exercicios:
1) Criar calculadora simples.
2) Converter temperatura e moeda.
3) Contar palavras em uma frase.

## 1.2 Condicionais
- if/else, switch, ternario.
- Usar para regras simples.

Exercicios:
1) Avaliador de notas.
2) Semaforo.
3) Ano bissexto.

## 1.3 Loops
- for, while, do-while, foreach.
- Entender condicao de parada.

Exercicios:
1) Tabuada.
2) Soma de 1 a N.
3) Validador de CPF.

## 1.4 Funcoes
- Funcoes pequenas e reutilizaveis.
- Evitar efeitos colaterais.

Exercicios:
1) Verificar primo.
2) Calculadora modular.
3) Conversor de base.

## 1.5 Entrada e saida
- Ler entradas com validacao.
- Exibir informacoes claras.

Exercicios:
1) Formulario de cadastro.
2) Quiz interativo.
3) Chat simples.

------------------------------------------------------------

# ETAPA 2 - Estruturas de Dados

## 2.1 Arrays
- Acesso direto por indice.
- Custo de insercao no meio.

## 2.2 Listas encadeadas
- Insercao/remocao eficientes no meio.
- Busca lenta.

## 2.3 Pilhas (Stack)
- LIFO
- Desfazer/refazer, validacao de parenteses.

## 2.4 Filas (Queue)
- FIFO
- Processamento em ordem.

## 2.5 Sets e Dicionarios
- Set: elementos unicos.
- Dictionary: chave -> valor.

## 2.6 Arvores e Grafos
- Arvore binaria de busca.
- BFS/DFS.

Desafios avançados:
1) Implementar uma estrutura do zero (sem usar classes prontas).
2) Analisar complexidade de cada operacao.

------------------------------------------------------------

# ETAPA 3 - Algoritmos

## 3.1 Busca
- Linear (O(n))
- Binaria (O(log n))

## 3.2 Ordenacao
- Bubble sort (didatico).
- Comparar com algoritmos mais eficientes.

Desafios:
1) Criar metricas (quantas comparacoes e trocas).
2) Implementar selection sort e comparar.

------------------------------------------------------------

# ETAPA 4 - Orientacao a Objetos (OOP)

## 4.1 Classes e objetos
- Estado e comportamento.

## 4.2 Encapsulamento
- Proteger dados com propriedades.

## 4.3 Abstracao
- Mostrar apenas o essencial.

## 4.4 Heranca e polimorfismo
- Reutilizacao de codigo.

## 4.5 Design Patterns
- Simple Factory, Factory Method, Singleton, Adapter, Command, Observer, Mediator, Template Method.

Desafios:
1) Criar um mini sistema de pedidos com classes.
2) Usar padrao Observer para notificar mudancas.

------------------------------------------------------------

# ETAPA 5 - Backend (parte mais importante)

## 5.1 Protocolos que voce deve dominar
- **HTTP/HTTPS**: verbos, headers, status codes, TLS.
- **TCP/UDP**: confiabilidade vs velocidade.
- **DNS**: como nomes viram IPs.
- **REST**: recursos e verbs.
- **GraphQL**: queries e schema.
- **gRPC**: Protobuf e RPC.
- **WebSocket**: comunicacao em tempo real.
- **AMQP** (RabbitMQ): filas.

## 5.2 Como criar uma API do zero (passo a passo)
1) Criar projeto.
2) Definir entidade (Model).
3) Criar DTO.
4) Criar DbContext.
5) Criar Controller.
6) Criar endpoints CRUD.
7) Adicionar validacoes.
8) Adicionar Swagger.
9) Adicionar logs.
10) Testar (unit e integration).

## 5.3 O que saber por baixo dos panos
- Como a request chega (DNS -> TCP -> HTTP).
- Como o servidor parseia JSON.
- Como o ORM gera SQL.
- Como o middleware encadeia requests.

Desafios:
1) Criar API com paginacao.
2) Criar API com autenticacao (JWT).
3) Criar API com cache.

------------------------------------------------------------

# ETAPA 6 - Frontend

## 6.1 HTML
- Estrutura e semantica.

## 6.2 CSS
- Layout (Flex, Grid).
- Responsividade.

## 6.3 JavaScript
- DOM, eventos, estado.

Desafios:
1) Criar formulario completo com validacao.
2) Criar to-do list com localStorage.
3) Criar um mini portfolio.

------------------------------------------------------------

# ETAPA 7 - Testes

## 7.1 Tipos
- Unit
- Integration
- E2E

## 7.2 O que testar
- Regras de negocio.
- Fluxos principais.
- Erros esperados.

Desafios:
1) Testar API com WebApplicationFactory.
2) Criar mocks.

------------------------------------------------------------

# ETAPA 8 - Arquitetura

## 8.1 Camadas e Clean Architecture
- Separar dominio, aplicacao e infraestrutura.

## 8.2 DDD basico
- Entidades, value objects, agregados.

## 8.3 Microservices
- Quando usar e quando nao.

Desafios:
1) Refatorar um CRUD para Clean Architecture.

------------------------------------------------------------

# ETAPA 9 - Observabilidade

- Logs estruturados
- Metricas
- Tracing

Desafios:
1) Criar logs com contexto.
2) Expor metricas simples.

------------------------------------------------------------

# ETAPA 10 - Seguranca

- OWASP Top 10
- Autenticacao (JWT, OAuth)
- Autorizacao (roles/claims)

Desafios:
1) Proteger endpoint com JWT.
2) Validar entrada para evitar injection.

------------------------------------------------------------

# ETAPA 11 - DevOps

- CI/CD
- Docker
- Deploy

Desafios:
1) Criar pipeline simples (build + test).
2) Criar Dockerfile.

------------------------------------------------------------

# ETAPA 12 - Projetos e Portfolio

- Escolha 2 projetos completos.
- Documente tudo.
- Mostre testes.
- Mostre deploy.

------------------------------------------------------------

# ETAPA 13 - Python (Nova trilha)

- Criar base em Python.
- Praticar scripts simples.
- Entender OOP em Python.

Veja a pasta "14 - Python".
