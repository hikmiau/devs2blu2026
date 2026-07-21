using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO03
{
    internal class PlacaDeVideo
    {
        public string nome;
        public int vram;
        public Marca marca;
        public double frequencia;

        public PlacaDeVideo() { }
        public PlacaDeVideo(string nome, int vram, Marca marca, double frequencia)
        {
            this.nome = nome;
            this.vram = vram;
            this.marca = marca;
            this.frequencia = frequencia;
        }
    }
}
