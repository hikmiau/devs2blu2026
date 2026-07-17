using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPoo01.Exercicios
{
    internal class Livro
    {
        public string titulo;
        public string autor;
        public string anoPublicacao;
        public int quantidadeCapitulos;
        public double preco;

        public Livro(
            string titulo,
            string autor,
            string anoPublicacao,
            int quantidadeCapitulos,
            double preco
        )
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
            this.quantidadeCapitulos = quantidadeCapitulos;
            this.preco = preco;
        }

        public void exibirInformacoes()
        {
            Console.WriteLine("*** INFORMACOES ***\n");
            Console.WriteLine($"Titulo: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Ano em que foi publicado: {anoPublicacao}");
            Console.WriteLine($"Quantidade de capitulos: {quantidadeCapitulos}");
            Console.WriteLine($"Preco: R${preco:F2}");
        }
    }
}
