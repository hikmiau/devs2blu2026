using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NaveEspacial> naves = new List<NaveEspacial>();
            NaveEspacial naveCarga = new NaveDeCarga("Velocity Entregas", 80);
            NaveEspacial naveExploradora = new NaveExploradora("Sonda Horizonte", 60);

            naves.Add(naveCarga);
            naves.Add(new NaveDeCarga("Nave Errada", 100));
            naves.Add(new NaveDeCombate("Exercito Espacial Brasileiro", 90));
            naves.Add(new NaveDeCombate("Joel Militar", 100));
            naves.Add(new NaveDeLuxo("Banheiro de Posto", 70));
            naves.Add(new NaveDeLuxo("Discowave", 100));
            naves.Add(naveExploradora);

            CentralDeDocas docas = new CentralDeDocas();
            docas.AutorizarDecolagem(naveCarga);
            docas.AutorizarDecolagem(naveExploradora);

            foreach (NaveEspacial nave in naves)
            {
                nave.Decolar();
                if (nave is ITeletransportavel naveTeletransportavel)
                {
                    naveTeletransportavel.Teletransportar("Estação Alfa");
                }
            }

            PainelDeControle painel = new PainelDeControle();
            painel.ExibirStatus(naves);
        }
    }
}
