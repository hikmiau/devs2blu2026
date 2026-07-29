namespace AulaPOO08;

class Program
{
    static void Main(string[] args)
    {
        Gato gato = new Gato();
        gato.Nome = "Jerundio";

        Pinguim pinguim = new Pinguim();
        pinguim.Nome = "Preterito";

        Tubarão tubarao = new Tubarão();
        tubarao.Nome = "C-Shark";

        List<ICacador> cacadores = new List<ICacador>();
        cacadores.Add(pinguim);
        cacadores.Add(gato);
        cacadores.Add(tubarao);

        foreach (ICacador c in cacadores)
        {
            Console.WriteLine($"O {c.GetType().Name} chamado {((Animal)c).Nome} está caçando");
            c.Caçar();
        }

      
    }
}