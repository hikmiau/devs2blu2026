using ArquiteturasMVC_Camadas.models;

namespace ArquiteturasMVC_Camadas.views;

public class ProfessorView
{
    public int ExibirMenu()
    {
        Console.WriteLine("\n=== Menu ===\n");
        Console.WriteLine("1 - Adicionar Professor");
        Console.WriteLine("2 - Listar Professores");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha uma opção: ");
        return int.Parse(Console.ReadLine());
    }

    public Professor ColetarDados()
    {
        Console.Write("\nNome: ");
        string nome = Console.ReadLine();
        Console.Write("Salário: ");
        double salario = double.Parse(Console.ReadLine());
        return new Professor { Nome = nome, Salario = salario };
    }

    public void ExibirMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    public void ListarProfessores(List<Professor> professores)
    {
        foreach (var professor in professores)
        {
            Console.WriteLine($"ID: {professor.Id}, Nome: {professor.Nome}, Salário: {professor.Salario}");
        }
    }
}