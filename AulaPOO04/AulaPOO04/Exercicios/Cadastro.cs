using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO04
{
    internal class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, string cpf, int idade)
        {
            this.id = new Random().Next(0, 1000);
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
        }

        public void Cadastro()
        {
            Console.WriteLine($"Digite o nome: {nome}");
            this.nome = Console.ReadLine();
            Console.WriteLine($"Digite a idade: {idade}");
            this.idade = int.Parse(Console.ReadLine());
            if (idade > 125 | idade <= 0)
            {
                Console.WriteLine("A idade deve ser entre 1 e 125.");
                return;
            }
            Console.WriteLine($"Digite o cpf: {cpf}");
            this.cpf = Console.ReadLine();
            if (cpf.Length != 11)
            {
                Console.WriteLine("O cpf deve ter 11 caracteres.");
                return;
            }
        }
    }
}
