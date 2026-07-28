using System;

namespace AulaPOO06.Exercicios.Ex06
{
    internal class Gato : Animal
    {
        public string CorPelagem { get; set; }

        public override void FazerSom()
        {
            Console.WriteLine("Miau!");
        }
    }
}