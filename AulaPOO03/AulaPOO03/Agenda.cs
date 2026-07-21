using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO03
{
    internal class Agenda
    {
        public string nome;
        public List<Contato> contatos;

        public Agenda(string nome)
        {
            this.nome = nome;
            this.contatos = new List<Contato>();
        }

        public Agenda(string nome, List<Contato> contatos)
        {
            this.nome = nome;
            this.contatos = contatos;
        }

        public void RemoverContato(int id)
        {
            contatos.RemoveAll(c => c.id == id);

            Console.WriteLine("Contato removido com sucesso");
        }
    }
}
