using System;
using System.Windows.Forms;
using SistemaControlAutobuses.Datos.Repositorios;
using SistemaControlAutobuses.Entidades;
using SistemaControlAutobuses.Negocio;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    public partial class ControlAsignaciones : UserControl
    {
        private readonly ServicioAsignacion _servicio = new ServicioAsignacion(
            new AsignacionRepository(), new ChoferRepository(), new AutobusRepository(), new RutaRepository());

        private int? _idAsignacionSeleccionada;
        private string _estadoSeleccionado;

        public ControlAsignaciones()
        {
            InitializeComponent();
            EstiloTabla.Aplicar(_tabla);
            CargarCombos();
            CargarDatos();
        }

        private void PanelFormulario_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, _panelFormulario.ClientRectangle, Estilos.Borde, ButtonBorderStyle.Solid);
        }

        private void CargarCombos()
        {
            try
            {
                _comboChofer.DisplayMember = "NombreCompleto";
                _comboChofer.ValueMember = "Id";
                _comboChofer.DataSource = _servicio.ObtenerChoferesDisponibles();

                _comboAutobus.DisplayMember = "Descripcion";
                _comboAutobus.ValueMember = "Id";
                _comboAutobus.DataSource = _servicio.ObtenerAutobusesDisponibles();

                _comboRuta.DisplayMember = "Nombre";
                _comboRuta.ValueMember = "Id";
                _comboRuta.DataSource = _servicio.ObtenerRutasDisponibles();
            }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void CargarDatos()
        {
            try
            {
                _tabla.Rows.Clear();
                foreach (var asignacion in _servicio.Consultar())
                {
                    string estadoTexto = asignacion.Estado == EstadoAsignacion.Activa ? "Activa" : "Finalizada";
                    int indice = _tabla.Rows.Add(
                        asignacion.NombreChofer, asignacion.DescripcionAutobus, asignacion.NombreRuta,
                        asignacion.FechaAsignacion.ToString("dd/MM/yyyy hh:mm tt"), estadoTexto);
                    _tabla.Rows[indice].Tag = asignacion;

                    if (asignacion.Estado == EstadoAsignacion.Finalizada)
                        _tabla.Rows[indice].DefaultCellStyle.ForeColor = Estilos.TextoSecundario;
                }
            }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void Tabla_SelectionChanged(object sender, EventArgs e)
        {
            if (_tabla.CurrentRow?.Tag is Asignacion asignacion)
            {
                _idAsignacionSeleccionada = asignacion.Id;
                _estadoSeleccionado = asignacion.Estado == EstadoAsignacion.Activa ? "Activa" : "Finalizada";
            }
        }

        private void BotonAsignar_Click(object sender, EventArgs e)
        {
            if (_comboChofer.SelectedValue == null || _comboAutobus.SelectedValue == null || _comboRuta.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un chofer, un autobus y una ruta.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _servicio.Crear((int)_comboChofer.SelectedValue, (int)_comboAutobus.SelectedValue, (int)_comboRuta.SelectedValue);
                MessageBox.Show("Asignacion realizada correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCombos();
                CargarDatos();
            }
            catch (ExcepcionNegocio ex)
            {
                MessageBox.Show(ex.Message, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void BotonFinalizar_Click(object sender, EventArgs e)
        {
            if (!_idAsignacionSeleccionada.HasValue)
            {
                MessageBox.Show("Seleccione una asignacion de la lista.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_estadoSeleccionado == "Finalizada")
            {
                MessageBox.Show("La asignacion seleccionada ya se encuentra finalizada.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("Desea finalizar la asignacion seleccionada? El chofer, el autobus y la ruta volveran a estar disponibles.",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            try
            {
                _servicio.Finalizar(_idAsignacionSeleccionada.Value);
                MessageBox.Show("Asignacion finalizada correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCombos();
                CargarDatos();
            }
            catch (ExcepcionNegocio ex)
            {
                MessageBox.Show(ex.Message, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void MostrarError(Exception ex)
        {
            MessageBox.Show("Ocurrio un error al comunicarse con la base de datos: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
