using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPoo01
{
    internal class PetVirtual
    {
        public string nome;
        public int fome;
        public int felicidade;

        public PetVirtual()
        {
            this.nome = nome;
            this.fome = fome;
            this.felicidade = felicidade;
        }

        public void status()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Fome: " + this.fome);
            Console.WriteLine("Felicidade: " + this.felicidade);
        }

        public void alimentar()
        {
            this.fome -= 10;
            Console.WriteLine("Voce alimentou o pet.");
            this.status();
        }

        public void brincar()
        {
            this.fome += 10;
            Console.WriteLine("Voce brincou com o pet.");
            this.status();
        }
    }
}
