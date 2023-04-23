﻿using Blazor.Interfaces;
using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;

namespace Blazor.Servicios
{
    public class UsuarioServicio : IUsuariosServicios
    {
        private readonly Config _config;
        private IUsuarioRepositorios usuarioRepositorio;

        public UsuarioServicio(Config config)
        {
            _config = config;
            usuarioRepositorio = new UsuarioRepositorio(config.CadenaConexion);
        }

        public async Task<bool> ActualizarAsync(Usuario usuario)
        {
            return await usuarioRepositorio.ActualizarAsync(usuario);
        }

        public async Task<bool> EliminarAsync(string usuario)
        {
            return await usuarioRepositorio.EliminarAsync(usuario);
        }

        public async Task<IEnumerable<Usuario>> GetListaAsync()
        {
            return await usuarioRepositorio.GetListaAsync();
        }

        public async Task<Usuario> GetPorCodigoAsync(string codigo)
        {
            return await usuarioRepositorio.GetPorCodigoAsync(codigo);
        }

        public async Task<bool> NuevoAsync(Usuario usuario)
        {
            return await usuarioRepositorio.NuevoAsync(usuario);
        }
    }
}
