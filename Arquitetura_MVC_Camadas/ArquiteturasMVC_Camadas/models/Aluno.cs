namespace ArquiteturasMVC_Camadas.models;

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Media() => (Nota2 + Nota1)/2;
    public bool isAprovado() => Media() >= 7.0;
}