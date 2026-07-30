namespace Exercicios;

public class CarrinhoDeCompras
{
    private List<IFretavel> itens = new List<IFretavel>();

    public void AdicionarItem(IFretavel item)
    {
        itens.Add(item);
    }

    public decimal CalcularFreteTotal(decimal distanciaKm)
    {
        decimal total = 0;

        foreach (IFretavel item in itens)
        {
            total += item.CalcularFrete(distanciaKm);
        }

        return total;
    }
}
