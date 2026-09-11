using System.Data;
using System.Data.SqlClient;
using SistemaControlAutobuses.Datos.Conexion;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Datos.Repositorios
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario ObtenerPorNombreUsuario(string nombreUsuario)
        {
            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Usuario_ObtenerPorNombre", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                conexion.Open();

                using (var lector = comando.ExecuteReader())
                {
                    if (!lector.Read())
                        return null;

                    return new Usuario
                    {
                        Id = (int)lector["Id"],
                        NombreUsuario = lector["NombreUsuario"].ToString(),
                        ContrasenaHash = lector["ContrasenaHash"].ToString(),
                        Rol = lector["Rol"].ToString() == "ADMINISTRADOR"
                            ? RolUsuario.Administrador
                            : RolUsuario.Usuario,
                        Activo = (bool)lector["Activo"]
                    };
                }
            }
        }
    }
}
