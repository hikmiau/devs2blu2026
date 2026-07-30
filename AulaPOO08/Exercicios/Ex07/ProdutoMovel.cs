namespace Exercicios;

public class ProdutoMovel : ProdutoBase
{
    public ProdutoMovel(string nome, decimal precoBase) : base(nome, precoBase)
    {
    }

    public override decimal CalcularFrete(decimal distanciaKm)
    {
        return (2.50m * distanciaKm) + 20.00m;
    }
}
