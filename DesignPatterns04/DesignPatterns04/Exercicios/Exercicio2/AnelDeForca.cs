namespace DesignPatterns05.Exercicios.Exercicio2;

public class AnelDeForca : IAtaque
{
    private IAtaque _ataque;

    public AnelDeForca(IAtaque ataque)
    {
        _ataque = ataque;
    }

    public int CalcularDano()
    {
        return _ataque.CalcularDano() + 5;
    }
}

