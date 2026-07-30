namespace Exercicios;

public class Passaro : IAnimal
{
    public void Falar()
    {
        Console.WriteLine("O passaro canta.");
    }

    public void Mover()
    {
        Console.WriteLine("O passaro voa.");
    }
}
