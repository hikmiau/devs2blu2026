namespace Exercicios;

public class ProcessadorCartaoCredito : IProcessadorPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Processando pagamento no cartao de credito: R${valor}");
    }

    public void CancelarPagamento()
    {
        Console.WriteLine("Pagamento no cartao cancelado.");
    }
}
