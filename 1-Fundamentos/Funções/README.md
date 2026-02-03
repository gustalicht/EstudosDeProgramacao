# Funcoes — Guia Completo

## O que e uma funcao?
Uma funcao e um bloco de codigo reutilizavel que recebe entradas (parametros) e retorna uma saida (ou apenas executa algo).

## Por que usar?
- Reutilizar codigo.
- Organizar melhor o programa.
- Facilitar testes.

## Estrutura basica
```csharp
static int Soma(int a, int b)
{
    return a + b;
}
```

## Boas praticas
- Funcoes pequenas e com uma responsabilidade.
- Nome claro (verbo + objeto: CalcularImc, ValidarCpf).
- Evitar efeitos colaterais quando possivel.

## Exercicios sugeridos
- Calculadora modular.
- Verificador de primo.
- Conversor de bases.
