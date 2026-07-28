using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO06
{
    internal class Professor : Pessoa
    {
        public string AreaConhecimento {  get; set; }

        public Professor(int id, string nome, string cpf, string telefone, string areaConhecimento) {         
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            AreaConhecimento = areaConhecimento;
        }
        public override void MostrarDados()
        {
            Console.WriteLine($"Eu sou o professor {Nome}");
        }
    }
}
