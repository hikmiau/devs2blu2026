using System.ComponentModel.DataAnnotations;
using DesignPatterns05.exemplo02;

namespace DesignPatterns05;

class Program
{
    static void Main(string[] args)
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
}