namespace DesignPatterns01.Singleton;

public class GerenciadorDeConfiguracao
{
    private static GerenciadorDeConfiguracao _instance;

    public string Tema { get; set; }
    private GerenciadorDeConfiguracao()
    {
        Tema = "escuro";
    }

    public static GerenciadorDeConfiguracao ObterInstancia()
    {
        if (_instance == null)
        {
            _instance = new GerenciadorDeConfiguracao();
        }
        return _instance;
    }
}