using System;

namespace AulaPOO07
{
    internal class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return (Math.Pow(Raio, 2) * Math.PI);
        }
    }
}