namespace ListaExercicios;

class Program
{
    static void Main(string[] args)
    {
        // 1.Crie uma lista vazio.
        List<int> numeros = new List<int>();
        
        // 2. Adicione cinco números inteiros na lista.
        numeros.Add(1);
        numeros.Add(2);
        numeros.Add(3);
        numeros.Add(4);
        numeros.Add(5);
        
        // 3. Acesse o terceiro elemento da lista criado no exercício anterior.
        int terceiroElemento = numeros[2];
        
        // 4. Substitua o segundo elemento da lista pelo valor 42.
        numeros[1] = 42;
        
        // 5. Adicione um novo elemento com o valor 7 ao final da lista.
        numeros.Add(7);
        
        // 6. Remova o primeiro elemento da lista.
        numeros.RemoveAt(0);
        // 7. Encontre o índice do valor 42 na lista.
        int numero = numeros.IndexOf(42);
            // int indice = numeros.FindIndex(n => n == 42);
            
        // 8. Crie uma lista com nomes de frutas (por exemplo, maçã, banana,
        //     morango).
        List<string> frutas = new List<string>();
        frutas.Add("banana");
        frutas.Add("pera");
        frutas.Add("morango");
        frutas.Add("laranja");
        
        // 9. Adicione "uva" e "abacaxi" ao final da lista.
        frutas.Add("uva");
        frutas.Add("abacaxi");
        
        // 10. Remova "banana" da lista.
        frutas.Remove("banana");
        
        // 11. Verifique se "morango" está na lista.
                // for (int i = 0; i < frutas.Count; i++)
                // {
                //     if(frutas[i] == "morango") Console.WriteLine("Encontrei");
                // }
                // // Console.WriteLine(frutas.Contains("morango") ? "Encontrei":"Nao encontrei");
        if(frutas.Contains("morango")) Console.WriteLine("Encontrei");
                
                
        // 12. Crie uma lista com números inteiros e calcule a soma de todos os
        // elemento
        Console.WriteLine("Soma dos numeros: "+numeros.Sum());
        
        // 13. Faça um programa que leia números inteiros do teclado (1-Novo
        // Numero 2-Sair) e armazene em uma lista. Ao final, imprima a lista
        // armazenada.

        while (true)
        {
            Console.Write("1 - Novo\n2 - Sair\nOpcao: ");
            int menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 2) break;

            Console.WriteLine("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            numeros.Add(num);
        }
        
        // 14. Crie um programa que permita ao usuário digitar uma lista de
        // palavras (strings) até que ele digite a palavra "fim". Em seguida,
        // exiba todas as palavras digitadas.
        List<string> palavras = new List<string>();
        while (true)
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            
            if(palavra == "fim") break;
            
            palavras.Add(palavra);
        }

        Console.WriteLine("\nPalavras\n");
        
        for (var i = 0; i < palavras.Count; i++)
        {
            Console.WriteLine(palavras[i]);
        }
        // Desenvolva uma programa que permita ao usuário inserir 5
        // números inteiros em uma lista. Em seguida, calcule e exiba a média
        // desses números.

        List<int> numeros_media = new List<int>();
        
        for (var i = 0; i < 5; i++)
        {
            numeros_media.Add(Convert.ToInt32(Console.ReadLine()));
        }

        Console.WriteLine("Media: " + numeros_media.Average());
        
        // 1) Ler uma lista com 10 names de pessoas, após pedir que o usuário digite
        //     uma name qualquer de pessoa. Escrever a mensagem “ACHEI”
        //     , se o
        // name estiver armazenado na lista ou “NÃO ACHEI” caso contrário.
        List<string> pessoas =  new List<string>();
        
        pessoas.Add("Pedro");
        pessoas.Add("Maria");
        pessoas.Add("Joao");
        pessoas.Add("Celia");
        pessoas.Add("Cacia");
        pessoas.Add("Carlos");
        pessoas.Add("Carla");
        pessoas.Add("Carmen");
        pessoas.Add("Dez");

        Console.WriteLine("Digite o nome de uma pessoa: ");
        string nome =  Console.ReadLine();
        
        if(pessoas.Contains(nome))
        {
            Console.WriteLine("ACHEI");
        }
        else
        {
            Console.WriteLine("NÃO ACHEI");
        }
        

    }
}