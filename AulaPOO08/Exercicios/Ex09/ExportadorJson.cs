namespace Exercicios;

public class ExportadorJson : IExportadorRelatorio
{
    public void Exportar(string dados)
    {
        Console.WriteLine("[JSON] Gerando relatorio.");
        Console.WriteLine(dados);
    }
}
