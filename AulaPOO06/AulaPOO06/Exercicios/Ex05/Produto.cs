using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO06.Exercicios.Ex05
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public virtual void MostrarDados()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preco: {Preco}");
        }
    }
}
