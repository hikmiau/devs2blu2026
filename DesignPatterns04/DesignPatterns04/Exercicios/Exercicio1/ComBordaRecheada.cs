namespace DesignPatterns05.Exercicios.Exercicio1;

public class ComBordaRecheada : IPizza
{
    private IPizza _pizza;

    public ComBordaRecheada(IPizza pizza)
    {
        _pizza = pizza;
    }

    public string GetDescricao()
    {
        return _pizza.GetDescricao() + " com borda recheada";
    }

    public double GetPreco()
    {
        return _pizza.GetPreco() + 8.0;
    }
}