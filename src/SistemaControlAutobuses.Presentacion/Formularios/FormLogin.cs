using System;
using System.Windows.Forms;
using SistemaControlAutobuses.Datos.Repositorios;
using SistemaControlAutobuses.Negocio;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    public partial class FormLogin : Form
    {
        private readonly ServicioAutenticacion _servicioAutenticacion;

        public FormLogin()
        {
            InitializeComponent();
            _servicioAutenticacion = new ServicioAutenticacion(new UsuarioRepository());
        }

        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            _lblMensaje.Text = "";
            try
            {
                var usuario = _servicioAutenticacion.IniciarSesion(_txtUsuario.Text, _txtContrasena.Text);
                SesionActual.UsuarioAutenticado = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ExcepcionNegocio ex)
            {
                _lblMensaje.Text = ex.Message;
            }
            catch (Exception)
            {
                _lblMensaje.Text = "No fue posible conectar con la base de datos. Verifique la configuracion.";
            }
        }
    }
}
