using Modelos;

namespace Blazor.Interfaces
{
    public interface IUsuariosServicios
    {
        Task<Usuario> GetPorCodigoAsync(string codigo);

        Task<bool> NuevoAsync(Usuario usuario);
        Task<bool> ActualizarAsync(Usuario usuario);
        Task<bool> EliminarAsync(Usuario usuario);

        Task<IEnumerable<Usuario>> GetListaAsync();

    }
}
