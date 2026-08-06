namespace DesignPatterns01.Singleton.Exercicios;

public class Computador
{
    public string Nome { get; set; }
    public string Usuario { get; set; }
    private readonly GerenciadorLicenca _licenca;

    public Computador(string nome, string usuario)
    {
        Nome = nome;
        Usuario = usuario;
        _licenca = GerenciadorLicenca.ObterInstancia();
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Computador: {Nome}");
        Console.WriteLine($"Usuário: {Usuario}");
    }

    public void AtivarLicenca(string chave, DateTime validade) => _licenca.AtivarLicenca(chave, validade);

    public void RenovarLicenca(DateTime novaValidade) => _licenca.RenovarLicenca(novaValidade);

    public void DesativarLicenca() => _licenca.DesativarLicenca();

    public void ConsultarLicenca()
    {
        Console.WriteLine($"=== {Nome} ===");
        Console.WriteLine($"Usuário: {Usuario}");

        _licenca.ExibirInformacoes();

        Console.WriteLine();
    }

    public void VerificarLicenca(GerenciadorLicenca ger)
    {
        if(ReferenceEquals(_licenca, ger))
        {
            Console.WriteLine("é a mesma coisa");
        }
    }
    
}
