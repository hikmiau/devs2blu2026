namespace DesignPatterns01.Singleton;

public class GerenciadorDeConfiguracao
{
    private static readonly GerenciadorDeConfiguracao _instance = new();
    public string Tema { get; set; }
    private GerenciadorDeConfiguracao()
    {
        Tema = "escuro";
    }

    public static GerenciadorDeConfiguracao ObterInstancia()
    {
        return _instance;
    }

    public static GerenciadorDeConfiguracao Instancia() => ObterInstancia();
}