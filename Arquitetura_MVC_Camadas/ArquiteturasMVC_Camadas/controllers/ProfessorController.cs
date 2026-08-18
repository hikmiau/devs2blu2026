using ArquiteturasMVC_Camadas.models;
using ArquiteturasMVC_Camadas.views;

namespace ArquiteturasMVC_Camadas.controllers;

public class ProfessorController
{
    private readonly List<Professor> _repositorioProfessor = new();
    private readonly ProfessorView _view;
    
    public ProfessorController(ProfessorView view)
    {
        _view = view;
    }
    
    public void Executar()
    {
        bool rodando = true;
        while (rodando)
        {
            int opcao = _view.ExibirMenu();
            switch (opcao)
            {
                case 1:
                    AdicionarProfessor();
                    break;
                case 2:
                    ListarProfessores();
                    break;
                case 0:
                    rodando = false;
                    _view.ExibirMensagem("Saindo do sistema...");
                    break;
                default:
                    _view.ExibirMensagem("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
    
    private void AdicionarProfessor()
    {
        Professor novoProfessor = _view.ColetarDados();
        novoProfessor.Id = _repositorioProfessor.Count + 1;
        _repositorioProfessor.Add(novoProfessor);
        _view.ExibirMensagem("Professor cadastrado com sucesso!");
    }
    
    private void ListarProfessores()
    {
        _view.ListarProfessores(_repositorioProfessor);
    }
}