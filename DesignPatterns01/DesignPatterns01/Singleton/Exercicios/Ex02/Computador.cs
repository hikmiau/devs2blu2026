namespace DesignPatterns01.Singleton.Exercicios;

public class Computador
{
    private GerenciadorLicenca gerenciador;

    public string Nome { get; set; }
    public string UsuarioResponsavel { get; set; }

    public Computador(string nome, string usuarioResponsavel)
    {
        Nome = nome;
        UsuarioResponsavel = usuarioResponsavel;
        gerenciador = GerenciadorLicenca.ObterInstancia();
    }

    public void AtivarLicenca(string chave, DateTime validade)
    {
        gerenciador.AtivarLicenca(chave, validade);
    }

    public void DesativarLicenca()
    {
        gerenciador.DesativarLicenca();
    }

    public void RenovarLicenca(DateTime novaValidade)
    {
        gerenciador.RenovarLicenca(novaValidade);
    }

    public void ConsultarLicenca()
    {
        gerenciador.ExibirInformacoes();
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Usuário Responsável: {UsuarioResponsavel}");
    }
}