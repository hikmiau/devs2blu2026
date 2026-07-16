using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPoo01
{
    internal class Cliente
    {
        public int Id;
        public string Name;
        public double Altura;
        public string Cpf;

        public Cliente(int id, string nome, string cpf)
        {
            this.Id = id;
            this.Name = nome;
            this.Cpf = cpf;
        }

        
    }
}
