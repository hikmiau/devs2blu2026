namespace ExemploClasses;

class Program
{
    /*
     * Caixa Eletronico
     *    -> Depositar e Sacar
     */

    static double saldo = 0;

    public static void Main(string[] args)
    {
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("***** CAIXA ELETRONICO *****");
            Console.WriteLine("Escolha uma acao:\n");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Ver Saldo");
            Console.WriteLine("0. Sair\n");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    FazerDeposito(); break;
                case 2:
                    FazerSaque(); break;
                case 3: 
                    Console.WriteLine("\nSaldo: " + saldo.ToString("N2") + "\n"); break;
                case 0:
                    executando = false;
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opcao invalida.");
                    break;
            }

            static void FazerDeposito()
            {
                Console.WriteLine("Valor para deposito: ");
                double valorDigitado = Convert.ToDouble(Console.ReadLine());
                saldo += valorDigitado;

                Console.WriteLine($"\nDeposito realizado. Saldo atual: R${saldo.ToString("N2")}\n");
            }

            static void FazerSaque()
            {
                Console.WriteLine("Valor para saque: ");
                double valorDigitado = Convert.ToDouble(Console.ReadLine());

                if (valorDigitado > saldo)
                {
                    Console.WriteLine("\nOperacao negada: Saldo Insuficiente.\n");
                }
                else
                {
                    saldo -= valorDigitado;
                    Console.WriteLine($"\nSaque realizado. Saldo atual: R${saldo.ToString("N2")}\n");
                }
            }
        }
    }
}

/*
 ---------------- EXEMPLO DO PROFESSOR ----------------
 
static void Main(string[] args)
{
    while (true)
    {
        double saldo = 0;
        
        Console.WriteLine("( 1 ) Deposito ");
        Console.WriteLine("( 2 ) Saque ");
        Console.WriteLine("( 3 ) Ver Saldo");
        Console.WriteLine("( 0 ) Sair ");
        string opcao = Console.ReadLine();
        if (opcao == "0") break;
        
        switch (opcao)
        {
            case "1":
                saldo = Depositar();
                break;
            case "2": 
                saldo = Sacar(saldo);
                break;
            case "3":
                MostrarSaldo(saldo);
                break;
            default: break;
        }
    }
}

static void MostrarSaldo(double saldo)
{
    Console.WriteLine("Saldo atual: R$" + saldo);
}

static void Depositar(double saldo)
{
    Console.WriteLine("*** DEPOSITO ***\n");
    Console.WriteLine("Quantos reais desejas depositar?");
    double valor = double.Parse(Console.ReadLine());
    if(valor < 0) Console.WriteLine("Valor invalido");
    else
    {
        saldo += valor;
        Console.WriteLine("Saldo realizado com sucesso!");
    }
}

static void Sacar(double saldo)
{
    Console.WriteLine("*** SAQUE ***");
    Console.WriteLine("\nQuantos reais desejas sacar?");
    double valor = double.Parse(Console.ReadLine());
    if(valor > saldo || valor < 0)
        Console.WriteLine("Valor invalido");
    
}
*/