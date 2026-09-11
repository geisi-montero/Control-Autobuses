using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SistemaControlAutobuses.Datos.Conexion;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Datos.Repositorios
{
    public class ChoferRepository : IChoferRepository
    {
        public int Insertar(Chofer chofer)
        {
            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Chofer_Insertar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", chofer.Nombre);
                comando.Parameters.AddWithValue("@Apellido", chofer.Apellido);
                comando.Parameters.AddWithValue("@FechaNacimiento", chofer.FechaNacimiento);
                comando.Parameters.AddWithValue("@Cedula", chofer.Cedula);

                conexion.Open();
                object resultado = comando.ExecuteScalar();
                return Convert.ToInt32(resultado);
            }
        }

        public List<Chofer> Consultar()
        {
            return EjecutarConsulta("sp_Chofer_Consultar");
        }

        public List<Chofer> ObtenerDisponibles()
        {
            return EjecutarConsulta("sp_Chofer_ObtenerDisponibles");
        }

        private List<Chofer> EjecutarConsulta(string nombreProcedimiento)
        {
            var resultado = new List<Chofer>();

            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand(nombreProcedimiento, conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        resultado.Add(MapearChofer(lector));
                    }
                }
            }

            return resultado;
        }

        public void Actualizar(Chofer chofer)
        {
            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Chofer_Actualizar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", chofer.Id);
                comando.Parameters.AddWithValue("@Nombre", chofer.Nombre);
                comando.Parameters.AddWithValue("@Apellido", chofer.Apellido);
                comando.Parameters.AddWithValue("@FechaNacimiento", chofer.FechaNacimiento);
                comando.Parameters.AddWithValue("@Cedula", chofer.Cedula);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Chofer_Eliminar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", id);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        private static Chofer MapearChofer(SqlDataReader lector)
        {
            return new Chofer
            {
                Id = (int)lector["Id"],
                Nombre = lector["Nombre"].ToString(),
                Apellido = lector["Apellido"].ToString(),
                FechaNacimiento = (DateTime)lector["FechaNacimiento"],
                Cedula = lector["Cedula"].ToString(),
                Activo = (bool)lector["Activo"]
            };
        }
    }
}
