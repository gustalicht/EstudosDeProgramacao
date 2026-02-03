# ======================================================
# Worker: lembrete de ponto (sem automacao ilegal)
# ======================================================
# PASSO A PASSO
# 1) Exibir mensagem no console.
# 2) (Opcional) abrir pagina de ponto no navegador.

import webbrowser

print("LEMBRETE: registre seu ponto manualmente.")

# Opcional: abrir pagina (NAO envia nada automaticamente)
url = "https://exemplo.com/ponto"
webbrowser.open(url)
