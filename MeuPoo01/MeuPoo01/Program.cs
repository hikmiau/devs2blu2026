<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AulaPOO.Exercicios;
using AulaPOO.Exercicios.ExercicioPedido;

namespace AulaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex01();
            Console.ReadKey();
            // PersonagemJogo pj1 = new PersonagemJogo("Batman", "Rico", 100, 1);
            // PersonagemJogo pj2 = new PersonagemJogo("Pinguim", "Mafioso", 8, 7);
            //
            // pj1.ExibirStatus();
            // Console.WriteLine();
            // pj2.ExibirStatus();
            //
            // Console.WriteLine("-------");
            //
            // pj1.Atacar(pj2);
            //
            // pj2.Atacar(pj1);
            //
            //   Cliente cliente1 = new Cliente(10, "Celia CSharp", "111.111.111-11");
            //   cliente1.Altura = 1.89;
            //   Cliente cliente2 = new Cliente(11, "Paulo Python", "222.222.222-22");
            //
            //   Bola b1 = new Bola(1, "Jabulani", "Borracha");
            //   Bola b2 = new Bola(1, "Trionda", "Couro");
            //   Bola b3 = new Bola(1, "Golf X-4", "Polibucatidieno");
            //
            //   //b1.MostrarDados();
            //   //b2.MostrarDados();
            //   //b3.MostrarDados();
            //
            //   // Abstrair a seguinte entidade:
            //   // Aluno (adicionar o metodo calcular_mostrar media)
            //
            //   Aluno a1 = new Aluno(1, "Joao Java", "11122-33jh");
            //   Console.WriteLine("Digite a primeira nota");
            //   a1.Nota1 = double.Parse(Console.ReadLine());
            //
            //   Console.WriteLine("Digite a segunda nota");
            //   a1.Nota2 = double.Parse(Console.ReadLine());
            //
            //   Console.WriteLine("Digite a terceira nota");
            //   a1.Nota2 = double.Parse(Console.ReadLine());
            //
            //   Console.WriteLine("Digite a quarta nota");
            //   a1.Nota2 = double.Parse(Console.ReadLine());
            //
            //   a1.mostrarMedia();
            //   PetVirtual pet = new PetVirtual;
        }

        public static void ex01()
        {
            Produto1 prod1 = new Produto1(1, "Cachaça", 19.90);
            Produto1 prod2 = new Produto1(2, "Pipoca", 2.90);
            Produto1 prod3 = new Produto1(3, "Coca-cola", 9.90);

            Pedido pedido = new Pedido(1001, "Uncle Bob", "pendente");
            pedido.adicionarItem(prod1);
            pedido.adicionarItem(prod2);
            pedido.adicionarItem(prod3);

            Console.WriteLine(pedido.itens[2].nome);
        }
    }
}
=======
﻿using System;
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
>>>>>>> ce3bbc3903b9bd764a9004d751b7c0f7f6757645
