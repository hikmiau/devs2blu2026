
namespace DesignPatterns01.Singleton;

public class Professor
{
    public string Nome { get; set; }
    public int Id { get; private set; }

    public static int ContadorId;

    public Professor(String nome)
    {
        ContadorId++;
        Id = ContadorId;
        Nome = nome;
    }

    public void MostrarDados()
    {
        Console.WriteLine();
        Console.WriteLine($"Nome do Professor: {Nome} - ID: {Id}" );
        Console.WriteLine($"Contador ID: {ContadorId}");
    }

    public void ObterTema()
    {
        var config03 = GerenciadorDeConfiguracao.ObterInstancia();
        Console.WriteLine(config03.Tema);
    }
    
}