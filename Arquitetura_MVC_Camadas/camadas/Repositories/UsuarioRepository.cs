using camadas.Models;

namespace camadas.Repositories;

public class UsuarioRepository
{
    private readonly List<Usuario> _usuarios = new()
    {
        new Usuario(1,"Tim Maia", "timmaia@soquerdinheiro.com", "timtim123", 18)
    };

    public int _proximoId = 2;

    public void Salvar(Usuario usuario)
    {
        usuario.Id = _usuarios.Count + 1;
        _usuarios.Add(usuario);
    }
    
    public Usuario? BuscarPorEmail(string email)
    {
        return _usuarios.FirstOrDefault(u => u.Email == email);
    }
    public List<Usuario> BuscarTodos() => _usuarios.ToList();
}