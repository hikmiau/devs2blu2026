using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO.Exercicios.ExercicioPedido
{
    internal class Pedido
    {
        public int numero;
        public string cliente;
        public string status;
        public List<Produto1> itens;

        public Pedido(int numero, string cliente, string status)
        {
            this.numero = numero;
            this.cliente = cliente;
            this.status = status;
            this.itens = new List<Produto1>();
        }

        public void adicionarItem(Produto1 produto)
        {
            itens.Add(produto);
            Console.WriteLine("Produto adicionado com sucesso!");
        }

        public void calcularTotal()
        {
            double soma = 0;

            for (int i = 0; i < itens.Count; i++)
            {
                soma += itens[i].preco;
            }
            Console.WriteLine($"Total: R${soma}");
        }
    }
}
