using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO06.Exercicios.Ex02
{
    internal class Livro : Produto
    {
        public string Autor { get; set; }

        public Livro(string nome, double preco, string autor)
        {
            Preco = preco;
            Nome = nome;
            Autor = autor;
        }

        public static void Livros()
        {
            Livro livro1 = new Livro("A Sombra do Vento Digital", 45.90, "Lucas Mendes");
            Livro livro2 = new Livro("O Último Algoritmo", 38.50, "Beatriz Santos");
            Livro livro3 = new Livro("Horizontes Perdidos", 52.00, "Camila Oliveira");
            Livro livro4 = new Livro("Crônicas do Tempo", 29.90, "Gabriel Costa");
        }
    }
}
