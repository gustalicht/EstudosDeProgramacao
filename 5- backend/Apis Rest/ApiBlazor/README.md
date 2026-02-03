# ApiBlazor (Blazor Server) - Guia Profundo

## O que e Blazor Server?
Blazor Server renderiza no servidor e envia atualizacoes via SignalR. O estado fica no servidor.

## Fluxo (passo a passo)
1. Usuario acessa pagina.
2. Servidor gera HTML inicial.
3. Conexao SignalR e criada.
4. Eventos do usuario vao para o servidor.
5. Servidor atualiza UI e manda diffs.

## Vantagens
- C# no frontend.
- Reutilizar logica do backend.

## Desvantagens
- Depende de conexao ativa.
- Mais consumo no servidor.

## Estrutura
- `Components/Pages`: paginas
- `Components/Layout`: layout
- `Program.cs`: pipeline

## Exercicios
1. Criar componente de lista.
2. Consumir API REST com HttpClient.
3. Criar formulario com validacao.
