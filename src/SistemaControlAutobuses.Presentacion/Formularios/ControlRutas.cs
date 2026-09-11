using System;
using System.Windows.Forms;
using SistemaControlAutobuses.Datos.Repositorios;
using SistemaControlAutobuses.Entidades;
using SistemaControlAutobuses.Negocio;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    public partial class ControlRutas : UserControl
    {
        private readonly ServicioRuta _servicio = new ServicioRuta(new RutaRepository());

        private int? _idSeleccionado;

        public ControlRutas()
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
                foreach (var ruta in _servicio.Consultar(SesionActual.UsuarioAutenticado.Rol))
                {
                    int indice = _tabla.Rows.Add(ruta.Nombre);
                    _tabla.Rows[indice].Tag = ruta;
                }
            }
            catch (Exception ex) { MostrarError(ex); }
        }

        private void Tabla_SelectionChanged(object sender, EventArgs e)
        {
            if (_tabla.CurrentRow?.Tag is Ruta ruta)
            {
                _idSeleccionado = ruta.Id;
                _txtNombre.Text = ruta.Nombre;
                _lblEncabezadoFormulario.Text = "Editar ruta";
            }
        }

        private void BotonNuevo_Click(object sender, EventArgs e) => LimpiarFormulario();

        private void LimpiarFormulario()
        {
            _idSeleccionado = null;
            _txtNombre.Text = "";
            _lblEncabezadoFormulario.Text = "Nueva ruta";
            _tabla.ClearSelection();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            var ruta = new Ruta { Id = _idSeleccionado ?? 0, Nombre = _txtNombre.Text.Trim() };

            try
            {
                var rol = SesionActual.UsuarioAutenticado.Rol;
                if (_idSeleccionado.HasValue)
                    _servicio.Actualizar(ruta, rol);
                else
                    _servicio.Registrar(ruta, rol);

                MessageBox.Show("Ruta guardada correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Seleccione una ruta de la lista.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("Desea eliminar la ruta seleccionada?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            try
            {
                _servicio.Eliminar(_idSeleccionado.Value, SesionActual.UsuarioAutenticado.Rol);
                MessageBox.Show("Ruta eliminada correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
