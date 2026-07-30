namespace Exercicios;

public class ProcessadorBoleto : IProcessadorPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Gerando boleto no valor de R${valor}");
    }

    public void CancelarPagamento()
    {
        Console.WriteLine("Boleto cancelado antes do pagamento.");
    }
}
