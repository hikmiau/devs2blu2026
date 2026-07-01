namespace ExercicioListasMusica;

class Program
{
    static void Main(string[] args)
    {
        List<string> musicas = new List<string>();
        void AdicionarMusica()
        {
            Console.WriteLine("Digite o nome da musica: ");
            musicas.Add(Console.ReadLine());
        }

        void ListarPlaylist()
        {
            Console.WriteLine("Musicas da playlist: ");
        }
    }
}