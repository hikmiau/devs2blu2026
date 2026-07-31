using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo09
{
    internal class NaveDeCarga : NaveEspacial
    {
        public NaveDeCarga(string nome, double combustivel) : base(nome, combustivel)
        {
            this.Nome = nome;
        }

        public override void Decolar()
        {
            Console.WriteLine($"A Nave {this.Nome} decola lentamente.");
        }
    }
}
