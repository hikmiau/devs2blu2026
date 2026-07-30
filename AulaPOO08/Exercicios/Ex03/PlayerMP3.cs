namespace Exercicios;

public class PlayerMP3 : IReprodutorMultimidia
{
    public void Play()
    {
        Console.WriteLine("Tocando musica no MP3.");
    }

    public void Pause()
    {
        Console.WriteLine("MP3 pausado.");
    }

    public void Stop()
    {
        Console.WriteLine("MP3 parado.");
    }

    public void Avancar(int segundos)
    {
        Console.WriteLine($"MP3 avancou {segundos} segundos.");
    }
}
