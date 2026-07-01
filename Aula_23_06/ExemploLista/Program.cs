namespace ExemploLista;

class Program
{
    static void Main(string[] args)
    {
        List<string> alunos = new List<string>();
        
        alunos.Add("Pedro");
        alunos.Add("Maria");
        alunos.Add("Joao");
        //criar um cadastro de notas
        
        for (var i = 0; i < alunos.Count; i++)
        {
            Console.WriteLine(alunos[i]);
        }
        

    }
}