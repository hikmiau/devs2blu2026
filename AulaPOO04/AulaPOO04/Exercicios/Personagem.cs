using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO04.Exercicios
{
    internal class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; private set; }

        public Personagem(string nome, int vida)
        {
            this.Vida = AjustarVida(vida);
            this.Nome = nome;
        }

        private int AjustarVida(int vida)
        {
            if (vida < 0)
                return 0;
            else if (vida > 100)
                return 100;
            else
                return vida;
        }

        public void ReceberDano(int dano)
        {
            this.Vida = AjustarVida(this.Vida - dano);
        }

        public void Curar(int pontosDeVida)
        {
            this.Vida = AjustarVida(this.Vida + pontosDeVida);
        }
    }
}
