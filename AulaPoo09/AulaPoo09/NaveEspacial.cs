using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO0a
{
    internal abstract class NaveEspacial
    {
        public string Nome { get; set; }
        public int Combustivel { get; private set; }
        public NaveEspacial(string nome, int combustivel)
        {
            this.Nome = nome;
            if (combustivel < 0)
            {
                combustivel = 0;
            }
            if (combustivel > 100)
            {
                combustivel = 100;
            }
            this.Combustivel = combustivel;
        }
        public void NomeVazio()
        {
            if(this.Nome == null)
            {
                throw new ArgumentException("O nome esta vazio!");
            }
        }
        public virtual void Abastecer(int litros)
        {
            if (litros < 0)
            {
                litros = 0;
            } 
            if (litros > 100)
            {
                litros = 100;
            }
            this.Combustivel += litros;
            if (this.Combustivel > 100)
            {
                this.Combustivel = 100;
            }
        }

        public abstract void Decolar();

    }
}
