using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO05
{
    internal class Produto
    {
        public string Nome { get; set; }

        public double PrecoBase { get; set; }

        public double PorcentagemDesconto { get; set; }

        public double PrecoFinal => PrecoBase - (PorcentagemDesconto / 100 * PrecoBase);

        public Produto(string nome, double precoBase, double porcentagemDesconto)
        {
            if (precoBase < 0)
                throw new ArgumentOutOfRangeException("O valor do produto nao pode ser negativo");
            if (porcentagemDesconto < 0 || porcentagemDesconto > 50)
                throw new ArgumentOutOfRangeException(
                    "O valor da porcentagem nao pode passar do limite de 0-50%"
                );
            this.Nome = nome;
            this.PrecoBase = precoBase;
            this.PorcentagemDesconto = porcentagemDesconto;
        }
    }
}
