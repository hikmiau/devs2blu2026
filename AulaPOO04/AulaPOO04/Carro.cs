using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO04
{
    internal class Carro
    {
        private int id;
        private string modelo;
        private string marca;
        private string cor;

        public Carro(string modelo, string marca, string cor)
        {
            this.id = new Random().Next(0, 1000);
            this.modelo = modelo;
            this.marca = marca;
            this.cor = cor;
        }

        public int getId()
        {
            return this.id;
        }

        public string getModelo()
        {
            return this.modelo;
        }

        public string getMarca()
        {
            return this.marca;
        }

        public string getCor()
        {
            return this.cor;
        }

        public void setModelo(string novoModelo)
        {
            this.modelo = novoModelo;
        }

        public void setMarca(string novaMarca)
        {
            this.marca = novaMarca;
        }

        public void setCor(string novaCor)
        {
            this.cor = novaCor;
        }
    }
}
