namespace CadastroNotas;

class Program
{
    static string[] notas = [];
    
    static void Main(string[] args)
    {
        
        Console.WriteLine("Quantas notas você quer cadastrar?");
        int qtd = int.Parse(Console.ReadLine());
        notas = new string[qtd];

        while (true)
        {
            Console.WriteLine("(1) - Cadastrar");
            Console.WriteLine("(2) - Listar");
            Console.WriteLine("(0) - Sair");
            int menu = int.Parse(Console.ReadLine());
            if (menu == 0) break;

            switch (menu)
            {
                case 1: CadastrarNota(); break;
                case 2: ListarNotas(); break;
                default: break;
            }
        }



    }

    static void CadastrarNota()
    {
        for (var i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a {i + 1} nota que o aluno teve:  ");
            notas[i] = Console.ReadLine();
        }
    }

    static void ListarNotas()
    {
        Console.Clear();
        Console.WriteLine("Listagem de notas");
        for (var i = 0; i < notas.Length; i++)
        {
            Console.WriteLine(notas[i]);
        }
    }
}