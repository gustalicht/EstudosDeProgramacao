# ======================================================
# Worker: limpeza de temp
# ======================================================
# PASSO A PASSO
# 1) Definir pasta temp.
# 2) Listar arquivos.
# 3) Remover arquivos antigos.

from pathlib import Path
import time

pasta_temp = Path.home() / "AppData" / "Local" / "Temp"

agora = time.time()
limite = 7 * 24 * 60 * 60  # 7 dias

apagados = 0

for arquivo in pasta_temp.glob("*"):
    try:
        if arquivo.is_file():
            idade = agora - arquivo.stat().st_mtime
            if idade > limite:
                arquivo.unlink()
                apagados += 1
    except Exception:
        pass

print("Arquivos apagados:", apagados)
