using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MeuPoo01.Exercicios;

namespace MeuPoo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(10, "Celia CSharp", "111.111.111-11");
            cliente1.Altura = 1.89;
            Cliente cliente2 = new Cliente(11, "Paulo Python", "222.222.222-22");

            Bola b1 = new Bola(1, "Jabulani", "Borracha");
            Bola b2 = new Bola(1, "Trionda", "Couro");
            Bola b3 = new Bola(1, "Golf X-4", "Polibucatidieno");

            //b1.MostrarDados();
            //b2.MostrarDados();
            //b3.MostrarDados();

            // Abstrair a seguinte entidade:
            // Aluno (adicionar o metodo calcular_mostrar media)

            Aluno a1 = new Aluno(1, "Joao Java", "11122-33jh");
            Console.WriteLine("Digite a primeira nota");
            a1.Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            a1.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            a1.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota");
            a1.Nota2 = double.Parse(Console.ReadLine());

            a1.mostrarMedia();
        }
    }
}
