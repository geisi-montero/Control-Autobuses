using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SistemaControlAutobuses.Datos.Conexion;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Datos.Repositorios
{
    public class RutaRepository : IRutaRepository
    {
        public int Insertar(Ruta ruta)
        {
            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Ruta_Insertar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", ruta.Nombre);

                conexion.Open();
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public List<Ruta> Consultar()
        {
            return EjecutarConsulta("sp_Ruta_Consultar");
        }

        public List<Ruta> ObtenerDisponibles()
        {
            return EjecutarConsulta("sp_Ruta_ObtenerDisponibles");
        }

        private List<Ruta> EjecutarConsulta(string nombreProcedimiento)
        {
            var resultado = new List<Ruta>();

            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand(nombreProcedimiento, conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        resultado.Add(new Ruta
                        {
                            Id = (int)lector["Id"],
                            Nombre = lector["Nombre"].ToString(),
                            Activo = (bool)lector["Activo"]
                        });
                    }
                }
            }

            return resultado;
        }

        public void Actualizar(Ruta ruta)
        {
            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Ruta_Actualizar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", ruta.Id);
                comando.Parameters.AddWithValue("@Nombre", ruta.Nombre);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Ruta_Eliminar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", id);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}
