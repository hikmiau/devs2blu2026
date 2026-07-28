using System;

namespace AulaPOO06.Exercicios.Ex06
{
    internal class Cachorro : Animal
    {
        public string Raca { get; set; }

        public override void FazerSom()
        {
            Console.WriteLine("Au! Au!");
        }
    }
}