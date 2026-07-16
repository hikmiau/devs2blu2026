using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPoo01.Exercicios
{
    internal class PersonagemDeJogo
    {
        public string Id;
        public string Nome;
        public string Classe;
        public int Vida;
        public int Forca;

        public PersonagemDeJogo(int id, string nome, string classe, int vida, int forca)
        {
            this.Id = id;
            this.Nome = nome;
            this.Classe = classe;
            this.Vida = vida;
            this.Forca = forca;
        }

        public OponenteDeJogo(int idOponente, string nomeOponente, int vidaOponente, int forcaOponente)
        {
            this.Id = idOponente;
            this.Nome = nomeOponente;
            this.Vida = vidaOponente;
            this.Forca = forcaOponente;
        }

        public void atacar()
        {
            if (classe = "cavaleiro")
            {
                Console.WriteLine("Voce golpeia o oponente com sua espada.");
                entregarDano();
            }

            if (classe = "assassino")
            {
                Console.WriteLine("Voce corta o oponente com uma adaga.");
                entregarDano();
            }

            if (classe = "arqueiro")
            {
                Console.WriteLine("Voce atira uma flecha no seu oponente.");
                entregarDano();
            }

            if (classe = "mago")
            {
                Console.WriteLine("Voce conjura uma bola de fogo e a joga no oponente.");
                entregarDano();
            }
        }

        public void entregarDano(int dano)
        {
            dano = forca;
            vidaOponente - dano;
        }

        public void receberDano(int dano)
        {
            dano = forcaOponente;
            vida - dano;
        }

        public void exibirStatus()
        {
            Console.WriteLine("*** STATUS ***\n");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Classe: " + classe);
            Console.WriteLine("Vida: " + vida);
        }
    }
}
