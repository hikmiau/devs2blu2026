namespace ExenploPagamento;

public class PagamentoCartao : IPagamento

{
    public void Processar(double valor)
    {
        Console.WriteLine("/n [CARTÃO] Conectando com a operadora....");
        Console.WriteLine($"Transacao  de R${valor} aprovado na maquininha");
    }
}