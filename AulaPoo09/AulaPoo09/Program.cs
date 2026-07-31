using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NaveEspacial> naves = new List<NaveEspacial>();
            naves.Add(new NaveDeCarga("Velocity Entregas",80));
            naves.Add(new NaveDeCarga("Nave Errada",100));
            naves.Add(new NaveDeCombate("Exercito Espacial Brasileiro", 90));
            naves.Add(new NaveDeCombate("Joel Militar", 100));
            naves.Add(new NaveDeLuxo("Banheiro de Posto", 70));
            naves.Add(new NaveDeLuxo("Discowave", 100));

            foreach (NaveEspacial nave in naves)
            {
                nave.Decolar();
                if (nave is ITeletransportavel naveTeletransportavel)
                {
                    naveTeletransportavel.Teletransportar("\n");
                    Console.WriteLine("------");
                }
            }
        }
    }
}
