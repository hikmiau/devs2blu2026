namespace ListaExercicios;

class Program
{
    static void Main(string[] args)
    {
        List<string> lista = new List<string>();
        // 1. Lista com 5 Numeros/elementos
        lista.Add("1");
        lista.Add("2");
        lista.Add("3");
        lista.Add("4");
        lista.Add("5");
        
        // 2. Acessa o nome dos elementos na lista
        Console.WriteLine("Os numeros desta lista são:");
        for (var i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }
        
        // 3. Acessa o terceiro elemento da lista
        Console.WriteLine("O terceiro elemento da lista é:");
        Console.WriteLine(lista[3]);
        
        // 4. Substitui o segundo elemento da lista pelo valor "42"
        lista.RemoveAt(1);
        lista.Insert(1, "42");
        Console.WriteLine("A numero 2 foi substituido por 42:");
        
        // 5. Novo elemento de valor "7" é adicionado na lista.
        lista.Add("7");
        Console.WriteLine("A nova lista com o numero 7 é:");
        
        // 6. Remove o primeiro elemento da lista
        lista.RemoveAt(0);
        Console.WriteLine("A nova lista sem o primeiro elemento é:");
        for (var i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }
        
        // 7. Encontra o elemento de valor "42" na lista
        lista.Find(x => x == "42");
        
        //8. Criar uma lista com nomes de frutas
        {
            List<string> frutas = new List<string>();
            frutas.Add("Maça");
            frutas.Add("Banana");
            frutas.Add("Morango");
        }
    }
}
   