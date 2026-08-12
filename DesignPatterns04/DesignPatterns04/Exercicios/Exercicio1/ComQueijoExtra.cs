namespace DesignPatterns05.Exercicios.Exercicio1;

public class ComQueijoExtra : IPizza
{
    private IPizza _pizza;

    public ComQueijoExtra(IPizza pizza)
    {
        _pizza = pizza;
    }

    public string GetDescricao()
    {
        return _pizza.GetDescricao() + " com queijo extra";
    }

    public double GetPreco()
    {
        return _pizza.GetPreco() + 5.0;
    }
}