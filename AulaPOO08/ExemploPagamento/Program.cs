namespace ExemploPagamento;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha a forma de pagamento:");
        Console.WriteLine("1 - Cartão");
        Console.WriteLine("2 - Boleto");
        Console.WriteLine("3 - Pix");

        int opcao;
        try
        {
            opcao = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida! Digite um número inteiro.");
            return;
        }

        IPagamento pagamento;

        switch (opcao)
        {
            case 1:
                pagamento = new PagamentoCartao();
                break;
            case 2:
                pagamento = new PagamentoBoleto();
                break;
            case 3:
                pagamento = new PagamentoPix();
                break;
            case 4:
                pagamento = new PagamentoPix();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                return;
        }

        Console.WriteLine("Digite o valor do pagamento:");
        double valor;
        try
        {
            valor = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida! Digite um valor numérico.");
            return;
        }

        pagamento.Processar(valor);
    }
}