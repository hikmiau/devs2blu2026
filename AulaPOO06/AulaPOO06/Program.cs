using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulaPOO06.Exercicios.Ex06;

namespace AulaPOO06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex06();
        }

        void Exemplo()
        {
            Professor professor = new Professor(1, "Joao Java", "111-111-111.11", "(67) 91111-1111", "Ciencias Humanas");
            professor.MostrarDados();
            Aluno aluno = new Aluno(1, "Celia Csharp", "111-111-111.12", "(67) 91111-1112", "sim");
            aluno.MostrarDados();
        }
        static void Ex06()
        {
            Cachorro cachorro = new Cachorro("Fogareu", "Canis lupus familiaris", "Shiba");
            cachorro.FazerSom();
            Gato gato = new Gato("Geremias", "Felis catus", "Azul");
            gato.FazerSom();
        }

    }
}
