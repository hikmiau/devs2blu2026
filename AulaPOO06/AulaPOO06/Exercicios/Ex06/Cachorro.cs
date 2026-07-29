using System;

namespace AulaPOO06.Exercicios.Ex06
{
    internal class Cachorro : Animal
    {
        public string Raca { get; set; }

        public Cachorro(string nome, string especie, string raca)
        {
            Especie = especie;
            Nome = nome;
            Raca = raca;
        }

        public override void FazerSom()
        {
            Console.WriteLine("Au! Au!");
        }
    }
}