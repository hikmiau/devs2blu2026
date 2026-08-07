namespace DesignPatterns02.FactoryExercicios.Exercicio1;

public class Boleto : IFormaPagamento
{
    public void Processar(decimal valor)
    {
        Console.WriteLine("Boleto: " + valor);
    }
}