namespace ExercicioForWhile;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**** Cadastro de Usuario ****\n");
        Usuario();
    }
    static void Usuario()
    {
        Console.WriteLine("Digite seu nome de usuario: ");
        string nome =  Console.ReadLine();
        Console.WriteLine("Digite sua senha: ");
        string senha =  Console.ReadLine();
        if (nome == senha)
        {
            throw new Exception("Nome nao pode ser igual a senha.");
        }
    }
}