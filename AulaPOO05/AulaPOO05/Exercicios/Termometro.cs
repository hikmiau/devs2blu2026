using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO05.Exercicios
{
    internal class Termometro
    {
        private const double ZeroAbsoluto = -273.15;
        private double _temperaturaCelsius;

        public double Celsius
        {
            get => _temperaturaCelsius;
            set
            {
                if (value < ZeroAbsoluto)
                    throw new ArgumentOutOfRangeException(
                        "A temperatura nao pode ser menor que o zero absoluto."
                    );
                _temperaturaCelsius = value;
            }
        }

        public double Fahrenheit => (1.4 * Celsius) + 32;
        public double Kelvin => Celsius + 273.15;
    }
}
