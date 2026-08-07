namespace DesignPatterns02.FactoryExercicios.Exercicio3;

public class RelatorioVendas : IRelatorio
{
    public void GerarRelatorio()
    {
        Console.WriteLine("Gerando relatório de vendas...");
    }
}