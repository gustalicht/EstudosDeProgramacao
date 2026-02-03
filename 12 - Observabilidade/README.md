# Observabilidade - Guia Profundo (Sem Resumo)

## 1) O que e observabilidade?
Capacidade de entender o sistema em producao sem adivinhar.

------------------------------------------------------------

## 2) Logs
- **Trace**: detalhes minimos.
- **Debug**: para dev.
- **Info**: fluxo normal.
- **Warn**: algo estranho.
- **Error**: falha.

Logs devem ter contexto (id de request, usuario, etc.).

------------------------------------------------------------

## 3) Metricas
- **Counter**: conta eventos.
- **Gauge**: valor atual.
- **Histogram**: distribucao.

Exemplo: contar requests por endpoint.

------------------------------------------------------------

## 4) Tracing
- Um **trace** tem varios **spans**.
- Cada span representa uma etapa.
- Ajuda a encontrar gargalos.

------------------------------------------------------------

## 5) Correlation ID
- Um ID unico por request.
- Facilita rastrear logs.

------------------------------------------------------------

## 6) SLI / SLO / SLA
- **SLI**: indicador (ex: latencia).
- **SLO**: meta (ex: 95% < 200ms).
- **SLA**: acordo com cliente.

------------------------------------------------------------

## Exercicios
1. Logar inicio e fim de request.
2. Medir latencia e gerar metricas.
3. Simular erro e rastrear.
