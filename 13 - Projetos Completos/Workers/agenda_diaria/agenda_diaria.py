# ======================================================
# Worker: agenda diaria
# ======================================================
# PASSO A PASSO
# 1) Obter data atual.
# 2) Criar arquivo de log.
# 3) Registrar execucao.

import datetime
from pathlib import Path

pasta = Path(__file__).parent
log = pasta / "execucoes.log"

agora = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")

with open(log, "a", encoding="utf-8") as f:
    f.write(f"Executado em {agora}\n")

print("Worker executado:", agora)
