# Condicionais — Guia Completo

## O que sao condicionais?
Condicionais permitem que o programa tome decisoes. Com elas, o codigo escolhe caminhos diferentes dependendo de uma condicao (verdadeiro ou falso).

## Quando usar?
- Validar entrada do usuario.
- Decidir o que mostrar ou executar.
- Aplicar regras de negocio (ex: descontos, aprovacao, status).

## Tipos principais

### 1) if / else if / else
Use quando voce precisa avaliar condicoes em sequencia.

Exemplo:
```csharp
int nota = 85;
if (nota >= 90)
    Console.WriteLine("A");
else if (nota >= 80)
    Console.WriteLine("B");
else
    Console.WriteLine("C");
```

### 2) switch
Use quando comparar o mesmo valor contra opcoes fixas.

Exemplo:
```csharp
string cor = "verde";
switch (cor)
{
    case "vermelho": Console.WriteLine("Pare"); break;
    case "amarelo": Console.WriteLine("Atencao"); break;
    case "verde": Console.WriteLine("Siga"); break;
    default: Console.WriteLine("Cor invalida"); break;
}
```

### 3) switch expression (C# moderno)
Mais compacto quando voce quer retornar um valor.

```csharp
string conceito = nota switch
{
    >= 90 => "A",
    >= 80 => "B",
    _ => "C"
};
```

### 4) Operador ternario (?:)
Usado para escolhas simples em uma linha.

```csharp
string status = idade >= 18 ? "maior" : "menor";
```

## Dicas importantes
- Comece validando dados antes de aplicar regras.
- Deixe as condicoes mais especificas primeiro.
- Use `switch` quando houver muitas opcoes fixas.

## Erros comuns
- Ordem errada nos ifs (ex: `>= 60` antes de `>= 90`).
- Esquecer o `default` no switch.
- Escrever condicoes redundantes.

## Exercicios sugeridos
- Simulador de semaforo.
- Verificador de ano bissexto.
- Avaliador de notas.
