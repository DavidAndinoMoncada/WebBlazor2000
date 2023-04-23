using Blazor.Interfaces;
using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;

namespace Blazor.Servicios
{
    public class LoginServicio : ILoginServicios
    {
        private readonly Config _config;
        private ILoginRepositorios loginRepositorio;

        public LoginServicio(Config config)
        {
            _config = config;
            loginRepositorio = new LoginRepositorio(config.CadenaConexion);
        }

        public async Task<bool> ValidarUsuarioAsync(Login login)
        {
            return await loginRepositorio.ValidarUsuarioAsync(login);
        }
    }
}
