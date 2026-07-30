namespace Exercicios;

public class PlayerVideo : IReprodutorMultimidia
{
    public void Play()
    {
        Console.WriteLine("Reproduzindo video.");
    }

    public void Pause()
    {
        Console.WriteLine("Video pausado.");
    }

    public void Stop()
    {
        Console.WriteLine("Video parado.");
    }

    public void Avancar(int segundos)
    {
        Console.WriteLine($"Video avancou {segundos} segundos.");
    }
}
