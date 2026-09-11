using System.Drawing;
using System.Windows.Forms;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    partial class FormLogin
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

        private Panel _panelMarca;
        private PictureBox _picIconoBus;
        private Label _lblMarca;
        private Label _lblSlogan;
        private Panel _panelFormulario;
        private Label _lblTitulo;
        private Label _lblUsuario;
        private TextBox _txtUsuario;
        private Label _lblContrasena;
        private TextBox _txtContrasena;
        private Label _lblMensaje;
        private BotonPlano _botonIngresar;

        /// <summary>
        /// Método necesario para admitir el Diseñador. No modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this._panelMarca = new System.Windows.Forms.Panel();
            this._picIconoBus = new System.Windows.Forms.PictureBox();
            this._lblMarca = new System.Windows.Forms.Label();
            this._lblSlogan = new System.Windows.Forms.Label();
            this._panelFormulario = new System.Windows.Forms.Panel();
            this._lblTitulo = new System.Windows.Forms.Label();
            this._lblUsuario = new System.Windows.Forms.Label();
            this._txtUsuario = new System.Windows.Forms.TextBox();
            this._lblContrasena = new System.Windows.Forms.Label();
            this._txtContrasena = new System.Windows.Forms.TextBox();
            this._lblMensaje = new System.Windows.Forms.Label();
            this._botonIngresar = new SistemaControlAutobuses.Presentacion.Utilidades.BotonPlano();
            this._panelMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picIconoBus)).BeginInit();
            this._panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelMarca
            // 
            this._panelMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this._panelMarca.Controls.Add(this._picIconoBus);
            this._panelMarca.Controls.Add(this._lblMarca);
            this._panelMarca.Controls.Add(this._lblSlogan);
            this._panelMarca.Dock = System.Windows.Forms.DockStyle.Left;
            this._panelMarca.Location = new System.Drawing.Point(0, 0);
            this._panelMarca.Name = "_panelMarca";
            this._panelMarca.Size = new System.Drawing.Size(326, 451);
            this._panelMarca.TabIndex = 0;
            // 
            // _picIconoBus
            // 
            this._picIconoBus.BackColor = System.Drawing.Color.Transparent;
            this._picIconoBus.Image = ((System.Drawing.Image)(resources.GetObject("_picIconoBus.Image")));
            this._picIconoBus.Location = new System.Drawing.Point(51, 113);
            this._picIconoBus.Name = "_picIconoBus";
            this._picIconoBus.Size = new System.Drawing.Size(96, 96);
            this._picIconoBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._picIconoBus.TabIndex = 0;
            this._picIconoBus.TabStop = false;
            // 
            // _lblMarca
            // 
            this._lblMarca.AutoSize = true;
            this._lblMarca.Font = new System.Drawing.Font("Segoe UI Light", 26F);
            this._lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this._lblMarca.Location = new System.Drawing.Point(51, 212);
            this._lblMarca.Name = "_lblMarca";
            this._lblMarca.Size = new System.Drawing.Size(177, 94);
            this._lblMarca.TabIndex = 1;
            this._lblMarca.Text = "Control de\r\nAutobuses";
            // 
            // _lblSlogan
            // 
            this._lblSlogan.AutoSize = true;
            this._lblSlogan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this._lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(222)))));
            this._lblSlogan.Location = new System.Drawing.Point(55, 324);
            this._lblSlogan.MaximumSize = new System.Drawing.Size(240, 0);
            this._lblSlogan.Name = "_lblSlogan";
            this._lblSlogan.Size = new System.Drawing.Size(221, 40);
            this._lblSlogan.TabIndex = 2;
            this._lblSlogan.Text = "Gestion de choferes, autobuses, rutas y asignaciones.";
            // 
            // _panelFormulario
            // 
            this._panelFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._panelFormulario.Controls.Add(this._lblTitulo);
            this._panelFormulario.Controls.Add(this._lblUsuario);
            this._panelFormulario.Controls.Add(this._txtUsuario);
            this._panelFormulario.Controls.Add(this._lblContrasena);
            this._panelFormulario.Controls.Add(this._txtContrasena);
            this._panelFormulario.Controls.Add(this._lblMensaje);
            this._panelFormulario.Controls.Add(this._botonIngresar);
            this._panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelFormulario.Location = new System.Drawing.Point(326, 0);
            this._panelFormulario.Name = "_panelFormulario";
            this._panelFormulario.Padding = new System.Windows.Forms.Padding(60, 78, 60, 35);
            this._panelFormulario.Size = new System.Drawing.Size(429, 451);
            this._panelFormulario.TabIndex = 1;
            // 
            // _lblTitulo
            // 
            this._lblTitulo.AutoSize = true;
            this._lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this._lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this._lblTitulo.Location = new System.Drawing.Point(60, 52);
            this._lblTitulo.Name = "_lblTitulo";
            this._lblTitulo.Size = new System.Drawing.Size(154, 32);
            this._lblTitulo.TabIndex = 0;
            this._lblTitulo.Text = "Iniciar sesion";
            // 
            // _lblUsuario
            // 
            this._lblUsuario.AutoSize = true;
            this._lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this._lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this._lblUsuario.Location = new System.Drawing.Point(60, 113);
            this._lblUsuario.Name = "_lblUsuario";
            this._lblUsuario.Size = new System.Drawing.Size(54, 17);
            this._lblUsuario.TabIndex = 1;
            this._lblUsuario.Text = "Usuario";
            // 
            // _txtUsuario
            // 
            this._txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this._txtUsuario.Location = new System.Drawing.Point(60, 137);
            this._txtUsuario.Name = "_txtUsuario";
            this._txtUsuario.Size = new System.Drawing.Size(343, 24);
            this._txtUsuario.TabIndex = 2;
            // 
            // _lblContrasena
            // 
            this._lblContrasena.AutoSize = true;
            this._lblContrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this._lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this._lblContrasena.Location = new System.Drawing.Point(60, 182);
            this._lblContrasena.Name = "_lblContrasena";
            this._lblContrasena.Size = new System.Drawing.Size(77, 17);
            this._lblContrasena.TabIndex = 3;
            this._lblContrasena.Text = "Contrasena";
            // 
            // _txtContrasena
            // 
            this._txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtContrasena.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this._txtContrasena.Location = new System.Drawing.Point(60, 206);
            this._txtContrasena.Name = "_txtContrasena";
            this._txtContrasena.PasswordChar = '●';
            this._txtContrasena.Size = new System.Drawing.Size(343, 24);
            this._txtContrasena.TabIndex = 4;
            // 
            // _lblMensaje
            // 
            this._lblMensaje.AutoSize = true;
            this._lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this._lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this._lblMensaje.Location = new System.Drawing.Point(60, 243);
            this._lblMensaje.MaximumSize = new System.Drawing.Size(343, 0);
            this._lblMensaje.Name = "_lblMensaje";
            this._lblMensaje.Size = new System.Drawing.Size(0, 17);
            this._lblMensaje.TabIndex = 5;
            // 
            // _botonIngresar
            // 
            this._botonIngresar.ColorFondoHover = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this._botonIngresar.ColorFondoNormal = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(164)))), ((int)(((byte)(56)))));
            this._botonIngresar.ColorTextoBoton = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this._botonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._botonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._botonIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this._botonIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this._botonIngresar.Location = new System.Drawing.Point(60, 277);
            this._botonIngresar.Name = "_botonIngresar";
            this._botonIngresar.Radio = 6;
            this._botonIngresar.Size = new System.Drawing.Size(343, 36);
            this._botonIngresar.TabIndex = 6;
            this._botonIngresar.Text = "INGRESAR";
            this._botonIngresar.UseVisualStyleBackColor = true;
            this._botonIngresar.Click += new System.EventHandler(this.BotonIngresar_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this._botonIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(755, 451);
            this.Controls.Add(this._panelFormulario);
            this.Controls.Add(this._panelMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Autobuses";
            this._panelMarca.ResumeLayout(false);
            this._panelMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picIconoBus)).EndInit();
            this._panelFormulario.ResumeLayout(false);
            this._panelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
