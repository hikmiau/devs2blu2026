using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO03
{
    internal class Computador
    {
        public string nome;
        public string cpu;
        public string ram;
        public PlacaDeVideo gpu;

        public Computador(string nome, string cpu, string ram, PlacaDeVideo gpu)
        {
            this.nome = nome;
            this.cpu = cpu;
            this.ram = ram;
            this.gpu = gpu;
        }
    }
}
