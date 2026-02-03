# OOP em Python - Guia Detalhado

## O que e uma classe em Python?
Classe e um molde. Objeto e uma instancia.

## Exemplo basico
```python
class Pessoa:
    def __init__(self, nome, idade):
        self.nome = nome
        self.idade = idade

    def apresentar(self):
        print(f"Ola, eu sou {self.nome}")
```

## Encapsulamento
Python usa convencao:
- `_atributo` = protegido
- `__atributo` = privado (name mangling)

## Heranca
```python
class Animal:
    def falar(self):
        pass

class Cachorro(Animal):
    def falar(self):
        print("au")
```

## Exercicios
1. Criar classe ContaBancaria.
2. Criar classe Produto com estoque.
3. Criar heranca simples.
