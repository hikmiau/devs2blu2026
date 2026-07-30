namespace Exercicios;

public class ProdutoEletronico : ProdutoBase
{
    public ProdutoEletronico(string nome, decimal precoBase) : base(nome, precoBase)
    {
    }

    public override decimal CalcularFrete(decimal distanciaKm)
    {
        return 1.00m * distanciaKm;
    }
}
