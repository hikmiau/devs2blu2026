namespace Exercicios;

public class FonteBancoDeDados : IFonteRelatorio
{
    public string ObterDados()
    {
        return "Vendas do banco de dados: produto A, produto B, produto C.";
    }
}
