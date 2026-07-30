namespace Exercicios;

public class ProdutoLivro : ProdutoBase
{
    public ProdutoLivro(string nome, decimal precoBase) : base(nome, precoBase)
    {
    }

    public override decimal CalcularFrete(decimal distanciaKm)
    {
        return 5.00m;
    }
}
