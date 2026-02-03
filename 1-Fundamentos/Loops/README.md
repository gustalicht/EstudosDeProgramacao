# Loops (Repeticao) — Guia Completo

## O que e um loop?
Um loop (ou repeticao) e uma estrutura que executa o mesmo bloco de codigo varias vezes. Ele e usado quando precisamos repetir uma acao (ex: imprimir numeros, percorrer listas, validar entrada, etc.).

## Tipos de loops em C#

### 1) while
- **Quando usar:** quando voce nao sabe previamente quantas vezes vai repetir.
- **Como funciona:** ele verifica a condicao antes de cada repeticao. Se a condicao for falsa de inicio, o bloco nao executa.

Exemplo:
```csharp
int i = 1;
while (i <= 3)
{
    Console.WriteLine(i);
    i++;
}
```

### 2) do...while
- **Quando usar:** quando voce precisa executar pelo menos uma vez.
- **Como funciona:** executa o bloco primeiro e so depois verifica a condicao.

Exemplo:
```csharp
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 3);
```

### 3) for
- **Quando usar:** quando voce sabe a quantidade exata de repeticoes.
- **Como funciona:** junta inicializacao, condicao e incremento no mesmo lugar.

Exemplo:
```csharp
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine(i);
}
```

### 4) foreach
- **Quando usar:** para percorrer colecoes (arrays, listas).
- **Como funciona:** itera automaticamente por cada elemento.

Exemplo:
```csharp
string[] frutas = { "Maçã", "Banana" };
foreach (var fruta in frutas)
{
    Console.WriteLine(fruta);
}
```

## Como escolher o loop certo?
- **Nao sei quantas vezes:** while
- **Preciso executar pelo menos uma vez:** do...while
- **Sei quantas vezes:** for
- **Percorrer colecao:** foreach

## Erros comuns
- **Loop infinito:** esquecer de atualizar a variavel de controle.
- **Condicao errada:** usar < quando deveria usar <= (ou vice-versa).
- **Indice fora do limite:** acessar lista com indice invalido.

## Dica de estudo (passo a passo)
1. Entenda a condicao de parada.
2. Defina a variavel de controle.
3. Atualize a variavel corretamente dentro do loop.
4. Teste com casos pequenos primeiro.

## Exercicios recomendados
- Contar de 1 a 10.
- Somar todos os numeros de 1 a N.
- Gerar tabuada.
- Validar CPF com repeticao.
