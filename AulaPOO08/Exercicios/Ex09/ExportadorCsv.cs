namespace Exercicios;

public class ExportadorCsv : IExportadorRelatorio
{
    public void Exportar(string dados)
    {
        Console.WriteLine("[CSV] Gerando relatorio.");
        Console.WriteLine(dados);
    }
}
