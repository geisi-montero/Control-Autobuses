using System;
using System.Configuration;
using System.Windows.Forms;
using SistemaControlAutobuses.Datos.Conexion;
using SistemaControlAutobuses.Presentacion.Formularios;

namespace SistemaControlAutobuses.Presentacion
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string cadenaConexion = ConfigurationManager.ConnectionStrings["SistemaControlAutobuses"]?.ConnectionString;

            if (string.IsNullOrWhiteSpace(cadenaConexion))
            {
                MessageBox.Show(
                    "No se encontro la cadena de conexion 'SistemaControlAutobuses' en App.config.",
                    "Error de configuracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConexionSQL.CadenaConexion = cadenaConexion;

            using (var formLogin = new FormLogin())
            {
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FormPrincipal());
                }
            }
        }
    }
}
