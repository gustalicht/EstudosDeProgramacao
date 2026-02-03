# ======================================================
# Worker: backup simples
# ======================================================
# PASSO A PASSO
# 1) Definir origem e destino.
# 2) Copiar arquivos.
# 3) Registrar log.

import shutil
from pathlib import Path
import datetime

origem = Path.home() / "Documents"
destino = Path.home() / "Desktop" / "Backup_Documents"

if not destino.exists():
    destino.mkdir(parents=True)

for arquivo in origem.glob("*.txt"):
    shutil.copy2(arquivo, destino / arquivo.name)

log = destino / "backup.log"
with open(log, "a", encoding="utf-8") as f:
    f.write(f"Backup em {datetime.datetime.now()}\n")

print("Backup concluido")
