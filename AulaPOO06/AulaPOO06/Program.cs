using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor(1, "Joao Java", "111-111-111.11", "(67) 91111-1111", "Ciencias Humanas");
            professor.MostrarDados();
            Aluno aluno = new Aluno(1, "Celia Csharp", "111-111-111.12", "(67) 91111-1112", "sim");
            aluno.MostrarDados();
        }
    }
}
