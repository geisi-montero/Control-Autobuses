using System;
using System.Windows.Forms;
using SistemaControlAutobuses.Datos.Repositorios;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    public partial class ControlDashboard : UserControl
    {
        private readonly IChoferRepository _repositorioChofer = new ChoferRepository();
        private readonly IAutobusRepository _repositorioAutobus = new AutobusRepository();
        private readonly IRutaRepository _repositorioRuta = new RutaRepository();
        private readonly IAsignacionRepository _repositorioAsignacion = new AsignacionRepository();

        public ControlDashboard()
        {
            InitializeComponent();
            CargarIndicadores();
        }

        private void CargarIndicadores()
        {
            try
            {
                _tarjetaChoferes.Valor = _repositorioChofer.Consultar().Count.ToString();
                _tarjetaAutobuses.Valor = _repositorioAutobus.Consultar().Count.ToString();
                _tarjetaRutas.Valor = _repositorioRuta.Consultar().Count.ToString();

                int asignacionesActivas = 0;
                foreach (var asignacion in _repositorioAsignacion.Consultar())
                {
                    if (asignacion.Estado == EstadoAsignacion.Activa) asignacionesActivas++;
                }
                _tarjetaAsignaciones.Valor = asignacionesActivas.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible cargar los indicadores del dashboard. Verifique la conexion a la base de datos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
