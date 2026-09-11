using SistemaControlAutobuses.Datos.Repositorios;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Negocio
{
  
    public class ServicioAutenticacion
    {
        private readonly IUsuarioRepository _repositorio;

        public ServicioAutenticacion(IUsuarioRepository repositorio)
        {
            _repositorio = repositorio;
        }

        
        public Usuario IniciarSesion(string nombreUsuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
                throw new ExcepcionNegocio("Debe ingresar el usuario y la contrasena.");

            Usuario usuario = _repositorio.ObtenerPorNombreUsuario(nombreUsuario.Trim());

            if (usuario == null || !usuario.Activo)
                throw new ExcepcionNegocio("Usuario o contrasena incorrectos.");

            if (!UtilidadContrasena.Verificar(contrasena, usuario.ContrasenaHash))
                throw new ExcepcionNegocio("Usuario o contrasena incorrectos.");

            return usuario;
        }
    }
}
