namespace CadastrosNotas;

class Program
{
    private static List<double> notas =  new List<double>();
    
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("(1) - Nova Nota");
            Console.WriteLine("(2) - Ver notas");
            Console.WriteLine("(0) - Sair");
            int menu =  int.Parse(Console.ReadLine());
            if (menu == 0) break;

            switch (menu)
            {
                case 1:
                    CadastrarNota();
                    break;
                case 2:
                    VerNotas(); break;
                default:
                    break;
            }

        }
        
    }

    private static void VerNotas()
    {
        for (var i = 0; i < notas.Count; i++)
        {
            Console.WriteLine($"{i+1}ª Nota: {notas[i]}");
        }
        Console.ReadKey();
    }

    private static void CadastrarNota()
    {
        Console.WriteLine("Digite a nota: ");
        double nota = double.Parse(Console.ReadLine());
        notas.Add(nota);
    }
}