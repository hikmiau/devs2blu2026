namespace Api02.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }
        public decimal Preco { get; set; }

        public int GeneroId { get; set; }
        public Genero Genero { get; set; }

        // http://localhost:3080/api/livro?autor
    }
}
