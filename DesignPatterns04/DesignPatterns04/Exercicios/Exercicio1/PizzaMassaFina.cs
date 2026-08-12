namespace DesignPatterns05.Exercicios.Exercicio1;

public class PizzaMassaFina : IPizza
{
    public string GetDescricao()
    {
        return "Pizza de massa fina";
    }

    public double GetPreco()
    {
        return 30.0;
    }
}