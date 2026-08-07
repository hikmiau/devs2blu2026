using System;
using System.Collections.Generic;
using DesignPatterns02.FactoryExercicios.Exercicio1;
using DesignPatterns02.FactoryExercicios.Exercicio2;
using DesignPatterns02.FactoryExercicios.Exercicio3;
using DesignPatterns02.FactoryExercicios.Exercicio4;

namespace DesignPatterns02;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Ex01();
        program.Ex02();
        program.Ex03();
        program.Ex04();
    }

    private void Ex01()
    {
        Console.WriteLine("\n=== Exercicio 1 - Formas de pagamento ===");

        FabricaDePagamento fabrica = new FabricaDePagamento();
        string[] tiposPagamento = ["boleto", "cartao", "pix"];
        decimal valor = 150.75m;

        foreach (string tipo in tiposPagamento)
        {
            IFormaPagamento formaPagamento = fabrica.CriarFormaPagamento(tipo);
            formaPagamento.Processar(valor);
        }
    }

    private void Ex02()
    {
        Console.WriteLine("\n=== Exercicio 2 - Transportadoras ===");

        FabricaDeTransportadora fabrica = new FabricaDeTransportadora();
        string[] tiposTransportadora = ["aereo", "rodoviario", "maritimo"];
        decimal distanciaKm = 2000m;

        Console.WriteLine($"Distancia usada no teste: {distanciaKm} km");
        foreach (string tipo in tiposTransportadora)
        {
            ITransportadora transportadora = fabrica.CriarTransportadora(tipo);
            transportadora.CalcularPrazoEntrega(distanciaKm);
        }

        decimal prazoAereo = distanciaKm / 800m;
        decimal prazoRodoviario = distanciaKm / 500m;
        decimal prazoMaritimo = distanciaKm / 100m;
        Console.WriteLine(
            $"Comparacao (mesma distancia): aereo ({prazoAereo}) < rodoviario ({prazoRodoviario}) < maritimo ({prazoMaritimo}).");
    }

    private void Ex03()
    {
        Console.WriteLine("\n=== Exercicio 3 - Relatorios ===");

        FabricaDeRelatorio fabrica = new FabricaDeRelatorio();
        List<string> tiposRelatorio = ["vendas", "estoque", "financeiro"];

        foreach (string tipo in tiposRelatorio)
        {
            IRelatorio relatorio = fabrica.CriarRelatorio(tipo);
            relatorio.GerarRelatorio();
        }
    }

    private void Ex04()
    {
        Console.WriteLine("\n=== Exercicio 4 - Singleton de temas ===");

        GerenciadorDeTemas gerenciador1 = ObterGerenciadorNaHome();
        GerenciadorDeTemas gerenciador2 = ObterGerenciadorNoPainel();
        GerenciadorDeTemas gerenciador3 = ObterGerenciadorNoPerfil();

        Console.WriteLine($"Home e Painel usam a mesma instancia? {ReferenceEquals(gerenciador1, gerenciador2)}");
        Console.WriteLine($"Painel e Perfil usam a mesma instancia? {ReferenceEquals(gerenciador2, gerenciador3)}");

        gerenciador1.ObterTema("claro");
        gerenciador1.ObterTema("escuro");
        gerenciador1.ObterTema("altocontraste");

        AbrirConfiguracoes();
        RestaurarPadrao();
    }

    private GerenciadorDeTemas ObterGerenciadorNaHome() => GerenciadorDeTemas.Instance;

    private GerenciadorDeTemas ObterGerenciadorNoPainel() => GerenciadorDeTemas.Instance;

    private GerenciadorDeTemas ObterGerenciadorNoPerfil() => GerenciadorDeTemas.Instance;

    private void AbrirConfiguracoes()
    {
        Console.WriteLine("AbrirConfiguracoes() -> trocar para tema escuro");
        GerenciadorDeTemas.Instance.ObterTema("escuro");
    }

    private void RestaurarPadrao()
    {
        Console.WriteLine("RestaurarPadrao() -> voltar para tema claro");
        GerenciadorDeTemas.Instance.ObterTema("claro");
    }
}