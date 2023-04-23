using Modelos;

namespace Blazor.Interfaces
{
    public interface ILoginServicios
    {
        Task<bool> ValidarUsuarioAsync(Login login);
    }
}
