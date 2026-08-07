using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO09
{
    internal class NaveDeCombate : NaveEspacial
    {
        public NaveDeCombate(string nome, int combustivel) : base(nome, combustivel)
        {
            this.Nome = nome;
        }

        public override void Decolar()
        {
            Console.WriteLine($"A Nave {this.Nome} decola agressivamente.");
        }
    }
}
