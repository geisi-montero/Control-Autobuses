using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Datos.Repositorios
{
    public interface IUsuarioRepository
    {
        Usuario ObtenerPorNombreUsuario(string nombreUsuario);
    }
}
