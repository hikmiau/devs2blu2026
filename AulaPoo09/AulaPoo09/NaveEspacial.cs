using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO0a
{
    internal abstract class NaveEspacial
    {
        public string Nome { get; set; }
        private double Combustivel { get; set; }
        public NaveEspacial(string nome, double combustivel)
        {
            this.Nome = nome;
            this.Combustivel = combustivel;
        }
        public void NomeVazio()
        {
            if(this.Nome == null)
            {
                throw new ArgumentException("O nome esta vazio!");
            }
        }
        public void Abastecer(double litros)
        {
            Console.WriteLine("Quantos litros você quer abastecer?");
            litros += double.Parse(Console.ReadLine());

            if (litros < 0)
            {
                litros = 0;
            } 
            if (litros > 100)
            {
                litros = 100;
            }
        }

        public void NivelCombustivel()
        {
            Console.WriteLine($"O Combustivel atual é {this.Combustivel} litros." );
        }

        public abstract void Decolar();

    }
}
