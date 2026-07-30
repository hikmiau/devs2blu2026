namespace Exercicios;

public class Aviao : ITransporte
{
    public void IniciarViagem(string destino)
    {
        Console.WriteLine($"O aviao decolou para {destino}.");
    }

    public void FinalizarViagem()
    {
        Console.WriteLine("O aviao pousou.");
    }
}
