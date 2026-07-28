using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO06.Exercicios.Ex05
{
    internal class Celular : Produto
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public Celular(string nome, double preco, string modelo, string marca)
        {
            Nome = nome;
            Preco = preco;
            Modelo = modelo;
            Marca = marca;
        }

        Celular celular1 = new Celular("cPhone", 280, "Sharp 3", "Eple");
        Celular celular2 = new Celular("Starway", 280, "Plus 5", "SungSung");
    }
}
