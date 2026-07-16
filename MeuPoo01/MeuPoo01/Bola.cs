using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPoo01
{
    internal class Bola
    {
        public int Id;
        public string nome;
        public string material;
        public string cor;

        public Bola(int id, string nome, string material)
        {
            this.Id = id;
            this.nome = nome;
            this.material = material;
            this.cor = "vermelho";
        }

        public void MostrarDados()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Material: " + this.material);
            Console.WriteLine("Cor: " + this.cor);
        }
    }
}
