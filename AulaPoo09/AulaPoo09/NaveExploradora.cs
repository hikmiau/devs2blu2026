using System;

namespace AulaPOO0a
{
    internal class NaveExploradora : NaveEspacial, ITeletransportavel
    {
        public NaveExploradora(string nome, int combustivel) : base(nome, combustivel)
        {
            this.Nome = nome;
        }

        public override void Decolar()
        {
            Console.WriteLine($"A Nave {this.Nome} decola em modo exploratório.");
        }

        public void Teletransportar(string destino)
        {
            Console.WriteLine($"A Nave {this.Nome} explorou o destino {destino}.");
        }
    }
}
