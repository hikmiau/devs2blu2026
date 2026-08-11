namespace DesignPatterns05;

public class ComCreme : ICafe
{
    private readonly ICafe _cafe;

    public ComCreme(ICafe cafe)
    {
        _cafe = cafe;
    }

    public string getDescricao() => _cafe.getDescricao() + " com Creme";
    
    public double getPreco() => _cafe.getPreco() + 2.5;
}