using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO05.TrabalhoCafeteria
{
    internal class ItemCardapio
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Categoria { get; set; } // ex: Bebidas, Sobremesas
        public decimal PrecoBase { get; set; }
        public bool EstaDisponivel { get; private set; }

        public ItemCardapio(
            int id,
            string nome,
            string categoria,
            decimal precoBase,
            bool estaDisponivel
        )
        {
            this.Id = id;
            this.Nome = nome;
            this.Categoria = categoria;
            this.PrecoBase = precoBase;
            if (precoBase <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "O preco base nao pode ser menor ou igual a zero."
                );
            }
            this.EstaDisponivel = estaDisponivel;
        }

        public void PausarVendas()
        {
            this.EstaDisponivel = false;
        }

        public void ReativarVendas()
        {
            this.EstaDisponivel = true;
        }

        public void AplicarDesconto(decimal porcentagem)
        {
            if (porcentagem > 30)
            {
                Console.WriteLine("AVISO: O desconto aplicado nao pode ser superior a 30%.");
                return;
            }
            if (porcentagem < 0)
            {
                Console.WriteLine("AVISO: O desconto nao pode ser negativo.");
            }
            decimal valorDesconto = (this.PrecoBase * porcentagem) / 100;
            this.PrecoBase -= valorDesconto;
        }
    }
}
