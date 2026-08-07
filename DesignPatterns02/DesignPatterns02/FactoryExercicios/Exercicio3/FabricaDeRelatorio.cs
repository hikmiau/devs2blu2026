namespace DesignPatterns02.FactoryExercicios.Exercicio3;

public class FabricaDeRelatorio
{
    public IRelatorio CriarRelatorio(string tipo)
    {
        return tipo switch
        {
            "vendas" => new RelatorioVendas(),
            "estoque" => new RelatorioEstoque(),
            "financeiro" => new RelatorioFinanceiro(),
            _ => throw new ArgumentException("Tipo de relatório não suportado.")
        };
    }
}