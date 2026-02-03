using System;

// ======================================================
// PATTERN: Template Method
// ======================================================
// OBJETIVO
// Definir o esqueleto de um algoritmo e deixar passos variaveis.
// ======================================================

abstract class ProcessadorDocumento
{
    // Template method
    public void Processar()
    {
        Abrir();
        Ler();
        Fechar();
    }

    protected abstract void Abrir();
    protected abstract void Ler();
    protected abstract void Fechar();
}

class ProcessadorPdf : ProcessadorDocumento
{
    protected override void Abrir() => Console.WriteLine("Abrindo PDF");
    protected override void Ler() => Console.WriteLine("Lendo PDF");
    protected override void Fechar() => Console.WriteLine("Fechando PDF");
}

class ProcessadorTxt : ProcessadorDocumento
{
    protected override void Abrir() => Console.WriteLine("Abrindo TXT");
    protected override void Ler() => Console.WriteLine("Lendo TXT");
    protected override void Fechar() => Console.WriteLine("Fechando TXT");
}

// ===================
// EXEMPLO
// ===================
ProcessadorDocumento p1 = new ProcessadorPdf();
ProcessadorDocumento p2 = new ProcessadorTxt();

p1.Processar();
p2.Processar();

// DESAFIO
// 1) Adicionar passo opcional "Validar".
// 2) Criar ProcessadorDocx.
