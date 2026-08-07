namespace DesignPatterns02.FactoryExercicios.Exercicio4;

public class GerenciadorDeTemas
{
    private static GerenciadorDeTemas? _instance;
    private GerenciadorDeTemas()
    {
    }

    public static GerenciadorDeTemas Instance
    {
        get { return _instance ??= new GerenciadorDeTemas(); }
    }

    public void ObterTema(string nome)
    {
        switch (nome)
        {
            case "claro":
                TemaClaro temaClaro = new TemaClaro();
                temaClaro.AplicarTema();
                break;
            case "escuro":
                TemaEscuro temaEscuro = new TemaEscuro();
                temaEscuro.AplicarTema();
                break;
            case "alto_contraste":
            case "altocontraste":
                TemaAltoContraste temaAltoContraste = new TemaAltoContraste();
                temaAltoContraste.AplicarTema();
                break;
            default:
                Console.WriteLine("Tema não encontrado.");
                break;
        }
    }
}