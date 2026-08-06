namespace DesignPatterns01.Singleton.Exercicios;

public class GerenciadorLicenca
{
    private static GerenciadorLicenca _instance;

    private GerenciadorLicenca()
    {
    }
    public static GerenciadorLicenca ObterInstancia()
    {
        if (_instance == null)
        {
            _instance = new GerenciadorLicenca();
        }
        return _instance;
    }

    public string Chave { get; set; }
    public DateTime DataExpiracao { get; set; }
    public bool StatusLicenca { get; set; }
    
    public void AtivarLicenca(string chave, DateTime validade)
    {
        Chave = chave;
        StatusLicenca = true;
        DataExpiracao = validade;
    }

    public void DesativarLicenca()
    {
        StatusLicenca = false;
    }
    
    public void RenovarLicenca(DateTime novaValidade)
    {
        StatusLicenca = true;
        DataExpiracao = novaValidade;
    }
    
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Chave: {Chave}");
        Console.WriteLine($"Data de expiração: {DataExpiracao}");
        Console.WriteLine($"Status: {StatusLicenca}");
    }

}