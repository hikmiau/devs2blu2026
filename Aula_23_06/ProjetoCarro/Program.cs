namespace ProjetoCarro;

class Program
{
    
    static void Main(string[] args)
    {
        List<string> lista_carros = new List<string>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("(1) - Novo Carro ");
            Console.WriteLine("(2) - Ver Carros");
            Console.WriteLine("(3) - Remover Carro");
            Console.WriteLine("(0) - Sair");
            int menu =  int.Parse(Console.ReadLine());
            if (menu == 0) break;
            switch (menu)
            {
                case 1:
                    NovoCarro(lista_carros);
                    break;
                case 2:
                    MostrarCarros(lista_carros);
                    break;
                case 3:
                    RemoverCarro(lista_carros);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.ReadKey();
        }

    }

    static void NovoCarro(List<string> carros)
    {
        Console.WriteLine("Digite o modelo do carro: ");
        string modelo =   Console.ReadLine();
        carros.Add(modelo);
    }

    static void MostrarCarros(List<string> carros)
    {
        Console.WriteLine("****** CARROS *****\n");
        for (var i = 0; i < carros.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {carros[i]}");
        }
        Console.WriteLine();
    }
    static void RemoverCarro(List<string> carros)
    {
        MostrarCarros(carros);
        Console.WriteLine("Digite o modelo do carro: ");
        string modelo =  Console.ReadLine();
        
        if(carros.Contains(modelo))        
        {
            Console.WriteLine("Deseja Excluir o registro? s/n");
            string excluido = Console.ReadLine().ToLower();
            switch (excluido)
            {
                case "s":
                    carros.Remove(modelo);
                    Console.WriteLine("Carro removido com sucesso!");
                    break;
                case "n":
                    Console.WriteLine("Operação cancelada.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
                
        }
        else
        {
            Console.WriteLine("Modelo nao encontrado");
        }
            
    }
      
    }
    

   
