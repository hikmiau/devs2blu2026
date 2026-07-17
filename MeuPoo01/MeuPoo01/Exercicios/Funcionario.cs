using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPoo01.Exercicios
{
    internal class Funcionario
    {
        public string nome;
        public string cargo;
        public double salario;

        public Funcionario(string nome, string cargo, double salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public void aumentarSalario()
        {
            Console.WriteLine("Quanto do salario voce quer aumentar?");
            salario += Double.Parse(Console.ReadLine());
        }
    }
}
