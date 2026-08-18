using camadas.Repositories;
using camadas.Views;
using camadas.Services;

namespace camadas.Controllers;

public class UsuarioController
{
    private readonly UsuarioService _service;
    private readonly UsuarioView _view;
    
    public UsuarioController(UsuarioService service, UsuarioView view)
    {
        _service = service;
        _view = view;
    }
}