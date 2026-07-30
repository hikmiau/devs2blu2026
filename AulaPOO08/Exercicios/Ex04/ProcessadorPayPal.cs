namespace Exercicios;

public class ProcessadorPayPal : IProcessadorPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Processando pagamento no PayPal: R${valor}");
    }

    public void CancelarPagamento()
    {
        Console.WriteLine("Pagamento no PayPal cancelado.");
    }
}
