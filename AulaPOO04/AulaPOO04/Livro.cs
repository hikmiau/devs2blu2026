using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO04
{
    internal class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }

        public Livro(string titulo, string genero, string autor)
        {
            this.Id = new Random().Next(0, 1000);
            this.Titulo = titulo;
            this.Genero = genero;
            this.Autor = autor;
        }
    }
}
