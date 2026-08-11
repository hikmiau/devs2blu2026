namespace DesignPatterns05;

public class ComGelo : ICafe
{
    private readonly ICafe _cafe;

    public ComGelo(ICafe cafe)
    {
        _cafe = cafe;
    }

    public string getDescricao() => _cafe.getDescricao() + " com Gelo";
    
    public double getPreco() => _cafe.getPreco() + 1;
}