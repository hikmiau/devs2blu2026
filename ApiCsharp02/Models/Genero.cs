using System.Text.Json.Serialization;

namespace Api02.Models;

public class Genero
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;

    [JsonIgnore]
    public List<Livro> Livros { get; set; } = new List<Livro>();
}
