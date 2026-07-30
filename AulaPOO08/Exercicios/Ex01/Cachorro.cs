namespace Exercicios;

public class Cachorro : IAnimal
{
    public void Falar()
    {
        Console.WriteLine("O cachorro faz au au.");
    }

    public void Mover()
    {
        Console.WriteLine("O cachorro corre.");
    }
}
