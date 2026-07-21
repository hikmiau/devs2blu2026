<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPoo01.Exercicios
{
    internal class Produto
    {
        public int Id;
        public string Nome;
        public double Quantidade;

        public Produto(int id, string nome, double quantidade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Quantidade = quantidade;
        }

        public void mostrarDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Quantidade: " + this.Quantidade);
        }

        public void reduzirEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                quantidade--;
            }
            else
            {
                Console.WriteLine("Nao tem estoque para reduzir.");
            }
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
    internal class Produto
    {
        public int Id;
        public string Nome;
        public int Quantidade;

        public Produto(int id, string nome, int quantidade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Quantidade = quantidade;
        }

        public void mostrarDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Quantidade: " + this.Quantidade);
        }

        public void reduzirEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                quantidade--;
            }
            else
            {
                Console.WriteLine("Nao tem estoque para reduzir.");
            }
        }
    }
}
>>>>>>> ce3bbc3903b9bd764a9004d751b7c0f7f6757645
