namespace SistemaControlAutobuses.Entidades
{
    public enum RolUsuario
    {
        Administrador,
        Usuario
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string ContrasenaHash { get; set; }
        public RolUsuario Rol { get; set; }
        public bool Activo { get; set; }
    }
}
