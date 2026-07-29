namespace ExenploPagamento;

public class PagamentoBoleto : IPagamento
{
    public void Processar(double valor)
    {
        Console.WriteLine("\n[BOLETO] Gerando código de barras");
        Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");
        Console.WriteLine("| ||| || || | | || | || ||| || | || ||| |");
        Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");
        Console.WriteLine($"Boleto gerado no valor de R${valor}");
    }
}