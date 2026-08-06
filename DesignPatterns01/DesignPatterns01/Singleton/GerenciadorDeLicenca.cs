namespace DesignPatterns01.Singleton;

public class GerenciadorLicenca
{
    private static readonly GerenciadorLicenca instancia = new();

    public string? Chave { get; private set; }
    public DateTime Validade { get; private set; }
    public bool Ativa { get; private set; }

    private GerenciadorLicenca()
    {
        Ativa = false;
    }

    public static GerenciadorLicenca GetInstancia()
    {

        return instancia;
    }

    public void AtivarLicenca(string chave, DateTime validade)
    {
        Chave = chave;
        Validade = validade;
        Ativa = true;

        Console.WriteLine("Licença ativada com sucesso!");
    }

    public void DesativarLicenca()
    {
        Ativa = false;

        Console.WriteLine("Licença desativada.");
    }

    public void RenovarLicenca(DateTime novaValidade)
    {
        Validade = novaValidade;

        Console.WriteLine("Licença renovada.");
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Chave: {Chave}");
        Console.WriteLine($"Validade: {Validade.ToShortDateString()}");
        Console.WriteLine($"Status: {(Ativa ? "Ativa" : "Inativa")}");
    }
}