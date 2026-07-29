using System;

namespace AulaPOO06.Exercicios.Ex06
{
    internal class Gato : Animal
    {
        public string CorPelagem { get; set; }

        public Gato(string nome, string especie, string corPelagem)
        {
            Nome = nome;
            Especie = especie;
            CorPelagem = corPelagem;
        }

        public override void FazerSom()
        {
            Console.WriteLine("Miau!");
        }
    }
}