using System.Data.SqlClient;

namespace SistemaControlAutobuses.Datos.Conexion
{
    public static class ConexionSQL
    {
        public static string CadenaConexion { get; set; }

        public static SqlConnection CrearConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
