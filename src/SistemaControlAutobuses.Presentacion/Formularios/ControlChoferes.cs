using System;
using System.Windows.Forms;
using SistemaControlAutobuses.Datos.Repositorios;
using SistemaControlAutobuses.Entidades;
using SistemaControlAutobuses.Negocio;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    public partial class ControlChoferes : UserControl
    {
        private readonly ServicioChofer _servicio = new ServicioChofer(new ChoferRepository());

        private int? _idSeleccionado;

        public ControlChoferes()
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
                foreach (var chofer in _servicio.Consultar(SesionActual.UsuarioAutenticado.Rol))
                {
                    int indice = _tabla.Rows.Add(chofer.Nombre, chofer.Apellido, chofer.Cedula, chofer.FechaNacimiento.ToShortDateString());
                    _tabla.Rows[indice].Tag = chofer;
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void Tabla_SelectionChanged(object sender, EventArgs e)
        {
            if (_tabla.CurrentRow?.Tag is Chofer chofer)
            {
                _idSeleccionado = chofer.Id;
                _txtNombre.Text = chofer.Nombre;
                _txtApellido.Text = chofer.Apellido;
                _txtCedula.Text = chofer.Cedula;
                _dtpFechaNacimiento.Value = chofer.FechaNacimiento;
                _lblEncabezadoFormulario.Text = "Editar chofer";
            }
        }

        private void BotonNuevo_Click(object sender, EventArgs e) => LimpiarFormulario();

        private void LimpiarFormulario()
        {
            _idSeleccionado = null;
            _txtNombre.Text = "";
            _txtApellido.Text = "";
            _txtCedula.Text = "";
            _dtpFechaNacimiento.Value = DateTime.Today.AddYears(-25);
            _lblEncabezadoFormulario.Text = "Nuevo chofer";
            _tabla.ClearSelection();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            var chofer = new Chofer
            {
                Id = _idSeleccionado ?? 0,
                Nombre = _txtNombre.Text.Trim(),
                Apellido = _txtApellido.Text.Trim(),
                Cedula = _txtCedula.Text.Trim(),
                FechaNacimiento = _dtpFechaNacimiento.Value.Date
            };

            try
            {
                var rol = SesionActual.UsuarioAutenticado.Rol;
                if (_idSeleccionado.HasValue)
                    _servicio.Actualizar(chofer, rol);
                else
                    _servicio.Registrar(chofer, rol);

                MessageBox.Show("Chofer guardado correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarDatos();
            }
            catch (ExcepcionNegocio ex)
            {
                MessageBox.Show(ex.Message, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (!_idSeleccionado.HasValue)
            {
                MessageBox.Show("Seleccione un chofer de la lista.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("Desea eliminar el chofer seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            try
            {
                _servicio.Eliminar(_idSeleccionado.Value, SesionActual.UsuarioAutenticado.Rol);
                MessageBox.Show("Chofer eliminado correctamente.", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarDatos();
            }
            catch (ExcepcionNegocio ex)
            {
                MessageBox.Show(ex.Message, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void MostrarError(Exception ex)
        {
            MessageBox.Show("Ocurrio un error al comunicarse con la base de datos: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
