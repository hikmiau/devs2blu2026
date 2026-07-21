using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO03
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int qtd_estoque;
        public Marca marca;

        public Produto() { }

        public Produto(string nome, double preco, int qtd_estoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd_estoque = qtd_estoque;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Preco: {this.preco}");
            Console.WriteLine($"Quantidade: {this.qtd_estoque}");
        }

        public void ReduzirEstoque(int qtd)
        {
            this.qtd_estoque -= qtd;
            Console.WriteLine("Estoque alterado com sucesso!");
        }

        public void Cadastrar()
        {
            Console.WriteLine("Nome: ");
            this.nome = Console.ReadLine();
            Console.WriteLine("Preco: ");
            this.preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Estoque: ");
            this.qtd_estoque = int.Parse(Console.ReadLine());
        }
    }
}
