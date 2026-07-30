namespace Exercicios;

public class Mago : IAtaque, ICurar
{
    public void Atacar()
    {
        Console.WriteLine("O mago atacou com magia.");
    }

    public void Curar()
    {
        Console.WriteLine("O mago curou um aliado.");
    }
}
