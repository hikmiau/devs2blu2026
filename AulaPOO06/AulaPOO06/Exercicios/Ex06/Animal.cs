using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO06.Exercicios.Ex06
{
    internal abstract class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }

        public virtual void FazerSom()
        {
            Console.WriteLine("Insira som de animal aqui");
        }
    }
}
