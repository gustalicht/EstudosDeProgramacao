# ======================================================
# Projeto: CLI de tarefas (to-do)
# ======================================================
# PASSO A PASSO
# 1) Criar lista de tarefas em memoria.
# 2) Criar menu.
# 3) Permitir adicionar e listar.


tarefas = []

while True:
    print("\n1) Adicionar\n2) Listar\n3) Sair")
    opcao = input("Escolha: ")

    if opcao == "1":
        tarefa = input("Digite a tarefa: ")
        tarefas.append(tarefa)
        print("Tarefa adicionada")
    elif opcao == "2":
        for i, t in enumerate(tarefas, start=1):
            print(f"{i}. {t}")
    elif opcao == "3":
        break
    else:
        print("Opcao invalida")

# DESAFIO
# 1) Salvar tarefas em arquivo.
# 2) Permitir remover tarefa.
