namespace Exercicios;

public class Carro : ITransporte
{
    public void IniciarViagem(string destino)
    {
        Console.WriteLine($"O carro saiu para {destino}.");
    }

    public void FinalizarViagem()
    {
        Console.WriteLine("O carro chegou ao destino.");
    }
}
