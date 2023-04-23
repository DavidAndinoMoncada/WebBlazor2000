using Modelos;

namespace Datos.Interfaces
{
    public interface IUsuarioRepositorios
    {
        Task<Usuario> GetPorCodigoAsync(string codigoUsuario);
        Task<bool> NuevoAsync(Usuario usuario);
        Task<bool> ActualizarAsync(Usuario usuario);
        Task<bool> EliminarAsync(string usuarioCodigo);
        Task<IEnumerable<Usuario>> GetListaAsync();

    }
}
