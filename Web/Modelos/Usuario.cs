using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Usuario
    {
        [Required(ErrorMessage = "El Codigo es Requerido")]
        public string CodigoUsuario { get; set; }
        [Required(ErrorMessage = "El Nombre es Requerido")]
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        [Required(ErrorMessage = "El Rol es Requerido")]
        public string Rol { get; set; }
        public byte[] Foto { get; set; }
        public DateTime FechaCreación { get; set; }
        public bool EstaActivo { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigoUsuario, string nombre, string contraseña, string correo, string rol, byte[] foto,
            DateTime fechaCreación, bool estaActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
            Correo = correo;
            Rol = rol;
            Foto = foto;
            FechaCreación = fechaCreación;
            EstaActivo = estaActivo;
        }
    }
}
