using System;
using System.Collections.Generic;

namespace AulaPOO0a
{
    internal class PainelDeControle
    {
        public void ExibirStatus(IEnumerable<NaveEspacial> naves)
        {
            foreach (NaveEspacial nave in naves)
            {
                Console.WriteLine($"{nave.Nome} - Combustível: {nave.Combustivel}");
            }
        }
    }
}
