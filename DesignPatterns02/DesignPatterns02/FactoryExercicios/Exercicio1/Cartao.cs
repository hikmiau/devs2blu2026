namespace DesignPatterns02.FactoryExercicios.Exercicio1;

public class Cartao : IFormaPagamento
{
    public void Processar(decimal valor)
    {
        Console.WriteLine("Cartão: " + valor);
    }
}