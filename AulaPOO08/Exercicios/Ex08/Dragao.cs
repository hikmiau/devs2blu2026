namespace Exercicios;

public class Dragao : IAtaque, IVoar
{
    public void Atacar()
    {
        Console.WriteLine("O dragao atacou com fogo.");
    }

    public void Voar()
    {
        Console.WriteLine("O dragao esta voando.");
    }
}
