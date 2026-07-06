using System.Globalization;

namespace ProjetoPrecos;

class Program
{
    static void Main(string[] args)
    {
        List<double> precos = new List<double>();

        List<string> itens = new List<string>()
        {
            "Novo preco",
            "Mostrar precos",
            "Maior preco",
            "Menor preco",
            "Media",
            "Soma"
        };

        while (true)
        {
            for (var i = 0; i < itens.Count; i++)
            {
                Console.WriteLine($"({i + 1}) - {itens[i]}");
            }
        }
    }
    
    static void novoPreco(List<double> precos)
    {
        Console.Write("Novo preco: R$");
        double preco = double.Parse(Console.ReadLine());
        precos.Add(preco);
    }

    static void mostrarPrecos(List<double> precos)
    {
        Console.WriteLine("****** PRECOS ******");
        for (var i = 0; i < precos.Count; i++)
        {
            Console.WriteLine($"{i + 1} - R${precos[i]}");
        }
    }

    static void maiorPreco(List<double> precos)
    {
        Console.WriteLine($"Maior preco: R${precos.Max()}");
    }

    static void menorPreco(List<double> precos)
    {
        Console.WriteLine("Menor preco: R${precos.Min()}");
    }

    static void Media(List<double> precos)
    {
        Console.WriteLine("Media preco: R${precos.Average()}");
    }
}