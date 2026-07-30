namespace Exercicios;

public abstract class ProdutoBase : IFretavel
{
    public string Nome { get; set; }
    public decimal PrecoBase { get; set; }

    public ProdutoBase(string nome, decimal precoBase)
    {
        Nome = nome;
        PrecoBase = precoBase;
    }

    public abstract decimal CalcularFrete(decimal distanciaKm);
}
