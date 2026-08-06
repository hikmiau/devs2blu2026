namespace DesignPatterns01.Singleton;

public class Computador
{
    public string Nome { get; set; }
    public string Usuario { get; set; }
    private readonly GerenciadorLicenca licenca;
    public Computador(string nome, string usuario)
    {
        Nome = nome;
        Usuario = usuario;
        licenca = GerenciadorLicenca.GetInstancia();
    }

    public void ConsultarLicenca()
    {
        Console.WriteLine($"=== {Nome} ===");
        Console.WriteLine($"Usuário: {Usuario}");

        licenca.ExibirInformacoes();

        Console.WriteLine();
    }

    public void VerificarLicenca(GerenciadorLicenca ger)
    {
        if (ReferenceEquals(licenca, ger))
        {
            Console.WriteLine("é a mesma coisa");
        }
    }
}