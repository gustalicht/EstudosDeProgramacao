# DevOps - Guia Profundo (Sem Resumo)

## 1) Objetivo
Automatizar o caminho do codigo ate producao com qualidade.

------------------------------------------------------------

## 2) CI (Integracao Continua)
- Rodar build e testes a cada commit.
- Detectar erros cedo.

### Pipeline basico
1. Checkout
2. Restore dependencias
3. Build
4. Testes
5. Artefato

------------------------------------------------------------

## 3) CD (Entrega Continua)
- Deploy automatizado em staging/prod.

------------------------------------------------------------

## 4) Docker (base)
- **Imagem**: pacote do app.
- **Container**: instancia rodando.

### Passo a passo
1. Criar Dockerfile
2. Build da imagem
3. Run do container

------------------------------------------------------------

## 5) Ambientes
- Dev
- Staging
- Prod

Nunca teste direto em prod.

------------------------------------------------------------

## 6) Deploy strategies
- Blue/Green
- Canary

------------------------------------------------------------

## Exercicios
1. Criar pipeline simples.
2. Criar Dockerfile para API.
3. Subir app com docker-compose.
