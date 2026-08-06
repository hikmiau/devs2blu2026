namespace DesignPatterns01.Singleton.Exercicios;

public class GerenciadorDeImpressao
{
    private static GerenciadorDeImpressao _instance;
    
    public static GerenciadorDeImpressao ObterInstancia()
    {
        if (_instance == null)
        {
            _instance = new GerenciadorDeImpressao();
        }
        return _instance;
    }
    private GerenciadorDeImpressao()
    { 
        _filaDeImpressao = new List<string>();
    }
    
    private List<string> _filaDeImpressao = new List<string>();

    
    public void AdicionarDocumento(string nomeDoArquivo)
    {
        _filaDeImpressao.Add(nomeDoArquivo);
        Console.WriteLine($"Documento '{nomeDoArquivo}' adicionado à fila de impressão.");
    }

    public void ImprimirTodos()
    {
        Console.WriteLine(_filaDeImpressao);
        _filaDeImpressao.Clear();
    }
}