namespace Exercicios;

public class PlayerStreaming : IReprodutorMultimidia
{
    public void Play()
    {
        Console.WriteLine("Iniciando streaming.");
    }

    public void Pause()
    {
        Console.WriteLine("Streaming pausado.");
    }

    public void Stop()
    {
        Console.WriteLine("Streaming encerrado.");
    }

    public void Avancar(int segundos)
    {
        Console.WriteLine($"Streaming avancou {segundos} segundos.");
    }
}
