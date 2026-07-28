using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO06.Exercicios.Ex05
{
    internal class Notebook : Produto
    {
        public string Processador { get; set; }
        public int QuantidadeRam { get; set; }

        public Notebook(string nome, double preco, string processador, int quantidadeRam)
        {
            Nome = nome;
            Preco = preco;
            Processador = processador;
            QuantidadeRam = quantidadeRam;
        }

        public override void MostrarDados()
        {
            Console.WriteLine("EU SOU UM NOTEBOOK");
        }
    }
}
