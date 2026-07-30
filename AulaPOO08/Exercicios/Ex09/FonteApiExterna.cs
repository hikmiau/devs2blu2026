namespace Exercicios;

public class FonteApiExterna : IFonteRelatorio
{
    public string ObterDados()
    {
        return "Vendas da API externa: pedido 10, pedido 20, pedido 30.";
    }
}
