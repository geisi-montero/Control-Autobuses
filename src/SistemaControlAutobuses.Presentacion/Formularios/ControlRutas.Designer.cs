using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    partial class ControlRutas
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
        private BotonPlano _botonNuevo;
        private BotonPlano _botonGuardar;
        private BotonPlano _botonEliminar;
        private DataGridView _tabla;
        private DataGridViewTextBoxColumn _colNombre;

        private void InitializeComponent()
        {
            this._lblTitulo = new Label();
            this._panelFormulario = new Panel();
            this._botonEliminar = new BotonPlano();
            this._botonGuardar = new BotonPlano();
            this._botonNuevo = new BotonPlano();
            this._txtNombre = new TextBox();
            this._lblNombre = new Label();
            this._lblEncabezadoFormulario = new Label();
            this._tabla = new DataGridView();
            this._colNombre = new DataGridViewTextBoxColumn();
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
            this._lblTitulo.Size = new Size(70, 32);
            this._lblTitulo.TabIndex = 0;
            this._lblTitulo.Text = "Rutas";
            //
            // _panelFormulario
            //
            this._panelFormulario.BackColor = Estilos.FondoTarjeta;
            this._panelFormulario.Controls.Add(this._lblEncabezadoFormulario);
            this._panelFormulario.Controls.Add(this._lblNombre);
            this._panelFormulario.Controls.Add(this._txtNombre);
            this._panelFormulario.Controls.Add(this._botonNuevo);
            this._panelFormulario.Controls.Add(this._botonGuardar);
            this._panelFormulario.Controls.Add(this._botonEliminar);
            this._panelFormulario.Location = new Point(0, 50);
            this._panelFormulario.Name = "_panelFormulario";
            this._panelFormulario.Size = new Size(1000, 110);
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
            this._lblEncabezadoFormulario.Size = new Size(90, 20);
            this._lblEncabezadoFormulario.TabIndex = 0;
            this._lblEncabezadoFormulario.Text = "Nueva ruta";
            //
            // _lblNombre
            //
            this._lblNombre.AutoSize = true;
            this._lblNombre.Font = Estilos.FuenteTexto;
            this._lblNombre.ForeColor = Estilos.TextoSecundario;
            this._lblNombre.Location = new Point(18, 45);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new Size(120, 19);
            this._lblNombre.TabIndex = 1;
            this._lblNombre.Text = "Nombre de la ruta";
            //
            // _txtNombre
            //
            this._txtNombre.BorderStyle = BorderStyle.FixedSingle;
            this._txtNombre.Font = Estilos.FuenteTexto;
            this._txtNombre.Location = new Point(18, 68);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new Size(400, 26);
            this._txtNombre.TabIndex = 2;
            //
            // _botonNuevo
            //
            this._botonNuevo.ColorFondoHover = ColorTranslator.FromHtml("#C9D0DA");
            this._botonNuevo.ColorFondoNormal = Estilos.Borde;
            this._botonNuevo.ColorTextoBoton = Estilos.TextoPrincipal;
            this._botonNuevo.Location = new Point(440, 67);
            this._botonNuevo.Name = "_botonNuevo";
            this._botonNuevo.Size = new Size(110, 30);
            this._botonNuevo.TabIndex = 3;
            this._botonNuevo.Text = "NUEVO";
            this._botonNuevo.UseVisualStyleBackColor = true;
            this._botonNuevo.Click += new EventHandler(this.BotonNuevo_Click);
            //
            // _botonGuardar
            //
            this._botonGuardar.ColorFondoHover = Estilos.AcentoOscuro;
            this._botonGuardar.ColorFondoNormal = Estilos.Acento;
            this._botonGuardar.ColorTextoBoton = Estilos.TextoPrincipal;
            this._botonGuardar.Location = new Point(560, 67);
            this._botonGuardar.Name = "_botonGuardar";
            this._botonGuardar.Size = new Size(110, 30);
            this._botonGuardar.TabIndex = 4;
            this._botonGuardar.Text = "GUARDAR";
            this._botonGuardar.UseVisualStyleBackColor = true;
            this._botonGuardar.Click += new EventHandler(this.BotonGuardar_Click);
            //
            // _botonEliminar
            //
            this._botonEliminar.ColorFondoHover = ColorTranslator.FromHtml("#96271C");
            this._botonEliminar.ColorFondoNormal = Estilos.Peligro;
            this._botonEliminar.ColorTextoBoton = Color.White;
            this._botonEliminar.Location = new Point(680, 67);
            this._botonEliminar.Name = "_botonEliminar";
            this._botonEliminar.Size = new Size(110, 30);
            this._botonEliminar.TabIndex = 5;
            this._botonEliminar.Text = "ELIMINAR";
            this._botonEliminar.UseVisualStyleBackColor = true;
            this._botonEliminar.Click += new EventHandler(this.BotonEliminar_Click);
            //
            // _tabla
            //
            this._tabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this._tabla.Columns.AddRange(new DataGridViewColumn[] {
            this._colNombre});
            this._tabla.Location = new Point(0, 176);
            this._tabla.Name = "_tabla";
            this._tabla.Size = new Size(1000, 440);
            this._tabla.TabIndex = 2;
            this._tabla.SelectionChanged += new EventHandler(this.Tabla_SelectionChanged);
            //
            // _colNombre
            //
            this._colNombre.HeaderText = "Ruta";
            this._colNombre.Name = "_colNombre";
            //
            // ControlRutas
            //
            this.AutoScaleDimensions = new SizeF(7f, 15f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Estilos.FondoPrincipal;
            this.Controls.Add(this._tabla);
            this.Controls.Add(this._panelFormulario);
            this.Controls.Add(this._lblTitulo);
            this.Name = "ControlRutas";
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
