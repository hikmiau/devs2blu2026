namespace DesignPatterns05.exemplo02;

public class GatewayPagamentoService : IPagamentoService
{
    private int _tentativas = 0;
    
    public bool ProcessarPagamento(decimal preco)
    {
        _tentativas++;
        Console.WriteLine($"[API GATEWAY] Enviando cobranca de  {preco:C}");
        if (_tentativas < 3)
        {
            throw new Exception("[API GATEWAY] Falha ao processar pagamento. Tentando novamente...");
        }

        Console.WriteLine("[API GATEWAY] Pagamento aprovado com sucesso!");
        
        return true;
    }
}