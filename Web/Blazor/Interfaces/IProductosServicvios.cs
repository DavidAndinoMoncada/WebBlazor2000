using Modelos;

namespace Blazor.Interfaces
{
    public interface IProductosServicvios
    {
        Task<Producto> GetPorCodigoAsync(string codigo);
        Task<bool> NuevoAsync(Producto producto);
        Task<bool> ActualizarAsync(Producto producto);
        Task<bool> EliminarAsync(string codigo);
        Task<IEnumerable<Producto>> GetListaAsync();

    }
}
