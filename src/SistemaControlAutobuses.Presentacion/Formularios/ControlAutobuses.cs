using System;
using System.Windows.Forms;
using SistemaControlAutobuses.Datos.Repositorios;
using SistemaControlAutobuses.Entidades;
using SistemaControlAutobuses.Negocio;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    public partial class ControlAutobuses : UserControl
    {
        private readonly ServicioAutobus _servicio = new ServicioAutobus(new AutobusRepository());

        private int? _idSeleccionado;

        public ControlAutobuses()
        {
            InitializeComponent();
            EstiloTabla.Aplicar(_tabla);
            CargarDatos();
        }

        private void PanelFormulario_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, _panelFormulario.ClientRectangle, Estilos.Borde, ButtonBorderStyle.Solid);
        }

        private void CargarDatos()
        {
            try
            {
                _tabla.Rows.Clear();
                foreach (var autobus in _servicio.Consultar(SesionActual.UsuarioAutenticado.Rol))
                {
                    int indice = _tabla.Rows.Add(autobus.Marca, autobus.Modelo, autobus.Placa, autobus.Color, autobus.Anio);
                    _tabla.Rows[indice].Tag = autobus;
                }
            }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void Tabla_SelectionChanged(object sender, EventArgs e)
        {
            if (_tabla.CurrentRow?.Tag is Autobus autobus)
            {
                _idSeleccionado = autobus.Id;
                _txtMarca.Text = autobus.Marca;
                _txtModelo.Text = autobus.Modelo;
                _txtPlaca.Text = autobus.Placa;
                _txtColor.Text = autobus.Color;
                _numAnio.Value = autobus.Anio;
                _lblEncabezadoFormulario.Text = "Editar autobus";
            }
        }

        private void BotonNuevo_Click(object sender, EventArgs e) => LimpiarFormulario();

        private void LimpiarFormulario()
        {
            _idSeleccionado = null;
            _txtMarca.Text = "";
            _txtModelo.Text = "";
            _txtPlaca.Text = "";
            _txtColor.Text = "";
            _numAnio.Value = DateTime.Today.Year;
            _lblEncabezadoFormulario.Text = "Nuevo autobus";
            _tabla.ClearSelection();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            var autobus = new Autobus
            {
                Id = _idSeleccionado ?? 0,
                Marca = _txtMarca.Text.Trim(),
                Modelo = _txtModelo.Text.Trim(),
                Placa = _txtPlaca.Text.Trim().ToUpperInvariant(),
                Color = _txtColor.Text.Trim(),
                Anio = (int)_numAnio.Value
            };

            try
            {
                var rol = SesionActual.UsuarioAutenticado.Rol;
                if (_idSeleccionado.HasValue)
                    _servicio.Actualizar(autobus, rol);
                else
                    _servicio.Registrar(autobus, rol);

                MessageBox.Show("Autobus guardado correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarDatos();
            }
            catch (ExcepcionNegocio ex)
            {
                MessageBox.Show(ex.Message, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (!_idSeleccionado.HasValue)
            {
                MessageBox.Show("Seleccione un autobus de la lista.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("Desea eliminar el autobus seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            try
            {
                _servicio.Eliminar(_idSeleccionado.Value, SesionActual.UsuarioAutenticado.Rol);
                MessageBox.Show("Autobus eliminado correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
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
