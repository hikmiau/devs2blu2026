// string senha = Console.ReadLine();
//
// while (senha != "admin")
// {
//     Console.WriteLine("Digite uma senha: ");
//     senha = Console.ReadLine();
// }
//
// while (true)
// {
//     Console.WriteLine("1) Bom dia");
//     Console.WriteLine("2) Boa tarde");
//     Console.WriteLine("3) Boa noite");
//     Console.WriteLine("0) Sair");
//     int menu = Convert.ToInt32(Console.ReadLine());
//
//     if (menu == 0) break;
//
//     switch (menu)
//     {
//         case 1:
//             Console.WriteLine("Matutino");
//             break;
//         case 2:
//             Console.WriteLine("Vespertino");
//             break;
//         case 3:
//             Console.WriteLine("Noturno");
//             break;
//         default:
//             Console.WriteLine("Entrada Invalida");
//             break;
//     }
// }
//
// int[] notas = [10,9,8,7,4,3];
// int[] notas = new int[5];

// EXEMPLO---------------
// Console.WriteLine("Quantas notas voce quer cadastrar? ");
// int qtd = int.Parse(Console.ReadLine());
// int[] notas = new int[qtd];
//
// for (var i = 0; i < notas.Length; i++)
// {
//     Console.Write($"{i+1}ª nota: ");
//     notas[i] = int.Parse(Console.ReadLine());
// }
//
// for (int i = 0; i < notas.Length; i++)
// {
//     Console.WriteLine(notas[i]);
// }
//
// Console.WriteLine($"Media Final: {notas.Average()}");
// --------------

Console.WriteLine("Quantas notas voce quer cadastrar? ");
int qtd = int.Parse(Console.ReadLine());
int[] notas = new int[qtd];

for (var i = 0; i < notas.Length; i++)
{
    Console.Write($"{i + 1}ª nota: ");
    notas[i] = int.Parse(Console.ReadLine());
}
for (var i = 0; i < notas.Length; i++)
{
    Console.Write(notas[i]);
}

Console.WriteLine($"Media Final: {notas.Average()}");



// Console.WriteLine(notas[0]);
// Console.WriteLine(notas[1]);
// Console.WriteLine(notas[2]);
// Console.WriteLine(notas[3]);
//
// Console.WriteLine("Digite uma Nota");
// notas[0] = int.Parse(Console.ReadLine());
// notas[1] = int.Parse(Console.ReadLine());
// notas[2] = int.Parse(Console.ReadLine());
// for (int i = 0; i < 6; i++)
// {
//     Console.WriteLine(notas[i]);
// }