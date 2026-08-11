namespace DesignPatterns03;

public class Pizza
{
    public string Massa { get; set; }
    public string Molho { get; set; }
    public string Queijo { get; set; }
    public List<string> Coberturas { get; set; }
    public bool BordaRecheada { get; set; }

    internal Pizza(string massa, string molho, string queijo, List<string> coberturas, bool bordaRecheada)
    {
        Massa = massa;
        Molho = molho;
        Queijo = queijo;
        Coberturas = coberturas;
        BordaRecheada = bordaRecheada;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Massa: {Massa}");
        Console.WriteLine($"Molho: {Molho}");
        Console.WriteLine($"Queijo: {Queijo}");
        Console.WriteLine($"Coberturas: {Coberturas}");
        Console.WriteLine($"Borda Recheada: {BordaRecheada}");
            
    }

}