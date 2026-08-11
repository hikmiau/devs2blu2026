namespace DesignPatterns03;

class Program
{
    static void Main(string[] args)
    {
        Pizza pizza = new PizzaBuilder()
            .ComMassa("Massa fina")
            .ComMolho("Molho de tomate")
            .ComQueijo("Queijo mussarela")
            .AdicionarCobertura("Pepperoni")
            .AdicionarCobertura("Azeitonas")
            .ComBordaRecheada(true)
            .Build();

        pizza.ExibirDados();
    }
}