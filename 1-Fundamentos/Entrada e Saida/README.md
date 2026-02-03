# Entrada e Saida — Guia Completo

## O que e entrada e saida?
- **Entrada (input)**: dados que o usuario fornece (ex: teclado).
- **Saida (output)**: o que o programa mostra (ex: console).

Em C#, usamos principalmente:
- `Console.ReadLine()` para ler texto.
- `Console.WriteLine()` para imprimir.

## Passo a passo basico
1. Pergunte algo ao usuario (Write).
2. Leia a resposta (ReadLine).
3. Converta o tipo, se necessario (int, double).
4. Use o valor no programa.

## Conversoes
- `int.TryParse()` e `double.TryParse()` evitam erros.
- Sempre valide a entrada antes de usar.

## Erros comuns
- Ler e converter sem validar (gera excecao).
- Assumir que o usuario sempre digita certo.

## Exercicios sugeridos
- Formulario simples.
- Quiz interativo.
- Chat com comandos.
