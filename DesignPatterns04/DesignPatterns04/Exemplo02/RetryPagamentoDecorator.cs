namespace DesignPatterns05.exemplo02;

public class RetryPagamentoDecorator : IPagamentoService
{
    private IPagamentoService _pagamentoService;
    private readonly int _maxTentativas;
    
    public RetryPagamentoDecorator(IPagamentoService pagamentoService, int maxTentativas)
    {
        _pagamentoService = pagamentoService;
        _maxTentativas = maxTentativas;
    }

    public bool ProcessarPagamento(decimal preco)
    {
        for (int tentativa = 1; tentativa <= _maxTentativas; tentativa++)
        {
            try
            {
                return _pagamentoService.ProcessarPagamento(preco);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                if (tentativa == _maxTentativas)
                {
                    Console.WriteLine("[RETRY] Falha ao processar pagamento após " + _maxTentativas + " tentativas.");
                }
                Thread.Sleep(1000*tentativa);
            }
        }
        return true;
    }
}