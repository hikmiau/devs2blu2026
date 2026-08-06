namespace DesignPatterns01.Singleton;

public class Professor
{
    public string Nome { get; set; }
    public int Id { get; set; }
    private static int ContadorId = 0;

    public Professor(String nome)
    {
        ContadorId++;
        Id = ContadorId;
        Nome = nome;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome} - ID: {Id}");
        Console.WriteLine($"Contador ID: {ContadorId}");
    }
}