namespace DesignPatterns02.FactoryExercicios.Exercicio3;

public class RelatorioFinanceiro : IRelatorio
{
    public void GerarRelatorio()
    {
        Console.WriteLine("Gerando relatório financeiro...");
    }
}