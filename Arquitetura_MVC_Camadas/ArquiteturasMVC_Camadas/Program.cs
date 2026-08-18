using ArquiteturasMVC_Camadas.controllers;
using ArquiteturasMVC_Camadas.views;

namespace ArquiteturasMVC_Camadas;

class Program
{
    static void Main(string[] args)
    {
        Exercicio();
    }

    static void Exemplo()
    {
        AlunoController controller = new AlunoController(new AlunoView());
        controller.Executar();
    }

    static void Exercicio()
    {
        ProfessorController controller1 = new ProfessorController(new ProfessorView());
        controller1.Executar();
    }
}