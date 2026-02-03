# Pipelines - Guia Profundo (Sem Resumo)

## O que e pipeline?
Pipeline automatiza build, testes e deploy. Ele garante padrao e repete o mesmo processo sempre.

## Azure Pipelines (YAML) - como pensar
1. Trigger: quando rodar (ex: push na main).
2. Pool: onde rodar (agent).
3. Steps: comandos (restore, build, test, publish).

## O que voce deve dominar
- stages
- jobs
- steps
- variaveis
- artifacts

## Arquivos aqui
- azure-pipelines-dotnet.yml
- azure-pipelines-node.yml

## Desafios
1. Adicionar step de tests.
2. Publicar artifact.
3. Criar stage de deploy (simulado).
