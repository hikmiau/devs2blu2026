namespace camadas.Models;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public int Idade { get; set; }

    public Usuario(int id, string nome, string email, string senha, int idade)
    {
        Nome = nome;
        Email = email;
        Senha = senha;
        Idade = idade;
    }
}