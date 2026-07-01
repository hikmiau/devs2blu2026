namespace Aula_26_06;

class Program
{
    static void Main(string[] args)
    {
        ex05();
            
    }

    static void ex02()
    {
        string usuario = "";
        string senha ="";

        while (true)
        {
            Console.WriteLine("Digite seu usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();
            
            if(usuario != senha) break;
            else Console.WriteLine("Usuario e senha iguais, digite novamente");
        }
        
    }

    static void ex03()
    {
        string nome = "";

        while (true)
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            if (nome.Length > 3) break;
            Console.WriteLine("Precisa ter mais que 3 caracteres");
        }
        
        //
        Console.WriteLine("Digite sua idade");
        int idade = int.Parse(Console.ReadLine());

        while (idade > 150 || idade <= 0)
        {
            Console.WriteLine("Idade inválida. Digite novamente.");
            idade = int.Parse(Console.ReadLine());
        }
        //
        Console.WriteLine("Digite seu salario: ");
        double salario = double.Parse(Console.ReadLine());
        
        while (salario <= 0)
        {
            Console.WriteLine("Salario inválido. Digite novamente.");
            salario = double.Parse(Console.ReadLine());
        }
        //

        Console.WriteLine("Sigite seu sexo: F - M");
        string sexo = Console.ReadLine().ToUpper();
        while (sexo != "F" && sexo != "M")
        {
            Console.WriteLine("Sexo inválido. Digite novamente.");
            sexo = Console.ReadLine().ToUpper();
        }

        Console.WriteLine("Digite seu estado civil, s-c-v-d");
        string estado = Console.ReadLine();
        while (estado != "s" && estado != "c" && estado != "v" && estado != "d")
        {
            Console.WriteLine("Estado civil invalido, digite novamente");
            estado = Console.ReadLine().ToUpper();
        }
    }

    static void ex04()
    {
        // Supondo que a população de um país A seja da ordem de 80000 habitantes com uma taxa anual de
        // crescimento de 3% e que a população de B seja 200000 habitantes com uma taxa de crescimento de
        // 1.5%. Faça um programa que calcule e escreva o número de anos necessários para que a população
        // do país A ultrapasse ou iguale a população do país B, mantidas as taxas de crescimento.

        double popA = 80000;
        double popB = 200000;
        double taxaA = 3;
        double taxaB = 1.5;
        int qtdAnos = 0;
        Console.WriteLine("taxa popA: "+popA * (taxaA /100));
        Console.WriteLine("taxa popB: "+popB * (taxaB /100));
        
        while (popB > popA)
        {
            popA += (popA * (taxaA /100)); 
            popB += (popB * (taxaB /100));
            qtdAnos++;
            Console.WriteLine("Ano: "+qtdAnos);
            Console.WriteLine("Populacao do A: "+popA);
            Console.WriteLine("Populacao do A: "+popB);
            Console.WriteLine();
            
        }
        Console.WriteLine("Número de anos necessários: " + qtdAnos);
    }

    static void ex05()
    {
        // Faça um programa que calcule o fatorial de um número inteiro
        // fornecido pelo usuário. Ex.:
        // 5!=5.4.3.2.1=120


        Console.WriteLine("Digite um número inteiro para calcular o fatorial: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = numero-1; i >1; i--)
        {
            Console.WriteLine($"Fatorial de {numero}: {numero} * {i} = {numero * i}");
            
            numero *= i;
           
        }
        
        
        
    }
}