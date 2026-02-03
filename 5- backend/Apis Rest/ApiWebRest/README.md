# ApiWebRest (Razor Pages) - Guia Profundo

## O que e Razor Pages?
E um modelo de pagina em que cada pagina tem:
- `.cshtml` (HTML + Razor)
- `.cshtml.cs` (code-behind)

## Fluxo (passo a passo)
1. Usuario acessa /Index.
2. Razor carrega o arquivo Index.cshtml.
3. Code-behind executa OnGet/OnPost.
4. HTML final e enviado ao navegador.

## Quando usar?
- Sites simples.
- Formularios pequenos.
- Painel admin basico.

## Estrutura
- `Pages/Index.cshtml` = view
- `Pages/Index.cshtml.cs` = logica
- `Program.cs` = pipeline

## Exercicios
1. Criar pagina About.
2. Criar formulario e tratar OnPost.
3. Criar layout personalizado.
