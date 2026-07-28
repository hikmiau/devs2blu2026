using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO06
{
    internal class Aluno : Pessoa
    {
        public string Matricula;

        public Aluno(int id, string nome, string cpf, string telefone, string matricula)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Matricula = matricula;
        }
    }
}
