using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SistemaControlAutobuses.Datos.Conexion;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Datos.Repositorios
{
    public class AsignacionRepository : IAsignacionRepository
    {
        public int Crear(int choferId, int autobusId, int rutaId)
        {
            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Asignacion_Crear", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ChoferId", choferId);
                comando.Parameters.AddWithValue("@AutobusId", autobusId);
                comando.Parameters.AddWithValue("@RutaId", rutaId);

                conexion.Open();
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public List<Asignacion> Consultar()
        {
            var resultado = new List<Asignacion>();

            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Asignacion_Consultar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        resultado.Add(new Asignacion
                        {
                            Id = (int)lector["Id"],
                            ChoferId = (int)lector["ChoferId"],
                            NombreChofer = lector["NombreChofer"].ToString(),
                            AutobusId = (int)lector["AutobusId"],
                            DescripcionAutobus = lector["DescripcionAutobus"].ToString(),
                            RutaId = (int)lector["RutaId"],
                            NombreRuta = lector["NombreRuta"].ToString(),
                            FechaAsignacion = (DateTime)lector["FechaAsignacion"],
                            FechaFinalizacion = lector["FechaFinalizacion"] == DBNull.Value
                                ? (DateTime?)null
                                : (DateTime)lector["FechaFinalizacion"],
                            Estado = lector["Estado"].ToString() == "ACTIVA"
                                ? EstadoAsignacion.Activa
                                : EstadoAsignacion.Finalizada
                        });
                    }
                }
            }

            return resultado;
        }

        public void Finalizar(int id)
        {
            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Asignacion_Finalizar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", id);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}
