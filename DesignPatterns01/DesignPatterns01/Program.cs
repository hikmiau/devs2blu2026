using DesignPatterns01.Factory;
using DesignPatterns01.Singleton;
using DesignPatterns01.Singleton.Exercicios;

namespace DesignPatterns01;

class Program
{
    static void Main(string[] args)
    {
        Ex02();
    }

    static void ExemploFactory()
    {
        NotificacaoFactory.CriarNotificacao("email")
            .Enviar("OLHA A MENSAGEM!");
    }

    static void ExemploSingleton()
    {
        /*
        // Professor prof = new Professor();
        // prof.Nome = "Dr. Smith";
        // prof.Id = 1;
        //
        // Professor prof2 = new Professor();
        // prof2.Nome = "Marcos";
        // prof2.Id = 2;
        //
        // Console.WriteLine("-----------");
        // Console.WriteLine($"Professor 1: {prof.Nome}, ID: {prof.Id}");
        // Console.WriteLine($"Professor 2: {prof2.Nome}, ID: {prof2.Id}");
        // prof.MostrarDados();
        // prof2.MostrarDados();
        // Professor.Nome = "Red";
        // Console.WriteLine("\nNomes apos mudanca: ");
        // Console.WriteLine("Professor 1: ");
        // prof.MostrarDados();
        // Console.WriteLine("Professor 2: ");
        // prof2.MostrarDados();

        Professor prof01 = new Professor("John Doe");
        Professor prof02 = new Professor("Joana Doe");
        Professor prof03 = new Professor("Jeana Doe");
        Professor prof04 = new Professor("Joe Doe");

        new Professor("Joe Doe");
        new Professor("Joe Doe");
        new Professor("Joe Doe");
        new Professor("Joe Doe");
        prof01.MostrarDados();
        prof02.MostrarDados();
        prof03.MostrarDados();
        prof04.MostrarDados();
    */

        Logger logger = Logger.ObterInstancia();
        logger.Registrar();

        var config01 = GerenciadorDeConfiguracao.ObterInstancia();
        var config02 = GerenciadorDeConfiguracao.ObterInstancia();
        config01.Tema = "claro";
        config02.Tema = "azul";
        Console.WriteLine(config01.Tema);
        Console.WriteLine(config02.Tema);

    }

    static void Ex02()
    {
        var gerenciador1 = Singleton.Exercicios.GerenciadorLicenca.ObterInstancia();
        var gerenciador2 = Singleton.Exercicios.GerenciadorLicenca.ObterInstancia();

        gerenciador1.AtivarLicenca("ABC123", DateTime.Now.AddYears(1));
        gerenciador2.AtivarLicenca("DEF456", DateTime.Now.AddYears(1));

        if (ReferenceEquals(gerenciador1, gerenciador2))
        {
            Console.WriteLine("As instâncias são iguais (Singleton).");
        }
        else
        {
            Console.WriteLine("As instâncias são diferentes.");
        }

        Computador computador1 = new Computador("Computador 1", "Usuario 1");
        Computador computador2 = new Computador("Computador 2", "Usuario 2");
        Computador computador3 = new Computador("Computador 3", "Usuario 3");

        Console.WriteLine("\n*** COMPUTADOR 1 ***");
        computador1.ExibirDados();
        computador1.AtivarLicenca("ABC123", DateTime.Now.AddYears(1));
        computador1.ConsultarLicenca();
        computador1.RenovarLicenca(DateTime.Now.AddYears(2));
        computador1.ConsultarLicenca();
        computador1.DesativarLicenca();
        computador1.ConsultarLicenca();

        Console.WriteLine("\n*** COMPUTADOR 2 ***");
        computador2.ExibirDados();
        computador2.AtivarLicenca("DEF456", DateTime.Now.AddYears(1));
        computador2.ConsultarLicenca();
        computador2.RenovarLicenca(DateTime.Now.AddYears(2));
        computador2.ConsultarLicenca();
        computador2.DesativarLicenca();
        computador2.ConsultarLicenca();

        Console.WriteLine("\n*** COMPUTADOR 3 ***");
        computador3.ExibirDados();
        computador3.AtivarLicenca("GHI789", DateTime.Now.AddYears(1));
        computador3.ConsultarLicenca();
        computador3.RenovarLicenca(DateTime.Now.AddYears(2));
        computador3.ConsultarLicenca();
        computador3.DesativarLicenca();
        computador3.ConsultarLicenca();
    }
}