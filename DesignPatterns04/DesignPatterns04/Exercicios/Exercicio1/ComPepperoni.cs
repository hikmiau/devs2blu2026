namespace DesignPatterns05.Exercicios.Exercicio1;

public class ComPepperoni : IPizza
{
    private IPizza _pizza;

    public ComPepperoni(IPizza pizza)
    {
        _pizza = pizza;
    }

    public string GetDescricao()
    {
        return _pizza.GetDescricao() + " com pepperoni";
    }

    public double GetPreco()
    {
        return _pizza.GetPreco() + 6.0;
    }
}