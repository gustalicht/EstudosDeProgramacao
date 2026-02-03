using System;

// ======================================================
// OBJETIVO
// Simular um semaforo baseado na cor informada.
// ======================================================

static string MensagemSemaforo(string? cor)
{
    if (string.IsNullOrWhiteSpace(cor))
        return "cor invalida";

    // usamos ToLower para evitar erro com maiusculas
    return cor.Trim().ToLowerInvariant() switch
    {
        "verde" => "pode passar",
        "amarelo" => "atencao",
        "vermelho" => "pare",
        _ => "cor invalida"
    };
}

static void RodarTestes()
{
    Console.WriteLine("== Testes Semaforo ==");
    Console.WriteLine(MensagemSemaforo("verde"));
    Console.WriteLine(MensagemSemaforo("Amarelo"));
    Console.WriteLine(MensagemSemaforo("azul"));
}

bool executarTestes = true;
if (executarTestes) RodarTestes();

// DESAFIO
// 1) aceitar abreviacoes: v/a/r
// 2) contar quantas vezes cada cor apareceu
