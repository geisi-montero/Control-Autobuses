using System.Drawing;
using System.Windows.Forms;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    partial class FormPrincipal
    {
        /// <summary>Variable de diseño necesaria.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Limpiar los recursos que se estén utilizando.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de formularios de Windows

        private Panel _panelLateral;
        private Panel _panelContenido;
        private Panel _panelEncabezado;
        private PictureBox _picIconoBus;
        private Label _lblTituloApp;
        private Label _lblSubtituloApp;
        private FlowLayoutPanel _panelMenu;
        private BotonMenuLateral _menuDashboard;
        private BotonMenuLateral _menuChoferes;
        private BotonMenuLateral _menuAutobuses;
        private BotonMenuLateral _menuRutas;
        private BotonMenuLateral _menuAsignaciones;
        private Panel _panelInferior;
        private Label _lblUsuarioActivo;
        private BotonMenuLateral _menuSalir;

        /// <summary>
        /// Método necesario para admitir el Diseñador. No modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this._panelLateral = new System.Windows.Forms.Panel();
            this._panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this._menuDashboard = new SistemaControlAutobuses.Presentacion.Utilidades.BotonMenuLateral();
            this._menuChoferes = new SistemaControlAutobuses.Presentacion.Utilidades.BotonMenuLateral();
            this._menuAutobuses = new SistemaControlAutobuses.Presentacion.Utilidades.BotonMenuLateral();
            this._menuRutas = new SistemaControlAutobuses.Presentacion.Utilidades.BotonMenuLateral();
            this._menuAsignaciones = new SistemaControlAutobuses.Presentacion.Utilidades.BotonMenuLateral();
            this._panelInferior = new System.Windows.Forms.Panel();
            this._menuSalir = new SistemaControlAutobuses.Presentacion.Utilidades.BotonMenuLateral();
            this._lblUsuarioActivo = new System.Windows.Forms.Label();
            this._panelEncabezado = new System.Windows.Forms.Panel();
            this._picIconoBus = new System.Windows.Forms.PictureBox();
            this._lblTituloApp = new System.Windows.Forms.Label();
            this._lblSubtituloApp = new System.Windows.Forms.Label();
            this._panelContenido = new System.Windows.Forms.Panel();
            this._panelLateral.SuspendLayout();
            this._panelMenu.SuspendLayout();
            this._panelInferior.SuspendLayout();
            this._panelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picIconoBus)).BeginInit();
            this.SuspendLayout();
            // 
            // _panelLateral
            // 
            this._panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this._panelLateral.Controls.Add(this._panelMenu);
            this._panelLateral.Controls.Add(this._panelInferior);
            this._panelLateral.Controls.Add(this._panelEncabezado);
            this._panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this._panelLateral.Location = new System.Drawing.Point(0, 0);
            this._panelLateral.Name = "_panelLateral";
            this._panelLateral.Size = new System.Drawing.Size(197, 563);
            this._panelLateral.TabIndex = 0;
            // 
            // _panelMenu
            // 
            this._panelMenu.AutoSize = true;
            this._panelMenu.Controls.Add(this._menuDashboard);
            this._panelMenu.Controls.Add(this._menuChoferes);
            this._panelMenu.Controls.Add(this._menuAutobuses);
            this._panelMenu.Controls.Add(this._menuRutas);
            this._panelMenu.Controls.Add(this._menuAsignaciones);
            this._panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._panelMenu.Location = new System.Drawing.Point(0, 87);
            this._panelMenu.Name = "_panelMenu";
            this._panelMenu.Size = new System.Drawing.Size(197, 200);
            this._panelMenu.TabIndex = 0;
            this._panelMenu.WrapContents = false;
            // 
            // _menuDashboard
            // 
            this._menuDashboard.Activo = false;
            this._menuDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this._menuDashboard.FlatAppearance.BorderSize = 0;
            this._menuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._menuDashboard.GeneradorIcono = null;
            this._menuDashboard.Location = new System.Drawing.Point(0, 0);
            this._menuDashboard.Margin = new System.Windows.Forms.Padding(0);
            this._menuDashboard.Name = "_menuDashboard";
            this._menuDashboard.Size = new System.Drawing.Size(197, 40);
            this._menuDashboard.TabIndex = 0;
            this._menuDashboard.Text = "Dashboard";
            this._menuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuDashboard.UseVisualStyleBackColor = true;
            this._menuDashboard.Click += new System.EventHandler(this.MenuDashboard_Click);
            // 
            // _menuChoferes
            // 
            this._menuChoferes.Activo = false;
            this._menuChoferes.Cursor = System.Windows.Forms.Cursors.Hand;
            this._menuChoferes.FlatAppearance.BorderSize = 0;
            this._menuChoferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuChoferes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._menuChoferes.GeneradorIcono = null;
            this._menuChoferes.Location = new System.Drawing.Point(0, 40);
            this._menuChoferes.Margin = new System.Windows.Forms.Padding(0);
            this._menuChoferes.Name = "_menuChoferes";
            this._menuChoferes.Size = new System.Drawing.Size(197, 40);
            this._menuChoferes.TabIndex = 1;
            this._menuChoferes.Text = "Choferes";
            this._menuChoferes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuChoferes.UseVisualStyleBackColor = true;
            this._menuChoferes.Click += new System.EventHandler(this.MenuChoferes_Click);
            // 
            // _menuAutobuses
            // 
            this._menuAutobuses.Activo = false;
            this._menuAutobuses.Cursor = System.Windows.Forms.Cursors.Hand;
            this._menuAutobuses.FlatAppearance.BorderSize = 0;
            this._menuAutobuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuAutobuses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._menuAutobuses.GeneradorIcono = null;
            this._menuAutobuses.Location = new System.Drawing.Point(0, 80);
            this._menuAutobuses.Margin = new System.Windows.Forms.Padding(0);
            this._menuAutobuses.Name = "_menuAutobuses";
            this._menuAutobuses.Size = new System.Drawing.Size(197, 40);
            this._menuAutobuses.TabIndex = 2;
            this._menuAutobuses.Text = "Autobuses";
            this._menuAutobuses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuAutobuses.UseVisualStyleBackColor = true;
            this._menuAutobuses.Click += new System.EventHandler(this.MenuAutobuses_Click);
            // 
            // _menuRutas
            // 
            this._menuRutas.Activo = false;
            this._menuRutas.Cursor = System.Windows.Forms.Cursors.Hand;
            this._menuRutas.FlatAppearance.BorderSize = 0;
            this._menuRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuRutas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._menuRutas.GeneradorIcono = null;
            this._menuRutas.Location = new System.Drawing.Point(0, 120);
            this._menuRutas.Margin = new System.Windows.Forms.Padding(0);
            this._menuRutas.Name = "_menuRutas";
            this._menuRutas.Size = new System.Drawing.Size(197, 40);
            this._menuRutas.TabIndex = 3;
            this._menuRutas.Text = "Rutas";
            this._menuRutas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuRutas.UseVisualStyleBackColor = true;
            this._menuRutas.Click += new System.EventHandler(this.MenuRutas_Click);
            // 
            // _menuAsignaciones
            // 
            this._menuAsignaciones.Activo = false;
            this._menuAsignaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this._menuAsignaciones.FlatAppearance.BorderSize = 0;
            this._menuAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuAsignaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._menuAsignaciones.GeneradorIcono = null;
            this._menuAsignaciones.Location = new System.Drawing.Point(0, 160);
            this._menuAsignaciones.Margin = new System.Windows.Forms.Padding(0);
            this._menuAsignaciones.Name = "_menuAsignaciones";
            this._menuAsignaciones.Size = new System.Drawing.Size(197, 40);
            this._menuAsignaciones.TabIndex = 4;
            this._menuAsignaciones.Text = "Asignaciones";
            this._menuAsignaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuAsignaciones.UseVisualStyleBackColor = true;
            this._menuAsignaciones.Click += new System.EventHandler(this.MenuAsignaciones_Click);
            // 
            // _panelInferior
            // 
            this._panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this._panelInferior.Controls.Add(this._menuSalir);
            this._panelInferior.Controls.Add(this._lblUsuarioActivo);
            this._panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelInferior.Location = new System.Drawing.Point(0, 480);
            this._panelInferior.Name = "_panelInferior";
            this._panelInferior.Size = new System.Drawing.Size(197, 83);
            this._panelInferior.TabIndex = 1;
            // 
            // _menuSalir
            // 
            this._menuSalir.Activo = false;
            this._menuSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this._menuSalir.FlatAppearance.BorderSize = 0;
            this._menuSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._menuSalir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._menuSalir.GeneradorIcono = null;
            this._menuSalir.Location = new System.Drawing.Point(0, 38);
            this._menuSalir.Name = "_menuSalir";
            this._menuSalir.Size = new System.Drawing.Size(197, 40);
            this._menuSalir.TabIndex = 1;
            this._menuSalir.Text = "Cerrar sesion";
            this._menuSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._menuSalir.UseVisualStyleBackColor = true;
            this._menuSalir.Click += new System.EventHandler(this.MenuSalir_Click);
            // 
            // _lblUsuarioActivo
            // 
            this._lblUsuarioActivo.AutoSize = true;
            this._lblUsuarioActivo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this._lblUsuarioActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(222)))));
            this._lblUsuarioActivo.Location = new System.Drawing.Point(17, 5);
            this._lblUsuarioActivo.Name = "_lblUsuarioActivo";
            this._lblUsuarioActivo.Size = new System.Drawing.Size(0, 17);
            this._lblUsuarioActivo.TabIndex = 0;
            // 
            // _panelEncabezado
            // 
            this._panelEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this._panelEncabezado.Controls.Add(this._picIconoBus);
            this._panelEncabezado.Controls.Add(this._lblTituloApp);
            this._panelEncabezado.Controls.Add(this._lblSubtituloApp);
            this._panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this._panelEncabezado.Name = "_panelEncabezado";
            this._panelEncabezado.Size = new System.Drawing.Size(197, 87);
            this._panelEncabezado.TabIndex = 2;
            // 
            // _picIconoBus
            // 
            this._picIconoBus.Image = ((System.Drawing.Image)(resources.GetObject("_picIconoBus.Image")));
            this._picIconoBus.Location = new System.Drawing.Point(17, 19);
            this._picIconoBus.Name = "_picIconoBus";
            this._picIconoBus.Size = new System.Drawing.Size(34, 34);
            this._picIconoBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._picIconoBus.TabIndex = 0;
            this._picIconoBus.TabStop = false;
            // 
            // _lblTituloApp
            // 
            this._lblTituloApp.AutoSize = true;
            this._lblTituloApp.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this._lblTituloApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this._lblTituloApp.Location = new System.Drawing.Point(53, 26);
            this._lblTituloApp.Name = "_lblTituloApp";
            this._lblTituloApp.Size = new System.Drawing.Size(113, 25);
            this._lblTituloApp.TabIndex = 1;
            this._lblTituloApp.Text = "AUTOBUSES";
            // 
            // _lblSubtituloApp
            // 
            this._lblSubtituloApp.AutoSize = true;
            this._lblSubtituloApp.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this._lblSubtituloApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(150)))), ((int)(((byte)(172)))));
            this._lblSubtituloApp.Location = new System.Drawing.Point(56, 51);
            this._lblSubtituloApp.Name = "_lblSubtituloApp";
            this._lblSubtituloApp.Size = new System.Drawing.Size(106, 12);
            this._lblSubtituloApp.TabIndex = 2;
            this._lblSubtituloApp.Text = "SISTEMA DE CONTROL";
            // 
            // _panelContenido
            // 
            this._panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this._panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelContenido.Location = new System.Drawing.Point(197, 0);
            this._panelContenido.Name = "_panelContenido";
            this._panelContenido.Padding = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this._panelContenido.Size = new System.Drawing.Size(746, 563);
            this._panelContenido.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(943, 563);
            this.Controls.Add(this._panelContenido);
            this.Controls.Add(this._panelLateral);
            this.MinimumSize = new System.Drawing.Size(945, 569);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Autobuses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._panelLateral.ResumeLayout(false);
            this._panelLateral.PerformLayout();
            this._panelMenu.ResumeLayout(false);
            this._panelInferior.ResumeLayout(false);
            this._panelInferior.PerformLayout();
            this._panelEncabezado.ResumeLayout(false);
            this._panelEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picIconoBus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
