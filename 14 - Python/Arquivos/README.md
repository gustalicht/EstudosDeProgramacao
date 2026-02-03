# Arquivos em Python - Guia Detalhado

## Leitura
```python
with open("arquivo.txt", "r", encoding="utf-8") as f:
    conteudo = f.read()
```

## Escrita
```python
with open("arquivo.txt", "w", encoding="utf-8") as f:
    f.write("texto")
```

## JSON
```python
import json
with open("dados.json", "r", encoding="utf-8") as f:
    dados = json.load(f)
```

## Exercicios
1. Ler arquivo e contar linhas.
2. Salvar lista em JSON.
