namespace Exercicios;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Exercicio 1 ===");
        Exercicio1();

        Console.WriteLine("\n=== Exercicio 2 ===");
        Exercicio2();

        Console.WriteLine("\n=== Exercicio 3 ===");
        Exercicio3();

        Console.WriteLine("\n=== Exercicio 4 ===");
        Exercicio4();

        Console.WriteLine("\n=== Exercicio 5 ===");
        Exercicio5();

        Console.WriteLine("\n=== Exercicio 6 ===");
        Exercicio6();

        Console.WriteLine("\n=== Exercicio 7 ===");
        Exercicio7();

        Console.WriteLine("\n=== Exercicio 8 ===");
        Exercicio8();

        Console.WriteLine("\n=== Exercicio 9 ===");
        Exercicio9();
    }

    static void Exercicio1()
    {
        List<IAnimal> animais = new List<IAnimal>();
        animais.Add(new Cachorro());
        animais.Add(new Gato());
        animais.Add(new Passaro());

        foreach (IAnimal animal in animais)
        {
            animal.Falar();
            animal.Mover();
        }
    }

    static void Exercicio2()
    {
        IFormaGeometrica retangulo = new Retangulo(10, 5);
        IFormaGeometrica circulo = new Circulo(4);
        IFormaGeometrica triangulo = new Triangulo(6, 4, 3, 4, 5);

        Console.WriteLine($"Retangulo - Area: {retangulo.CalcularArea()}");
        Console.WriteLine($"Retangulo - Perimetro: {retangulo.CalcularPerimetro()}");
        Console.WriteLine($"Circulo - Area: {circulo.CalcularArea()}");
        Console.WriteLine($"Circulo - Perimetro: {circulo.CalcularPerimetro()}");
        Console.WriteLine($"Triangulo - Area: {triangulo.CalcularArea()}");
        Console.WriteLine($"Triangulo - Perimetro: {triangulo.CalcularPerimetro()}");
    }

    static void Exercicio3()
    {
        List<IReprodutorMultimidia> players = new List<IReprodutorMultimidia>();
        players.Add(new PlayerMP3());
        players.Add(new PlayerVideo());
        players.Add(new PlayerStreaming());

        foreach (IReprodutorMultimidia player in players)
        {
            player.Play();
            player.Avancar(15);
            player.Pause();
            player.Stop();
        }
    }

    static void Exercicio4()
    {
        List<IProcessadorPagamento> pagamentos = new List<IProcessadorPagamento>();
        pagamentos.Add(new ProcessadorCartaoCredito());
        pagamentos.Add(new ProcessadorPayPal());
        pagamentos.Add(new ProcessadorBoleto());

        foreach (IProcessadorPagamento pagamento in pagamentos)
        {
            pagamento.ProcessarPagamento(150.00m);
            pagamento.CancelarPagamento();
        }
    }

    static void Exercicio5()
    {
        List<ITransporte> transportes = new List<ITransporte>();
        transportes.Add(new Carro());
        transportes.Add(new Aviao());
        transportes.Add(new Trem());

        foreach (ITransporte transporte in transportes)
        {
            transporte.IniciarViagem("Centro da cidade");
            transporte.FinalizarViagem();
        }
    }

    static void Exercicio6()
    {
        List<INotificador> notificadores = new List<INotificador>();
        notificadores.Add(new NotificadorEmail());
        notificadores.Add(new NotificadorSMS());
        notificadores.Add(new NotificadorWhatsApp());

        foreach (INotificador notificador in notificadores)
        {
            notificador.EnviarMensagem("cliente@exemplo.com", "Sua presenca foi confirmada.");
        }
    }

    static void Exercicio7()
    {
        CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
        carrinho.AdicionarItem(new ProdutoEletronico("Notebook", 3500.00m));
        carrinho.AdicionarItem(new ProdutoLivro("Livro de C#", 80.00m));
        carrinho.AdicionarItem(new ProdutoMovel("Sofa", 2200.00m));

        decimal freteTotal = carrinho.CalcularFreteTotal(50);
        Console.WriteLine($"Frete total para 50 Km: R${freteTotal}");
    }

    static void Exercicio8()
    {
        List<IAtaque> atacantes = new List<IAtaque>();
        atacantes.Add(new Dragao());
        atacantes.Add(new Mago());
        atacantes.Add(new Paladino());

        foreach (IAtaque atacante in atacantes)
        {
            atacante.Atacar();
        }
    }

    static void Exercicio9()
    {
        RelatorioDeVendas relatorio1 = new RelatorioDeVendas(new FonteBancoDeDados(), new ExportadorPdf());
        RelatorioDeVendas relatorio2 = new RelatorioDeVendas(new FonteArquivoTexto(), new ExportadorCsv());
        RelatorioDeVendas relatorio3 = new RelatorioDeVendas(new FonteApiExterna(), new ExportadorJson());

        relatorio1.Gerar();
        relatorio2.Gerar();
        relatorio3.Gerar();
    }
}
