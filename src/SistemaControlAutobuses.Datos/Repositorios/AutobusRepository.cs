using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SistemaControlAutobuses.Datos.Conexion;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Datos.Repositorios
{

    public class AutobusRepository : IAutobusRepository
    {
        public int Insertar(Autobus autobus)
        {
            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Autobus_Insertar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Marca", autobus.Marca);
                comando.Parameters.AddWithValue("@Modelo", autobus.Modelo);
                comando.Parameters.AddWithValue("@Placa", autobus.Placa);
                comando.Parameters.AddWithValue("@Color", autobus.Color);
                comando.Parameters.AddWithValue("@Anio", autobus.Anio);

                conexion.Open();
                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public List<Autobus> Consultar()
        {
            return EjecutarConsulta("sp_Autobus_Consultar");
        }

        public List<Autobus> ObtenerDisponibles()
        {
            return EjecutarConsulta("sp_Autobus_ObtenerDisponibles");
        }

        private List<Autobus> EjecutarConsulta(string nombreProcedimiento)
        {
            var resultado = new List<Autobus>();

            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand(nombreProcedimiento, conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        resultado.Add(MapearAutobus(lector));
                    }
                }
            }

            return resultado;
        }

        public void Actualizar(Autobus autobus)
        {
            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Autobus_Actualizar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", autobus.Id);
                comando.Parameters.AddWithValue("@Marca", autobus.Marca);
                comando.Parameters.AddWithValue("@Modelo", autobus.Modelo);
                comando.Parameters.AddWithValue("@Placa", autobus.Placa);
                comando.Parameters.AddWithValue("@Color", autobus.Color);
                comando.Parameters.AddWithValue("@Anio", autobus.Anio);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var conexion = ConexionSQL.CrearConexion())
            using (var comando = new SqlCommand("sp_Autobus_Eliminar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", id);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        private static Autobus MapearAutobus(SqlDataReader lector)
        {
            return new Autobus
            {
                Id = (int)lector["Id"],
                Marca = lector["Marca"].ToString(),
                Modelo = lector["Modelo"].ToString(),
                Placa = lector["Placa"].ToString(),
                Color = lector["Color"].ToString(),
                Anio = (int)lector["Anio"],
                Activo = (bool)lector["Activo"]
            };
        }
    }
}
