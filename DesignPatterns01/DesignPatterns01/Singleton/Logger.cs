namespace DesignPatterns01.Singleton;

public class Logger
{
    private static readonly Logger _instance = new();
    
    public static Logger ObterInstancia()
    {
        return _instance;
    }
    
    public void Registrar()
    {
        
    }

    public void Registar() => Registrar();
}