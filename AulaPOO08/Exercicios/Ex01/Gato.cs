namespace Exercicios;

public class Gato : IAnimal
{
    public void Falar()
    {
        Console.WriteLine("O gato faz miau.");
    }

    public void Mover()
    {
        Console.WriteLine("O gato anda.");
    }
}
