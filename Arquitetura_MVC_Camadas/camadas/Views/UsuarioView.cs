namespace camadas.Views;

public class UsuarioView
{
    public string ExibirMenu()
    {
        Console.WriteLine("USER");
        Console.WriteLine("1) Listar Usuarios");
        Console.WriteLine("2) Cadastrar Usuario");
        Console.WriteLine("0) Sair");
        Console.WriteLine("Opcao: ");
        return Console.ReadLine();
    }
    public (string Nome, string Email, string Senha, int Idade) ColetarDados()
    {
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Email: ");
        string email = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Senha: ");
        string senha = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Idade: ");
        int idade = int.Parse(Console.ReadLine() ?? string.Empty);
        return (nome, email, senha, idade);
    }
    
    public void ListarUsuarios(List<Models.Usuario> usuarios)
    {
        Console.WriteLine("=== RELATORIO USUARIO ===");
        Console.WriteLine($"{usuarios.Count} usuarios");
        if (usuarios.Count == 0)
        {
            Console.WriteLine("Nenhum usuario cadastrado.");
            return;
        }

        foreach (var usuario in usuarios)
        {
            ExibirUsuario(usuario);
        }
    }
    
    private void ExibirUsuario(Models.Usuario usuario)
    {
        Console.WriteLine($"\n{usuario.Id} - {usuario.Nome}");
        Console.WriteLine($"Email: {usuario.Email}");
        Console.WriteLine($"Idade: {usuario.Idade}");
    }
}