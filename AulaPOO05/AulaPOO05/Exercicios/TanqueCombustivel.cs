using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO05.Exercicios
{
    internal class TanqueCombustivel
    {
        public double NivelAtual { get; set; }
        public double CapacidadeMaxima { get; set; }

        public TanqueCombustivel(double capacidadeMaxima, double nivelAtual)
        {
            this.CapacidadeMaxima = capacidadeMaxima;
            this.NivelAtual = nivelAtual;
        }

        public void Abastecer(double litros)
        {
            if (litros < 0)
            {
                Console.WriteLine("Não é possível abastecer uma quantidade negativa.");
                return;
            }

            if (this.NivelAtual + litros > this.CapacidadeMaxima)
            {
                this.NivelAtual = this.CapacidadeMaxima;
                Console.WriteLine("O tanque encheu, excesso sera desconsiderado.");
            }
            else
            {
                this.NivelAtual += litros;
            }
        }
    }
}
