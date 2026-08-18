using ArquiteturasMVC_Camadas.models;
using ArquiteturasMVC_Camadas.views;

namespace ArquiteturasMVC_Camadas.controllers;

public class AlunoController
{
    private readonly List<Aluno> _repositorioAluno = new();
    private readonly AlunoView _view;

    public AlunoController(AlunoView view)
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
                    AdicionarAluno();
                    break;
                case 2:
                    ListarAlunos();
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

    private void AdicionarAluno()
    {
        Aluno novoAluno = _view.ColetarDados();
        novoAluno.Id = _repositorioAluno.Count + 1;
        _repositorioAluno.Add(novoAluno);
        _view.ExibirMensagem("Aluno cadastrado com sucesso!");
    }

    private void ListarAlunos()
    {
        _view.ListarAlunos(_repositorioAluno);
    }



}