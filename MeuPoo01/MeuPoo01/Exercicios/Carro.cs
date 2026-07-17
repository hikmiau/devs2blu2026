using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPoo01
{
    internal class Carro
    {
        public string marca;
        public string modelo;
        public string ano;
        public string cor;
        public double velocidade;

        public Carro(string marca, string modelo, string ano, string cor, double velocidade)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.cor = cor;
            this.velocidade = velocidade;
        }

        public void acelerar()
        {
            this.velocidade++;
        }
    }
}
