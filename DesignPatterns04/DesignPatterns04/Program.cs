using System.ComponentModel.DataAnnotations;
using DesignPatterns05.exemplo02;
using DesignPatterns05.Exercicios;
using DesignPatterns05.Exercicios.Exercicio1;
using DesignPatterns05.Exercicios.Exercicio2;
using DesignPatterns05.Exercicios.Exercicio3;

namespace DesignPatterns05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** EXERCICIO 1 ***\n");
        new Program().Ex01();
        Console.WriteLine("\n*** EXERCICIO 2 ***\n");
        new Program().Ex02();
        Console.WriteLine("\n*** EXERCICIO 3 ***\n");
        new Program().Ex03();
    }

    void Exemplos()
    {
        IPagamentoService pagamentoService = new GatewayPagamentoService();

           Console.WriteLine("Processando checkout do café ☕️");
           try
           { 
               pagamentoService.ProcessarPagamento(10.00m);
           }
           catch (Exception e)
           {
               pagamentoService = new RetryPagamentoDecorator(pagamentoService, 3);
               pagamentoService.ProcessarPagamento(10.00m);
           }
    }

    void Ex01()
    {
        IPizza pizza = new PizzaMassaFina();
        pizza = new ComPepperoni(pizza);
        pizza = new ComBordaRecheada(pizza);

        Console.WriteLine($"Descrição: {pizza.GetDescricao()}");
        Console.WriteLine($"Preço: {pizza.GetPreco()}");
    }

    void Ex02()
    {
        IAtaque ataqueBase = new AtaqueBasico();
        Console.WriteLine($"Dano (apenas ataque básico): {ataqueBase.CalcularDano()}");

        IAtaque ataqueComEquipamentos = ataqueBase;
        ataqueComEquipamentos = new EspadaDeFogo(ataqueComEquipamentos);
        ataqueComEquipamentos = new AnelDeForca(ataqueComEquipamentos);
        Console.WriteLine($"Dano (com Espada e Anel equipados): {ataqueComEquipamentos.CalcularDano()}");

        IAtaque ataqueComTudo = new PocaoFuria(ataqueComEquipamentos);
        Console.WriteLine($"Dano (com Espada, Anel e Poção de Fúria): {ataqueComTudo.CalcularDano()}");
    }

    void Ex03()
    {
        IFormatadorTexto formatador = new TextoPuro();
        formatador = new RemoverEspacosDecorator(formatador);
        formatador = new CaixaAltaDecorator(formatador);
        formatador = new CensurarPalavrasDecorator(formatador, new string[] { "ruim", "RUIM", "mau" });

        Console.WriteLine($"Texto formatado: {formatador.Formatar("Esse curso e muito ruim.")}");
    }
}