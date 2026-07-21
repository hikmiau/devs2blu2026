using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Produto p01 = new Produto("Bola azul", 10.90, 76);
            // Produto p02 = new Produto("Bola Amarela", 10.90, 76);
            // Produto p03 = new Produto("Bola Vermelha", 10.90, 76);
            //
            // List<Produto> produtos = new List<Produto>();
            //
            // Produto p04 = new Produto();
            //
            // produtos.Add(p04);
            //
            // produtos.Add(p04);
            //
            // p04.MostrarDados();
            //
            // Marca marca = new Marca("Nike", "daqui");
            // p01.marca = marca;
            // p01.marca = new Marca();
            // Console.WriteLine(p01.marca.nome);

            // foreach (Produto item in produtos)
            // {
            //     item.preco = 10;
            // }
            // produtos.ForEach(p => p.preco = 10);
            //
            // produtos[0].MostrarDados();
            // Console.WriteLine();
            //
            // for (int i = 0; i < produtos.Count; i++)
            // {
            //     produtos[i].MostrarDados();
            // }
            // Console.WriteLine();
            // produtos[0].MostrarDados();
            Marca marca = new Marca("Nike", "daqui");

            PlacaDeVideo placa = new PlacaDeVideo("NTX 3060", 90, marca, 2.5);
            Computador computador = new Computador("Haland", "i9", 6 + 3, placa);
            Console.WriteLine(computador.PlacaDeVideo.nome);
        }
    }
}
