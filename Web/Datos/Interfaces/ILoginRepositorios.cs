using Modelos;

namespace Datos.Interfaces
{
    public interface ILoginRepositorios
    {
        Task<bool> ValidarUsuarioAsync(Login login);
    }
}
