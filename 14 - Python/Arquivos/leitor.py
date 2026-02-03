# ======================================================
# Leitor de arquivo
# ======================================================

def ler_arquivo(caminho):
    try:
        with open(caminho, "r", encoding="utf-8") as f:
            return f.read()
    except FileNotFoundError:
        return "Arquivo nao encontrado"


print(ler_arquivo("exemplo.txt"))

# DESAFIO
# 1) Contar linhas.
# 2) Contar palavras.
