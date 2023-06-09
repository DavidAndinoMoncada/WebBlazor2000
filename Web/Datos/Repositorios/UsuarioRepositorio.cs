﻿using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorios
    {
        private string CadenaConexion;

        public UsuarioRepositorio(string cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }

        public async Task<bool> ActualizarAsync(Usuario usuario)
        {
            bool resultado = false;

            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = @"UPDATE usuario SET Nombre = @Nombre, Contraseña = @Contraseña, Correo = @Correo, Rol = @Rol, Foto = @Foto, EstaActivo = @EstaActivo
                             WHERE CodigoUsuario = @CodigoUsuario; ";
                resultado = Convert.ToBoolean(await _conexion.ExecuteScalarAsync(sql, usuario));
                resultado = true;
            }
            catch (Exception)
            {
            }

            return resultado;

        }

        public async Task<bool> EliminarAsync(string codigoUsuario)
        {
            bool resultado = false;

            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "DELETE FROM usuario WHERE CodigoUsuario = @CodigoUsuario; ";
                resultado = Convert.ToBoolean(await _conexion.ExecuteScalarAsync(sql, new { codigoUsuario }));
                resultado = true;
            }
            catch (Exception)
            {
            }

            return resultado;

        }

        public async Task<IEnumerable<Usuario>> GetListaAsync()
        {
            IEnumerable<Usuario> lista = new List<Usuario>();

            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "SELECT * FROM usuario; ";
                lista = await _conexion.QueryAsync<Usuario>(sql);

            }
            catch (Exception)
            {
            }

            return lista;

        }

        public async Task<Usuario> GetPorCodigoAsync(string codigoUsuario)
        {
            Usuario user = new Usuario();

            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = "SELECT * FROM usuario WHERE CodigoUsuario = @CodigoUsuario; ";
                user = await _conexion.QueryFirstAsync<Usuario>(sql, new { codigoUsuario });

            }
            catch (Exception)
            {
            }

            return user;

        }

        public async Task<bool> NuevoAsync(Usuario usuario)
        {
            bool resultado = false;

            try
            {
                using MySqlConnection _conexion = Conexion();
                await _conexion.OpenAsync();
                string sql = @"INSERT INTO usuario (CodigoUsuario, Nombre, Contraseña, Correo, Rol, Foto, FechaCreacion, EstaActivo)
                             Values (@CodigoUsuario, @Nombre, @Contraseña, @Correo, @Rol, @Foto, @FechaCreacion, @EstaActivo); ";
                resultado = Convert.ToBoolean(await _conexion.ExecuteScalarAsync(sql, usuario));
                resultado = true;
            }
            catch (Exception)
            {
            }

            return resultado;

        }
    }
}
