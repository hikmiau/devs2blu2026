namespace DesignPatterns02.FactoryExercicios.Exercicio3;

public class RelatorioEstoque : IRelatorio
{
    public void GerarRelatorio()
    {
        Console.WriteLine("Gerando relatório de estoque...");
    }
}