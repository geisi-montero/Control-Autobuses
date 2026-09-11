using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    partial class ControlChoferes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private Label _lblTitulo;
        private Panel _panelFormulario;
        private Label _lblEncabezadoFormulario;
        private Label _lblNombre;
        private TextBox _txtNombre;
        private Label _lblApellido;
        private TextBox _txtApellido;
        private Label _lblCedula;
        private TextBox _txtCedula;
        private Label _lblFecha;
        private DateTimePicker _dtpFechaNacimiento;
        private BotonPlano _botonNuevo;
        private BotonPlano _botonGuardar;
        private BotonPlano _botonEliminar;
        private DataGridView _tabla;
        private DataGridViewTextBoxColumn _colNombre;
        private DataGridViewTextBoxColumn _colApellido;
        private DataGridViewTextBoxColumn _colCedula;
        private DataGridViewTextBoxColumn _colFechaNacimiento;

        private void InitializeComponent()
        {
            this._lblTitulo = new Label();
            this._panelFormulario = new Panel();
            this._botonEliminar = new BotonPlano();
            this._botonGuardar = new BotonPlano();
            this._botonNuevo = new BotonPlano();
            this._dtpFechaNacimiento = new DateTimePicker();
            this._lblFecha = new Label();
            this._lblEncabezadoFormulario = new Label();
            this._lblNombre = new Label();
            this._txtNombre = new TextBox();
            this._lblApellido = new Label();
            this._txtApellido = new TextBox();
            this._lblCedula = new Label();
            this._txtCedula = new TextBox();
            this._tabla = new DataGridView();
            this._colNombre = new DataGridViewTextBoxColumn();
            this._colApellido = new DataGridViewTextBoxColumn();
            this._colCedula = new DataGridViewTextBoxColumn();
            this._colFechaNacimiento = new DataGridViewTextBoxColumn();
            this._panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tabla)).BeginInit();
            this.SuspendLayout();
            //
            // _lblTitulo
            //
            this._lblTitulo.AutoSize = true;
            this._lblTitulo.Font = Estilos.FuenteTitulo;
            this._lblTitulo.ForeColor = Estilos.TextoPrincipal;
            this._lblTitulo.Location = new Point(0, 0);
            this._lblTitulo.Name = "_lblTitulo";
            this._lblTitulo.Size = new Size(90, 32);
            this._lblTitulo.TabIndex = 0;
            this._lblTitulo.Text = "Choferes";
            //
            // _panelFormulario
            //
            this._panelFormulario.BackColor = Estilos.FondoTarjeta;
            this._panelFormulario.Controls.Add(this._lblEncabezadoFormulario);
            this._panelFormulario.Controls.Add(this._lblNombre);
            this._panelFormulario.Controls.Add(this._txtNombre);
            this._panelFormulario.Controls.Add(this._lblApellido);
            this._panelFormulario.Controls.Add(this._txtApellido);
            this._panelFormulario.Controls.Add(this._lblCedula);
            this._panelFormulario.Controls.Add(this._txtCedula);
            this._panelFormulario.Controls.Add(this._lblFecha);
            this._panelFormulario.Controls.Add(this._dtpFechaNacimiento);
            this._panelFormulario.Controls.Add(this._botonNuevo);
            this._panelFormulario.Controls.Add(this._botonGuardar);
            this._panelFormulario.Controls.Add(this._botonEliminar);
            this._panelFormulario.Location = new Point(0, 50);
            this._panelFormulario.Name = "_panelFormulario";
            this._panelFormulario.Size = new Size(1000, 150);
            this._panelFormulario.TabIndex = 1;
            this._panelFormulario.Paint += new PaintEventHandler(this.PanelFormulario_Paint);
            //
            // _lblEncabezadoFormulario
            //
            this._lblEncabezadoFormulario.AutoSize = true;
            this._lblEncabezadoFormulario.Font = Estilos.FuenteTextoNegrita;
            this._lblEncabezadoFormulario.ForeColor = Estilos.TextoPrincipal;
            this._lblEncabezadoFormulario.Location = new Point(18, 14);
            this._lblEncabezadoFormulario.Name = "_lblEncabezadoFormulario";
            this._lblEncabezadoFormulario.Size = new Size(100, 20);
            this._lblEncabezadoFormulario.TabIndex = 0;
            this._lblEncabezadoFormulario.Text = "Nuevo chofer";
            //
            // _lblNombre
            //
            this._lblNombre.AutoSize = true;
            this._lblNombre.Font = Estilos.FuenteTexto;
            this._lblNombre.ForeColor = Estilos.TextoSecundario;
            this._lblNombre.Location = new Point(18, 45);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new Size(58, 19);
            this._lblNombre.TabIndex = 1;
            this._lblNombre.Text = "Nombre";
            //
            // _txtNombre
            //
            this._txtNombre.BorderStyle = BorderStyle.FixedSingle;
            this._txtNombre.Font = Estilos.FuenteTexto;
            this._txtNombre.Location = new Point(18, 68);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new Size(230, 26);
            this._txtNombre.TabIndex = 2;
            //
            // _lblApellido
            //
            this._lblApellido.AutoSize = true;
            this._lblApellido.Font = Estilos.FuenteTexto;
            this._lblApellido.ForeColor = Estilos.TextoSecundario;
            this._lblApellido.Location = new Point(268, 45);
            this._lblApellido.Name = "_lblApellido";
            this._lblApellido.Size = new Size(60, 19);
            this._lblApellido.TabIndex = 3;
            this._lblApellido.Text = "Apellido";
            //
            // _txtApellido
            //
            this._txtApellido.BorderStyle = BorderStyle.FixedSingle;
            this._txtApellido.Font = Estilos.FuenteTexto;
            this._txtApellido.Location = new Point(268, 68);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new Size(230, 26);
            this._txtApellido.TabIndex = 4;
            //
            // _lblCedula
            //
            this._lblCedula.AutoSize = true;
            this._lblCedula.Font = Estilos.FuenteTexto;
            this._lblCedula.ForeColor = Estilos.TextoSecundario;
            this._lblCedula.Location = new Point(518, 45);
            this._lblCedula.Name = "_lblCedula";
            this._lblCedula.Size = new Size(50, 19);
            this._lblCedula.TabIndex = 5;
            this._lblCedula.Text = "Cedula";
            //
            // _txtCedula
            //
            this._txtCedula.BorderStyle = BorderStyle.FixedSingle;
            this._txtCedula.Font = Estilos.FuenteTexto;
            this._txtCedula.Location = new Point(518, 68);
            this._txtCedula.Name = "_txtCedula";
            this._txtCedula.Size = new Size(230, 26);
            this._txtCedula.TabIndex = 6;
            //
            // _lblFecha
            //
            this._lblFecha.AutoSize = true;
            this._lblFecha.Font = Estilos.FuenteTexto;
            this._lblFecha.ForeColor = Estilos.TextoSecundario;
            this._lblFecha.Location = new Point(768, 45);
            this._lblFecha.Name = "_lblFecha";
            this._lblFecha.Size = new Size(150, 19);
            this._lblFecha.TabIndex = 7;
            this._lblFecha.Text = "Fecha de nacimiento";
            //
            // _dtpFechaNacimiento
            //
            this._dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            this._dtpFechaNacimiento.Location = new Point(768, 68);
            this._dtpFechaNacimiento.MaxDate = DateTime.Today;
            this._dtpFechaNacimiento.Name = "_dtpFechaNacimiento";
            this._dtpFechaNacimiento.Size = new Size(200, 26);
            this._dtpFechaNacimiento.TabIndex = 8;
            //
            // _botonNuevo
            //
            this._botonNuevo.ColorFondoHover = ColorTranslator.FromHtml("#C9D0DA");
            this._botonNuevo.ColorFondoNormal = Estilos.Borde;
            this._botonNuevo.ColorTextoBoton = Estilos.TextoPrincipal;
            this._botonNuevo.Location = new Point(18, 108);
            this._botonNuevo.Name = "_botonNuevo";
            this._botonNuevo.Size = new Size(120, 34);
            this._botonNuevo.TabIndex = 9;
            this._botonNuevo.Text = "NUEVO";
            this._botonNuevo.UseVisualStyleBackColor = true;
            this._botonNuevo.Click += new EventHandler(this.BotonNuevo_Click);
            //
            // _botonGuardar
            //
            this._botonGuardar.ColorFondoHover = Estilos.AcentoOscuro;
            this._botonGuardar.ColorFondoNormal = Estilos.Acento;
            this._botonGuardar.ColorTextoBoton = Estilos.TextoPrincipal;
            this._botonGuardar.Location = new Point(148, 108);
            this._botonGuardar.Name = "_botonGuardar";
            this._botonGuardar.Size = new Size(120, 34);
            this._botonGuardar.TabIndex = 10;
            this._botonGuardar.Text = "GUARDAR";
            this._botonGuardar.UseVisualStyleBackColor = true;
            this._botonGuardar.Click += new EventHandler(this.BotonGuardar_Click);
            //
            // _botonEliminar
            //
            this._botonEliminar.ColorFondoHover = ColorTranslator.FromHtml("#96271C");
            this._botonEliminar.ColorFondoNormal = Estilos.Peligro;
            this._botonEliminar.ColorTextoBoton = Color.White;
            this._botonEliminar.Location = new Point(278, 108);
            this._botonEliminar.Name = "_botonEliminar";
            this._botonEliminar.Size = new Size(120, 34);
            this._botonEliminar.TabIndex = 11;
            this._botonEliminar.Text = "ELIMINAR";
            this._botonEliminar.UseVisualStyleBackColor = true;
            this._botonEliminar.Click += new EventHandler(this.BotonEliminar_Click);
            //
            // _tabla
            //
            this._tabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this._tabla.Columns.AddRange(new DataGridViewColumn[] {
            this._colNombre,
            this._colApellido,
            this._colCedula,
            this._colFechaNacimiento});
            this._tabla.Location = new Point(0, 216);
            this._tabla.Name = "_tabla";
            this._tabla.Size = new Size(1000, 400);
            this._tabla.TabIndex = 2;
            this._tabla.SelectionChanged += new EventHandler(this.Tabla_SelectionChanged);
            //
            // _colNombre
            //
            this._colNombre.HeaderText = "Nombre";
            this._colNombre.Name = "_colNombre";
            //
            // _colApellido
            //
            this._colApellido.HeaderText = "Apellido";
            this._colApellido.Name = "_colApellido";
            //
            // _colCedula
            //
            this._colCedula.HeaderText = "Cedula";
            this._colCedula.Name = "_colCedula";
            //
            // _colFechaNacimiento
            //
            this._colFechaNacimiento.HeaderText = "Fecha de nacimiento";
            this._colFechaNacimiento.Name = "_colFechaNacimiento";
            //
            // ControlChoferes
            //
            this.AutoScaleDimensions = new SizeF(7f, 15f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Estilos.FondoPrincipal;
            this.Controls.Add(this._tabla);
            this.Controls.Add(this._panelFormulario);
            this.Controls.Add(this._lblTitulo);
            this.Name = "ControlChoferes";
            this.Size = new Size(1000, 650);
            this._panelFormulario.ResumeLayout(false);
            this._panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
