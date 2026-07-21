<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPoo01.Exercicios
{
    // internal class PersonagemDeJogo
    // {
    //     public string Id;
    //     public string Nome;
    //     public string Classe;
    //     public int Vida;
    //     public int Forca;
    //     public string idOponente;
    //     public string nomeOponente;
    //     public int vidaOponente;
    //     public int forcaOponente;
    //
    //     public PersonagemDeJogo(int id, string nome, string classe, int vida, int forca)
    //     {
    //         this.Id = id;
    //         this.Nome = nome;
    //         this.Classe = classe;
    //         this.Vida = vida;
    //         this.Forca = forca;
    //     }
    //
    //     public void criarPersonagem()
    //     {
    //       Console.WriteLine("Qual o seu nome?");
    //       nome = Console.ReadLine();
    //       Console.WriteLine("Escolha uma classe:\n");
    //       Console.WriteLine("(1) Cavaleiro");
    //       Console.WriteLine("(2) Assassino");
    //       Console.WriteLine("(3) Arqueiro");
    //       Console.WriteLine("(4) Mago");
    //
    //       switch(classe)
    //       {
    //         case 1: classe = "cavaleiro";
    //         case 2: classe = "assassino";
    //         case 3: classe = "arqueiro";
    //         case 4: classe = "mago";
    //       }
    //     }
    //
    //     public void atacar()
    //     {
    //         if (classe = "cavaleiro")
    //         {
    //             Console.WriteLine("Voce golpeia o oponente com sua espada.");
    //             entregarDano();
    //         }
    //
    //         if (classe = "assassino")
    //         {
    //             Console.WriteLine("Voce corta o oponente com uma adaga.");
    //             entregarDano();
    //         }
    //
    //         if (classe = "arqueiro")
    //         {
    //             Console.WriteLine("Voce atira uma flecha no seu oponente.");
    //             entregarDano();
    //         }
    //
    //         if (classe = "mago")
    //         {
    //             Console.WriteLine("Voce conjura uma bola de fogo e a joga no oponente.");
    //             entregarDano();
    //         }
    //     }
    //
    //     public void entregarDano(int dano)
    //     {
    //         dano = forca;
    //         vidaOponente -= dano;
    //     }
    //
    //     public void receberDano(int dano)
    //     {
    //         dano = forcaOponente;
    //         vida -= dano;
    //     }
    //
    //     public void exibirStatus()
    //     {
    //         Console.WriteLine("*** STATUS ***\n");
    //         Console.WriteLine("Nome: " + nome);
    //         Console.WriteLine("Classe: " + classe);
    //         Console.WriteLine("Vida: " + vida);
    //     }
    // }
    internal class PersonagemJogo
    {
        public string Nome;
        public string Classe;
        public int Vida;
        public int Forca;

        public PersonagemJogo(string nome, string classe, int vida, int forca)
        {
            this.Nome = nome;
            this.Classe = classe;
            this.Vida = vida;
            this.Forca = forca;
        }
        public void Atacar(PersonagemJogo inimigo)
        {
            Console.WriteLine(this.Nome + " deu um soco com " + this.Forca + " de dano em " + inimigo.Nome);
            inimigo.ReceberDano(this.Forca);
        }
        public void ReceberDano(int dano)
        {
            this.Vida -= dano;
            Console.WriteLine(this.Nome + " recebeu: " + dano + " de dano.");
        }
        public void ExibirStatus()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Classe: " + this.Classe);
            Console.WriteLine("Vida: " + this.Vida);
            Console.WriteLine("Forca: " + this.Forca);
        }
    }
}
=======
﻿using System;
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
>>>>>>> ce3bbc3903b9bd764a9004d751b7c0f7f6757645
