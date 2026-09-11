using System;
using System.Windows.Forms;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{

    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            ConfigurarSegunRol();
            AsignarGeneradoresDeIconos();
            MostrarDashboard();
        }

       
        private void ConfigurarSegunRol()
        {
            bool esAdmin = SesionActual.EsAdministrador;
            _menuChoferes.Visible = esAdmin;
            _menuAutobuses.Visible = esAdmin;
            _menuRutas.Visible = esAdmin;

            _lblUsuarioActivo.Text =
                $"{SesionActual.UsuarioAutenticado.NombreUsuario}\n{(esAdmin ? "Administrador" : "Usuario")}";
        }

     
        private void AsignarGeneradoresDeIconos()
        {
            _menuDashboard.GeneradorIcono = Iconos.Dashboard;
            _menuChoferes.GeneradorIcono = Iconos.Chofer;
            _menuAutobuses.GeneradorIcono = Iconos.Autobus;
            _menuRutas.GeneradorIcono = Iconos.Ruta;
            _menuAsignaciones.GeneradorIcono = Iconos.Asignacion;
            _menuSalir.GeneradorIcono = Iconos.Salir;
        }

        private void MenuDashboard_Click(object sender, EventArgs e) => MostrarDashboard();

        private void MenuChoferes_Click(object sender, EventArgs e) => MostrarModulo(_menuChoferes, new ControlChoferes());

        private void MenuAutobuses_Click(object sender, EventArgs e) => MostrarModulo(_menuAutobuses, new ControlAutobuses());

        private void MenuRutas_Click(object sender, EventArgs e) => MostrarModulo(_menuRutas, new ControlRutas());

        private void MenuAsignaciones_Click(object sender, EventArgs e) => MostrarModulo(_menuAsignaciones, new ControlAsignaciones());

        private void MenuSalir_Click(object sender, EventArgs e) => CerrarSesion();

        private void MostrarModulo(BotonMenuLateral botonActivo, UserControl control)
        {
            MarcarBotonActivo(botonActivo);
            _panelContenido.Controls.Clear();
            control.Dock = DockStyle.Fill;
            _panelContenido.Controls.Add(control);
        }

        private void MostrarDashboard()
        {
            MarcarBotonActivo(_menuDashboard);
            _panelContenido.Controls.Clear();
            var control = new ControlDashboard { Dock = DockStyle.Fill };
            _panelContenido.Controls.Add(control);
        }

        private void MarcarBotonActivo(BotonMenuLateral activo)
        {
            foreach (var boton in new[] { _menuDashboard, _menuChoferes, _menuAutobuses, _menuRutas, _menuAsignaciones })
            {
                if (boton != null) boton.Activo = (boton == activo);
            }
        }

        private void CerrarSesion()
        {
            var resultado = MessageBox.Show("Desea cerrar la sesion actual?", "Cerrar sesion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;

            SesionActual.CerrarSesion();
            Hide();

            using (var formLogin = new FormLogin())
            {
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    using (var nuevaVentana = new FormPrincipal())
                    {
                        nuevaVentana.ShowDialog();
                    }
                }
            }

            Close();
        }
    }
}
