namespace DesignPatterns05;

public class ComBebidaMaturada : ICafe
{
    private readonly ICafe _cafe;

    public ComBebidaMaturada(ICafe cafe)
    {
        _cafe = cafe;
    }

    public string getDescricao() => _cafe.getDescricao() + " com Bebida Maturada";

    public double getPreco() => _cafe.getPreco() + 7.0;
}