namespace DesignPatterns05.Exercicios.Exercicio2;

public class EspadaDeFogo : IAtaque
{
    private IAtaque _ataque;

    public EspadaDeFogo(IAtaque ataque)
    {
        _ataque = ataque;
    }

    public int CalcularDano()
    {
        return _ataque.CalcularDano() + 15;
    }
}