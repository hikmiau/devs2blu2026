namespace DesignPatterns05;

public class CafePreto : ICafe
{
    public string getDescricao()
    {
        return "Café Preto";
    }

    public double getPreco() => 3.5;
}