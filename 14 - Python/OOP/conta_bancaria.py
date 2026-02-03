# ======================================================
# OOP - Exemplo ContaBancaria
# ======================================================

class ContaBancaria:
    def __init__(self, titular, saldo=0):
        self.titular = titular
        self.saldo = saldo

    def depositar(self, valor):
        if valor <= 0:
            print("Valor invalido")
            return
        self.saldo += valor

    def sacar(self, valor):
        if valor <= 0:
            print("Valor invalido")
            return
        if valor > self.saldo:
            print("Saldo insuficiente")
            return
        self.saldo -= valor

    def mostrar(self):
        print(self.titular, self.saldo)


conta = ContaBancaria("Gustavo", 100)
conta.depositar(50)
conta.sacar(30)
conta.mostrar()

# DESAFIO
# 1) Criar heranca ContaPoupanca.
# 2) Adicionar taxa de saque.
