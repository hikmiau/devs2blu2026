namespace Exercicios;

public class Trem : ITransporte
{
    public void IniciarViagem(string destino)
    {
        Console.WriteLine($"O trem seguiu para {destino}.");
    }

    public void FinalizarViagem()
    {
        Console.WriteLine("O trem encerrou a viagem.");
    }
}
