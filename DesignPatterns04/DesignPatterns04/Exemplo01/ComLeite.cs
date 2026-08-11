namespace DesignPatterns05;

public class ComLeite : ICafe
{
    private readonly ICafe _cafe;
    
    public ComLeite(ICafe cafe)
    { 
        _cafe = cafe;
    }

    public string getDescricao()
    {
        return _cafe.getDescricao() + " com Leite";
    }
    public double getPreco() => _cafe.getPreco() + 2;
}