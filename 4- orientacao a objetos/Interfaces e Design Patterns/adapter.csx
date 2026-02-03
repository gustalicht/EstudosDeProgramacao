using System;

// ======================================================
// PATTERN: Adapter
// ======================================================
// OBJETIVO
// Fazer duas interfaces incompatíveis trabalharem juntas.
// ======================================================

// Interface esperada pelo sistema novo
interface IPagamento
{
    void Pagar(decimal valor);
}

// Classe antiga (legado)
class PagamentoLegado
{
    public void EfetuarPagamento(double valor)
    {
        Console.WriteLine($"Pagamento legado: {valor}");
    }
}

// Adapter
class PagamentoAdapter : IPagamento
{
    private readonly PagamentoLegado _legado;

    public PagamentoAdapter(PagamentoLegado legado)
    {
        _legado = legado;
    }

    public void Pagar(decimal valor)
    {
        _legado.EfetuarPagamento((double)valor);
    }
}

// ===================
// EXEMPLO
// ===================
IPagamento pagamento = new PagamentoAdapter(new PagamentoLegado());
pagamento.Pagar(100);

// DESAFIO
// 1) Criar outro adaptador para outra API.
// 2) Medir impacto de conversao de tipos.
