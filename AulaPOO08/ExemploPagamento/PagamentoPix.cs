namespace ExemploPagamento;

public class PagamentoPix : IPagamento
{
    public void Processar(double valor)
    {
        Console.WriteLine("[PIX] GERANDO QR CODE");
        Console.WriteLine("████████████████████████");
        Console.WriteLine("█ ▄▄▄▄▄ █ ▄ ▀█▀▄ ▄▀▄ ▄█");
        Console.WriteLine("█ █   █ █▄█ ▀█ ▀█▀█ ▀▄█");
        Console.WriteLine("█ █ █ █ █   ▀ █▀█▀  ▀▄█");
        Console.WriteLine("█ █▄▄▄█ █▀█▀ ▀▄█  █▀  █");
        Console.WriteLine("█       █▀▄▄▀█▀  ▄ ▀▀▀▀█");
        Console.WriteLine("█ ▄▄▄▄▄ █▀▄▀ ▀█▀█ ▀ ▀▀ █");
        Console.WriteLine("█       █ ▀▀▄█▀  ▀█▄█▀▀█");
        Console.WriteLine("████████████████████████");
        
        Console.WriteLine("Pagamento APROVADO!");
    }
}