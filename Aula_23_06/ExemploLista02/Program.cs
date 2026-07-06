using System.Globalization;

namespace ExemploLista02;

class Program
{
    static void Main(string[] args)
    {
        List<string> frutas = new List<string>();
        frutas.Add("Maracuja");
        frutas.Add("Banana");
        frutas.Add("Maca");
        frutas.Add("Melancia");
        frutas.Add("Morango");

        frutas.RemoveRange(200,3);
        
        for (var i = 0; i < frutas.Count; i++)
        {
            Console.WriteLine(frutas[i]);
        }

    }
    
    static void exemplo02()
    {
        List<string> alunos = new List<string>();

        while (true)
        {
            Console.WriteLine("Digite o nome do aluno ou \"sair\" ");
            string nome =  Console.ReadLine();
            
            if(nome == "sair") break;
            alunos.Add(nome);
        }
        
        for (var i = 0; i < alunos.Count; i++)
        {
            Console.WriteLine(alunos[i]);
        }
    }
    
}