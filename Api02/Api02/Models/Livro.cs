namespace Api02.Models
{
    public class Livro
    {
        public int id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }
        public decimal Preco {  get; set; }
    }
}
