namespace Exercicios;

public class RelatorioDeVendas
{
    private IFonteRelatorio fonte;
    private IExportadorRelatorio exportador;

    public RelatorioDeVendas(IFonteRelatorio fonte, IExportadorRelatorio exportador)
    {
        this.fonte = fonte;
        this.exportador = exportador;
    }

    public void Gerar()
    {
        string dados = fonte.ObterDados();
        exportador.Exportar(dados);
    }
}
