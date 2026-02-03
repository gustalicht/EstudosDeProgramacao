# Testes - Guia Profundo (Sem Resumo)

## 1) Por que testar?
Testes evitam regressao, permitem refatorar e garantem confiabilidade. Um senior nunca confia apenas em testes manuais.

------------------------------------------------------------

## 2) Piramide de testes (o modelo mental)
- **Unit**: muitos, rapidos, baratos.
- **Integration**: menos, validam conexoes reais.
- **E2E**: poucos, caros, validam o fluxo completo.

Se voce tem muitos testes E2E e poucos unit, sua base esta fraca.

------------------------------------------------------------

## 3) Como escrever um teste (passo a passo)
1. **Escolha uma funcao pequena**.
2. **Liste entradas e saidas esperadas**.
3. **Crie casos normais e casos de borda**.
4. **Escreva o teste usando AAA**:
   - Arrange: preparar dados
   - Act: executar
   - Assert: verificar

------------------------------------------------------------

## 4) O que testar primeiro
- Regras de negocio.
- Transformacoes de dados.
- Validacoes.

Se uma regra quebrar, o sistema quebra. Entao teste regras primeiro.

------------------------------------------------------------

## 5) Tipos de testes

### Unit
- Testa uma funcao/classe isolada.
- Usa mocks para dependencias.

### Integration
- Testa integração real (DB, API, fila).
- Pode usar banco temporario.

### E2E
- Simula usuario usando o sistema completo.

------------------------------------------------------------

## 6) Mocks, Fakes e Stubs
- **Mock**: simula e verifica chamadas.
- **Fake**: implementacao simples real.
- **Stub**: retorna valor fixo.

Use mocks quando precisa verificar chamadas. Use fakes quando quer algo mais real.

------------------------------------------------------------

## 7) Exemplo de teste unitario (C#)
```csharp
[Fact]
public void Soma_DeveRetornarResultadoCorreto()
{
    var resultado = Soma(2, 3);
    Assert.Equal(5, resultado);
}
```

------------------------------------------------------------

## 8) Exemplo de teste de integracao (C#)
- Usa `WebApplicationFactory`.
- Faz request real na API.

------------------------------------------------------------

## 9) Erros comuns
- Teste que depende de ordem.
- Teste que usa data/hora real sem controle.
- Teste que quebra por detalhes insignificantes.

------------------------------------------------------------

## 10) Checklist de qualidade
- O teste falha quando deve?
- O teste e rapido?
- O teste e legivel?

------------------------------------------------------------

## Exercicios
1. Criar testes unitarios para calculadora.
2. Criar teste de integracao para endpoint GET.
3. Criar teste E2E simples.
