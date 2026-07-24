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
            while (true)
            {
                try
                {
                    Console.WriteLine("Altura: ");
                    double altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Largura: ");
                    double largura = double.Parse(Console.ReadLine());

                    Retangulo rt = new Retangulo(largura, altura);
                    Console.WriteLine("Retangulo criado com sucesso!");
                    Console.WriteLine("Area: " + rt.Area);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Digite um **NUMERO**!");
                }
            }
        }

        private static void Ex03()
        {
            Personagem p1 = new Personagem("POO-MAN", 120);
            while (true)
            {
                Console.WriteLine("\nPontos de vida: " + p1.Vida);
                Console.WriteLine("1) Curar");
                Console.WriteLine("2) Receber Dano");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        Console.WriteLine("Quantos de vida vc quer curar?");
                        int pontosDeVida = int.Parse(Console.ReadLine());
                        p1.Curar(pontosDeVida);
                        break;
                    case "2":
                        Console.WriteLine("Quantos pontos de dano vc quer causar?");
                        int pontosDeDano = int.Parse(Console.ReadLine());
                        p1.ReceberDano(pontosDeDano);
                        break;
                }
            }
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
