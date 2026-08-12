namespace DesignPatterns05.Exercicios.Exercicio2;

public class PocaoFuria : IAtaque
{
    private IAtaque _ataque;

    public PocaoFuria(IAtaque ataque)
    {
        _ataque = ataque;  
    }

    public int CalcularDano()
    {
        return (_ataque.CalcularDano() * 2);
    }
}