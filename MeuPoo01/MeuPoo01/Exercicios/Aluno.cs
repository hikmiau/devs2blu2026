using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPoo01.Exercicios
{
    internal class Aluno
    {
        public int Id;
        public string Nome;
        public string Matricula;
        public double Nota1; 
        public double Nota2; 
        public double Nota3; 
        public double Nota4; 

        public Aluno(int id, string nome, string matricula)
        {
            this.Id = id;
            this.Nome = nome;
            this.Matricula = matricula;
        }
        public void mostrarMedia()
        {
            double media = (Nota1 + Nota2 + Nota3 + Nota4)/4;
            Console.WriteLine("Media final: " + media);

            if (media < 6) Console.WriteLine("Reprovado(a)");
            else Console.WriteLine("Aprovado(a)");
        }
    }
} 