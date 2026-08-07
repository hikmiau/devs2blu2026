namespace DesignPatterns02.FactoryExercicios.Exercicio1;

public class Pix : IFormaPagamento
{
    public void Processar(decimal valor)
    {
        Console.WriteLine("Pix: " + valor);
    }
}