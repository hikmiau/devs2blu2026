using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO06
{
    internal abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public virtual void MostrarDados()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cpf: {Cpf}");
            Console.WriteLine($"Telefone: {Telefone}");
        }
    }
}
