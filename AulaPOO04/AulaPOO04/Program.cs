using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaPOO04.Exercicios;

namespace AulaPOO04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex02();

            // Console.WriteLine("oi");
            // throw new ArgumentException("TEM UM ERRO AI");
            // Livro l01 = new Livro("Percy Jackson", "Fantasia", "Rick");
            // l01.Autor = "Twste";
            //
            // Carro c01 = new Carro("Fusca", "Volkswagen", "Preto");
            // Console.WriteLine(c01.getCor());
            // c01.setCor("Branco");
        }

        public static void Ex01()
        {
            Console.WriteLine("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            ContaBancaria cb = new ContaBancaria(numero);

            Console.WriteLine("\n*Conta criada com sucesso!*\n");

            while (true)
            {
                Console.WriteLine("1) Depositar");
                Console.WriteLine("2) Sacar");
                Console.WriteLine("Saldo: " + cb.Saldo);
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Quanto queres depositar?");
                        decimal valor = decimal.Parse(Console.ReadLine());
                        if (cb.Depositar(valor))
                        {
                            Console.WriteLine("Deposito realizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao depositar");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Quanto queres sacar?");
                        decimal valor2 = decimal.Parse(Console.ReadLine());
                        if (cb.Depositar(valor2)) { }
                }
            }
        }

        private static void Ex02()
        {
            try
            {
                double l = double.Parse(Console.ReadLine());
                double a = double.Parse(Console.ReadLine());
                Retangulo rt = new Retangulo(a, l);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
        }
    }
}
