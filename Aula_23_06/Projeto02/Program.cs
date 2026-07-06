namespace Projeto02;

class Program
{
    static string[] alunos = [];
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Console.WriteLine("Quantos alunos tem na turma?");
        int qtd =  int.Parse(Console.ReadLine());
        alunos = new string[qtd];

        while (true)
        {
            Console.WriteLine("(1) - Cadastrar");
            Console.WriteLine("(2) - Listar");
            Console.WriteLine("(0) - Sair");
            int menu =  int.Parse(Console.ReadLine());
            if (menu == 0) break;
            
            switch(menu)
            {
                case 1:  CadastrarAluno(); break;
                case 2:  ListarAlunos(); break;
                default: break;
            }
        } 
       

       
    }

    static void     CadastrarAluno()
    {
        for (var i = 0; i < alunos.Length; i++)
        {
            Console.Write($"Digite o nome do {i+1}º aluno: ");
            alunos[i] = Console.ReadLine();
        }
    }
    static void ListarAlunos()
    {
        Console.Clear();
        Console.WriteLine("Listagem de alunos");
        for (var i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine(alunos[i]);
        }
    }
    
}