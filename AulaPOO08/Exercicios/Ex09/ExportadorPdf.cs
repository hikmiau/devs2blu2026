namespace Exercicios;

public class ExportadorPdf : IExportadorRelatorio
{
    public void Exportar(string dados)
    {
        Console.WriteLine("[PDF] Gerando relatorio.");
        Console.WriteLine(dados);
    }
}
