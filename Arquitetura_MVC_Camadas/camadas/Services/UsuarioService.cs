using camadas.Models;
using camadas.Repositories;

namespace camadas.Services;

public class UsuarioService
{
    private readonly UsuarioRepository _repository;
    private const int IdadeMinima = 18;
    
    public UsuarioService(UsuarioRepository repository)
    {
        _repository = repository;
    }

    public (bool Sucesso, String mensagem) CadastrarUsuario(Usuario usuario)
    {
        if(string.IsNullOrWhiteSpace(usuario.Nome) || string.IsNullOrWhiteSpace(usuario.Email) || string.IsNullOrWhiteSpace(usuario.Senha))
        {
            return (false, "Todos os campos são obrigatórios.");
        }
        
        if(_repository.BuscarPorEmail(usuario.Email) != null)
        {
            return (false, "Email já cadastrado.");
        }
        
        if(usuario.Idade < IdadeMinima)
        {
            return (false, "Idade mínima não atingida.");
        }
        
        var novoUsuario = new Usuario(_repository._proximoId++, usuario.Nome, usuario.Email, usuario.Senha, usuario.Idade);
        _repository.Salvar(novoUsuario);
        return(true, "Usuário cadastrado com sucesso.");
    }
    
    public List<Usuario> ListarUsuarios()
    {
        return _repository.BuscarTodos();
    }
    
    public Usuario? BuscarPorEmail(string email)
    {
        return _repository.BuscarPorEmail(email);
    }
}