using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO06.Exercicios.Ex03
{
    internal class Estudante : Pessoa

    {
        public string Matricula { get; set; }

        public Estudante(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }
}
