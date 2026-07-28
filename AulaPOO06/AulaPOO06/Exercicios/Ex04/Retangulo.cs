using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO06.Exercicios.Ex04
{
    internal class Retangulo : Figura
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }

        public override double CalcularArea(double area)
        {
            area = Altura * Largura;
            return area;
        }
    }
}
