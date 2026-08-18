using ArquiteturasMVC_Camadas.models;

namespace ArquiteturasMVC_Camadas.views;

public class AlunoView 
{
    public int ExibirMenu()
    {
        Console.WriteLine("\n==== ALUNO ====\n");
        Console.WriteLine("1) Cadastrar Aluno");
        Console.WriteLine("2) Listar Aluno");
        int menu = int.Parse(Console.ReadLine());
        return menu;
    }

    public Aluno ColetarDados()
    {
        Console.WriteLine("/nNome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Nota1: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Nota2: ");
        double nota = double.Parse(Console.ReadLine());
        
        return new Aluno { Nome = nome, Nota1 = nota1, Nota2 = nota };
    }

    public void ListarAlunos(List<Aluno> alunos)
    {
        Console.WriteLine("=== RELATORIO ALUNO ===");
        Console.WriteLine($"{alunos.Count} alunos");
        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
            return;
        }

        foreach (var aluno in alunos)
        {
            ExibirAluno(aluno);
        }
    }

    public void ExibirAluno(Aluno aluno)
    {
        Console.WriteLine($"\n{aluno.Id} - {aluno.Nome}");
        Console.WriteLine($"Nota1: {aluno.Nota1}");
        Console.WriteLine($"Nota2: {aluno.Nota2}");
        Console.WriteLine($"Aprovado: {(aluno.isAprovado() ? "Sim" : "Não")}");
    }

    public void ExibirMensagem(string mensagem)
    {
        Console.WriteLine($"\n[AVISO] {mensagem}");
    }
}