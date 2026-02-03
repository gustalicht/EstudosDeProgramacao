# ======================================================
# Worker: abrir apps e sites
# ======================================================
# PASSO A PASSO
# 1) Definir comandos ou URLs.
# 2) Abrir no sistema.

import os
import webbrowser

# Abrir site
webbrowser.open("https://news.ycombinator.com")

# Abrir aplicativo (exemplo: Notepad no Windows)
os.system("notepad.exe")

print("Apps abertos")
