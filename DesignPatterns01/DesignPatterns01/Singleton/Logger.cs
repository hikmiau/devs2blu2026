namespace DesignPatterns01.Singleton;

public class Logger
{
    private static Logger _instance;
    
    public static Logger ObterInstancia()
    {
        if (_instance == null)
        {
            // Codigo que seleciona o arquivo pra
            // onde vai o logger
            
            _instance = new Logger();
        }
        return _instance;
    }

    public void Registrar()
    {
        
    }
}