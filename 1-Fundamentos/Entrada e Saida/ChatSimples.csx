using System;

// ======================================================
// OBJETIVO
// Simular um chat simples baseado em palavras-chave.
// ======================================================

static string Responder(string? entrada)
{
    if (string.IsNullOrWhiteSpace(entrada))
        return "fala alguma coisa...";

    var msg = entrada.Trim().ToLowerInvariant();

    if (msg == "oi" || msg == "ola")
        return "ola! tudo bem?";

    if (msg.Contains("tchau"))
        return "ate mais!";

    if (msg.Contains("tempo"))
        return "nao tenho tempo real, mas o clima sempre muda.";

    return "nao entendi, tenta de novo.";
}

static void RodarInterativo()
{
    Console.WriteLine("Chat simples (digite 'sair' para encerrar)");
    while (true)
    {
        Console.Write("> ");
        var entrada = Console.ReadLine();
        if (string.Equals(entrada, "sair", StringComparison.OrdinalIgnoreCase))
            break;
        Console.WriteLine(Responder(entrada));
    }
}

RodarInterativo();

// DESAFIO
// 1) Guardar historico das mensagens.
// 2) Criar comandos: /ajuda, /limpar.
