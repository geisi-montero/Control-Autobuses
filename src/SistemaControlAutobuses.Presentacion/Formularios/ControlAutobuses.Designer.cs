using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    partial class ControlAutobuses
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
        private Label _lblMarca;
        private TextBox _txtMarca;
        private Label _lblModelo;
        private TextBox _txtModelo;
        private Label _lblPlaca;
        private TextBox _txtPlaca;
        private Label _lblColor;
        private TextBox _txtColor;
        private Label _lblAnio;
        private NumericUpDown _numAnio;
        private BotonPlano _botonNuevo;
        private BotonPlano _botonGuardar;
        private BotonPlano _botonEliminar;
        private DataGridView _tabla;
        private DataGridViewTextBoxColumn _colMarca;
        private DataGridViewTextBoxColumn _colModelo;
        private DataGridViewTextBoxColumn _colPlaca;
        private DataGridViewTextBoxColumn _colColor;
        private DataGridViewTextBoxColumn _colAnio;

        private void InitializeComponent()
        {
            this._lblTitulo = new Label();
            this._panelFormulario = new Panel();
            this._botonEliminar = new BotonPlano();
            this._botonGuardar = new BotonPlano();
            this._botonNuevo = new BotonPlano();
            this._numAnio = new NumericUpDown();
            this._lblAnio = new Label();
            this._lblEncabezadoFormulario = new Label();
            this._lblMarca = new Label();
            this._txtMarca = new TextBox();
            this._lblModelo = new Label();
            this._txtModelo = new TextBox();
            this._lblPlaca = new Label();
            this._txtPlaca = new TextBox();
            this._lblColor = new Label();
            this._txtColor = new TextBox();
            this._tabla = new DataGridView();
            this._colMarca = new DataGridViewTextBoxColumn();
            this._colModelo = new DataGridViewTextBoxColumn();
            this._colPlaca = new DataGridViewTextBoxColumn();
            this._colColor = new DataGridViewTextBoxColumn();
            this._colAnio = new DataGridViewTextBoxColumn();
            this._panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numAnio)).BeginInit();
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
            this._lblTitulo.Size = new Size(100, 32);
            this._lblTitulo.TabIndex = 0;
            this._lblTitulo.Text = "Autobuses";
            //
            // _panelFormulario
            //
            this._panelFormulario.BackColor = Estilos.FondoTarjeta;
            this._panelFormulario.Controls.Add(this._lblEncabezadoFormulario);
            this._panelFormulario.Controls.Add(this._lblMarca);
            this._panelFormulario.Controls.Add(this._txtMarca);
            this._panelFormulario.Controls.Add(this._lblModelo);
            this._panelFormulario.Controls.Add(this._txtModelo);
            this._panelFormulario.Controls.Add(this._lblPlaca);
            this._panelFormulario.Controls.Add(this._txtPlaca);
            this._panelFormulario.Controls.Add(this._lblColor);
            this._panelFormulario.Controls.Add(this._txtColor);
            this._panelFormulario.Controls.Add(this._lblAnio);
            this._panelFormulario.Controls.Add(this._numAnio);
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
            this._lblEncabezadoFormulario.Text = "Nuevo autobus";
            //
            // _lblMarca
            //
            this._lblMarca.AutoSize = true;
            this._lblMarca.Font = Estilos.FuenteTexto;
            this._lblMarca.ForeColor = Estilos.TextoSecundario;
            this._lblMarca.Location = new Point(18, 45);
            this._lblMarca.Name = "_lblMarca";
            this._lblMarca.Size = new Size(45, 19);
            this._lblMarca.TabIndex = 1;
            this._lblMarca.Text = "Marca";
            //
            // _txtMarca
            //
            this._txtMarca.BorderStyle = BorderStyle.FixedSingle;
            this._txtMarca.Font = Estilos.FuenteTexto;
            this._txtMarca.Location = new Point(18, 68);
            this._txtMarca.Name = "_txtMarca";
            this._txtMarca.Size = new Size(190, 26);
            this._txtMarca.TabIndex = 2;
            //
            // _lblModelo
            //
            this._lblModelo.AutoSize = true;
            this._lblModelo.Font = Estilos.FuenteTexto;
            this._lblModelo.ForeColor = Estilos.TextoSecundario;
            this._lblModelo.Location = new Point(228, 45);
            this._lblModelo.Name = "_lblModelo";
            this._lblModelo.Size = new Size(53, 19);
            this._lblModelo.TabIndex = 3;
            this._lblModelo.Text = "Modelo";
            //
            // _txtModelo
            //
            this._txtModelo.BorderStyle = BorderStyle.FixedSingle;
            this._txtModelo.Font = Estilos.FuenteTexto;
            this._txtModelo.Location = new Point(228, 68);
            this._txtModelo.Name = "_txtModelo";
            this._txtModelo.Size = new Size(190, 26);
            this._txtModelo.TabIndex = 4;
            //
            // _lblPlaca
            //
            this._lblPlaca.AutoSize = true;
            this._lblPlaca.Font = Estilos.FuenteTexto;
            this._lblPlaca.ForeColor = Estilos.TextoSecundario;
            this._lblPlaca.Location = new Point(438, 45);
            this._lblPlaca.Name = "_lblPlaca";
            this._lblPlaca.Size = new Size(38, 19);
            this._lblPlaca.TabIndex = 5;
            this._lblPlaca.Text = "Placa";
            //
            // _txtPlaca
            //
            this._txtPlaca.BorderStyle = BorderStyle.FixedSingle;
            this._txtPlaca.Font = Estilos.FuenteTexto;
            this._txtPlaca.Location = new Point(438, 68);
            this._txtPlaca.Name = "_txtPlaca";
            this._txtPlaca.Size = new Size(150, 26);
            this._txtPlaca.TabIndex = 6;
            //
            // _lblColor
            //
            this._lblColor.AutoSize = true;
            this._lblColor.Font = Estilos.FuenteTexto;
            this._lblColor.ForeColor = Estilos.TextoSecundario;
            this._lblColor.Location = new Point(608, 45);
            this._lblColor.Name = "_lblColor";
            this._lblColor.Size = new Size(40, 19);
            this._lblColor.TabIndex = 7;
            this._lblColor.Text = "Color";
            //
            // _txtColor
            //
            this._txtColor.BorderStyle = BorderStyle.FixedSingle;
            this._txtColor.Font = Estilos.FuenteTexto;
            this._txtColor.Location = new Point(608, 68);
            this._txtColor.Name = "_txtColor";
            this._txtColor.Size = new Size(150, 26);
            this._txtColor.TabIndex = 8;
            //
            // _lblAnio
            //
            this._lblAnio.AutoSize = true;
            this._lblAnio.Font = Estilos.FuenteTexto;
            this._lblAnio.ForeColor = Estilos.TextoSecundario;
            this._lblAnio.Location = new Point(778, 45);
            this._lblAnio.Name = "_lblAnio";
            this._lblAnio.Size = new Size(34, 19);
            this._lblAnio.TabIndex = 9;
            this._lblAnio.Text = "Anio";
            //
            // _numAnio
            //
            this._numAnio.Location = new Point(778, 68);
            this._numAnio.Maximum = new decimal(new int[] { DateTime.Today.Year + 1, 0, 0, 0 });
            this._numAnio.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            this._numAnio.Name = "_numAnio";
            this._numAnio.Size = new Size(90, 26);
            this._numAnio.TabIndex = 10;
            this._numAnio.Value = new decimal(new int[] { DateTime.Today.Year, 0, 0, 0 });
            //
            // _botonNuevo
            //
            this._botonNuevo.ColorFondoHover = ColorTranslator.FromHtml("#C9D0DA");
            this._botonNuevo.ColorFondoNormal = Estilos.Borde;
            this._botonNuevo.ColorTextoBoton = Estilos.TextoPrincipal;
            this._botonNuevo.Location = new Point(18, 108);
            this._botonNuevo.Name = "_botonNuevo";
            this._botonNuevo.Size = new Size(120, 34);
            this._botonNuevo.TabIndex = 11;
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
            this._botonGuardar.TabIndex = 12;
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
            this._botonEliminar.TabIndex = 13;
            this._botonEliminar.Text = "ELIMINAR";
            this._botonEliminar.UseVisualStyleBackColor = true;
            this._botonEliminar.Click += new EventHandler(this.BotonEliminar_Click);
            //
            // _tabla
            //
            this._tabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this._tabla.Columns.AddRange(new DataGridViewColumn[] {
            this._colMarca,
            this._colModelo,
            this._colPlaca,
            this._colColor,
            this._colAnio});
            this._tabla.Location = new Point(0, 216);
            this._tabla.Name = "_tabla";
            this._tabla.Size = new Size(1000, 400);
            this._tabla.TabIndex = 2;
            this._tabla.SelectionChanged += new EventHandler(this.Tabla_SelectionChanged);
            //
            // _colMarca
            //
            this._colMarca.HeaderText = "Marca";
            this._colMarca.Name = "_colMarca";
            //
            // _colModelo
            //
            this._colModelo.HeaderText = "Modelo";
            this._colModelo.Name = "_colModelo";
            //
            // _colPlaca
            //
            this._colPlaca.HeaderText = "Placa";
            this._colPlaca.Name = "_colPlaca";
            //
            // _colColor
            //
            this._colColor.HeaderText = "Color";
            this._colColor.Name = "_colColor";
            //
            // _colAnio
            //
            this._colAnio.HeaderText = "Anio";
            this._colAnio.Name = "_colAnio";
            //
            // ControlAutobuses
            //
            this.AutoScaleDimensions = new SizeF(7f, 15f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Estilos.FondoPrincipal;
            this.Controls.Add(this._tabla);
            this.Controls.Add(this._panelFormulario);
            this.Controls.Add(this._lblTitulo);
            this.Name = "ControlAutobuses";
            this.Size = new Size(1000, 650);
            this._panelFormulario.ResumeLayout(false);
            this._panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
