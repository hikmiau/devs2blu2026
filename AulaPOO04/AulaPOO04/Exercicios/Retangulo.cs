using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO04.Exercicios
{
    internal class Retangulo
    {
        public double Largura { get; private set; }

        public double Altura { get; private set; }

        public Retangulo(double largura, double altura)
        {
            if (largura <= 0 || altura <= 0)
            {
                throw new ArgumentException("Os valores das medidas nao podem ser negativos ou 0");
            }
            this.Largura = largura;
            this.Altura = altura;
        }

        public double Area()
        {
            return Altura * Largura;
        }
    }
}
