using Modelos;

namespace Datos.Interfaces
{
    public interface IUsuarioRepositorios
    {
        Task<Usuario> GetPorCodigoAsync(string codigoUsuario);
        Task<bool> NuevoAsync(Usuario usuario);
        Task<bool> ActualizarAsync(Usuario usuario);
        Task<bool> EliminarAsync(Usuario usuario);
        Task<IEnumerable<Usuario>> GetListaAsync();

    }
}
