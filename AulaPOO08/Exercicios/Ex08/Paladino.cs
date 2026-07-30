namespace Exercicios;

public class Paladino : IAtaque, ICurar, IVoar
{
    public void Atacar()
    {
        Console.WriteLine("O paladino atacou com sua espada.");
    }

    public void Curar()
    {
        Console.WriteLine("O paladino curou o grupo.");
    }

    public void Voar()
    {
        Console.WriteLine("O paladino voou com sua montaria alada.");
    }
}
