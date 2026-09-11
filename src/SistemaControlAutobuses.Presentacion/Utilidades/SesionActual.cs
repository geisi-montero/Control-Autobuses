using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Presentacion.Utilidades
{
 
    public static class SesionActual
    {
        public static Usuario UsuarioAutenticado { get; set; }

        public static bool EsAdministrador =>
            UsuarioAutenticado != null && UsuarioAutenticado.Rol == RolUsuario.Administrador;

        public static void CerrarSesion()
        {
            UsuarioAutenticado = null;
        }
    }
}
