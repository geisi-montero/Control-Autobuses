using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    partial class ControlAsignaciones
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
        private Label _lblEncabezado;
        private Label _lblChofer;
        private ComboBox _comboChofer;
        private Label _lblAutobus;
        private ComboBox _comboAutobus;
        private Label _lblRuta;
        private ComboBox _comboRuta;
        private BotonPlano _botonAsignar;
        private BotonPlano _botonFinalizar;
        private DataGridView _tabla;
        private DataGridViewTextBoxColumn _colChofer;
        private DataGridViewTextBoxColumn _colAutobus;
        private DataGridViewTextBoxColumn _colRuta;
        private DataGridViewTextBoxColumn _colFecha;
        private DataGridViewTextBoxColumn _colEstado;

        private void InitializeComponent()
        {
            this._lblTitulo = new System.Windows.Forms.Label();
            this._panelFormulario = new System.Windows.Forms.Panel();
            this._lblEncabezado = new System.Windows.Forms.Label();
            this._lblChofer = new System.Windows.Forms.Label();
            this._comboChofer = new System.Windows.Forms.ComboBox();
            this._lblAutobus = new System.Windows.Forms.Label();
            this._comboAutobus = new System.Windows.Forms.ComboBox();
            this._lblRuta = new System.Windows.Forms.Label();
            this._comboRuta = new System.Windows.Forms.ComboBox();
            this._botonAsignar = new SistemaControlAutobuses.Presentacion.Utilidades.BotonPlano();
            this._botonFinalizar = new SistemaControlAutobuses.Presentacion.Utilidades.BotonPlano();
            this._tabla = new System.Windows.Forms.DataGridView();
            this._colChofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colAutobus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblTitulo
            // 
            this._lblTitulo.AutoSize = true;
            this._lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this._lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this._lblTitulo.Location = new System.Drawing.Point(0, 0);
            this._lblTitulo.Name = "_lblTitulo";
            this._lblTitulo.Size = new System.Drawing.Size(155, 32);
            this._lblTitulo.TabIndex = 0;
            this._lblTitulo.Text = "Asignaciones";
            // 
            // _panelFormulario
            // 
            this._panelFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._panelFormulario.Controls.Add(this._lblEncabezado);
            this._panelFormulario.Controls.Add(this._lblChofer);
            this._panelFormulario.Controls.Add(this._comboChofer);
            this._panelFormulario.Controls.Add(this._lblAutobus);
            this._panelFormulario.Controls.Add(this._comboAutobus);
            this._panelFormulario.Controls.Add(this._lblRuta);
            this._panelFormulario.Controls.Add(this._comboRuta);
            this._panelFormulario.Controls.Add(this._botonAsignar);
            this._panelFormulario.Controls.Add(this._botonFinalizar);
            this._panelFormulario.Location = new System.Drawing.Point(0, 43);
            this._panelFormulario.Name = "_panelFormulario";
            this._panelFormulario.Size = new System.Drawing.Size(857, 130);
            this._panelFormulario.TabIndex = 1;
            this._panelFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFormulario_Paint);
            // 
            // _lblEncabezado
            // 
            this._lblEncabezado.AutoSize = true;
            this._lblEncabezado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this._lblEncabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this._lblEncabezado.Location = new System.Drawing.Point(15, 12);
            this._lblEncabezado.Name = "_lblEncabezado";
            this._lblEncabezado.Size = new System.Drawing.Size(115, 17);
            this._lblEncabezado.TabIndex = 0;
            this._lblEncabezado.Text = "Nueva asignacion";
            // 
            // _lblChofer
            // 
            this._lblChofer.AutoSize = true;
            this._lblChofer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this._lblChofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this._lblChofer.Location = new System.Drawing.Point(15, 39);
            this._lblChofer.Name = "_lblChofer";
            this._lblChofer.Size = new System.Drawing.Size(112, 17);
            this._lblChofer.TabIndex = 1;
            this._lblChofer.Text = "Chofer disponible";
            // 
            // _comboChofer
            // 
            this._comboChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboChofer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this._comboChofer.FormattingEnabled = true;
            this._comboChofer.Location = new System.Drawing.Point(15, 59);
            this._comboChofer.Name = "_comboChofer";
            this._comboChofer.Size = new System.Drawing.Size(241, 25);
            this._comboChofer.TabIndex = 2;
            // 
            // _lblAutobus
            // 
            this._lblAutobus.AutoSize = true;
            this._lblAutobus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this._lblAutobus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this._lblAutobus.Location = new System.Drawing.Point(273, 39);
            this._lblAutobus.Name = "_lblAutobus";
            this._lblAutobus.Size = new System.Drawing.Size(121, 17);
            this._lblAutobus.TabIndex = 3;
            this._lblAutobus.Text = "Autobus disponible";
            // 
            // _comboAutobus
            // 
            this._comboAutobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboAutobus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this._comboAutobus.FormattingEnabled = true;
            this._comboAutobus.Location = new System.Drawing.Point(273, 59);
            this._comboAutobus.Name = "_comboAutobus";
            this._comboAutobus.Size = new System.Drawing.Size(241, 25);
            this._comboAutobus.TabIndex = 4;
            // 
            // _lblRuta
            // 
            this._lblRuta.AutoSize = true;
            this._lblRuta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this._lblRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this._lblRuta.Location = new System.Drawing.Point(530, 39);
            this._lblRuta.Name = "_lblRuta";
            this._lblRuta.Size = new System.Drawing.Size(99, 17);
            this._lblRuta.TabIndex = 5;
            this._lblRuta.Text = "Ruta disponible";
            // 
            // _comboRuta
            // 
            this._comboRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboRuta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this._comboRuta.FormattingEnabled = true;
            this._comboRuta.Location = new System.Drawing.Point(530, 59);
            this._comboRuta.Name = "_comboRuta";
            this._comboRuta.Size = new System.Drawing.Size(241, 25);
            this._comboRuta.TabIndex = 6;
            // 
            // _botonAsignar
            // 
            this._botonAsignar.ColorFondoHover = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this._botonAsignar.ColorFondoNormal = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(164)))), ((int)(((byte)(56)))));
            this._botonAsignar.ColorTextoBoton = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this._botonAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._botonAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._botonAsignar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this._botonAsignar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this._botonAsignar.Location = new System.Drawing.Point(15, 94);
            this._botonAsignar.Name = "_botonAsignar";
            this._botonAsignar.Radio = 6;
            this._botonAsignar.Size = new System.Drawing.Size(171, 29);
            this._botonAsignar.TabIndex = 7;
            this._botonAsignar.Text = "REALIZAR ASIGNACION";
            this._botonAsignar.UseVisualStyleBackColor = true;
            this._botonAsignar.Click += new System.EventHandler(this.BotonAsignar_Click);
            // 
            // _botonFinalizar
            // 
            this._botonFinalizar.ColorFondoHover = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this._botonFinalizar.ColorFondoNormal = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(112)))));
            this._botonFinalizar.ColorTextoBoton = System.Drawing.Color.White;
            this._botonFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._botonFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._botonFinalizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this._botonFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this._botonFinalizar.Location = new System.Drawing.Point(195, 94);
            this._botonFinalizar.Name = "_botonFinalizar";
            this._botonFinalizar.Radio = 6;
            this._botonFinalizar.Size = new System.Drawing.Size(280, 29);
            this._botonFinalizar.TabIndex = 8;
            this._botonFinalizar.Text = "FINALIZAR ASIGNACION SELECCIONADA";
            this._botonFinalizar.UseVisualStyleBackColor = true;
            this._botonFinalizar.Click += new System.EventHandler(this.BotonFinalizar_Click);
            // 
            // _tabla
            // 
            this._tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._colChofer,
            this._colAutobus,
            this._colRuta,
            this._colFecha,
            this._colEstado});
            this._tabla.Location = new System.Drawing.Point(0, 187);
            this._tabla.Name = "_tabla";
            this._tabla.Size = new System.Drawing.Size(857, 347);
            this._tabla.TabIndex = 2;
            this._tabla.SelectionChanged += new System.EventHandler(this.Tabla_SelectionChanged);
            // 
            // _colChofer
            // 
            this._colChofer.HeaderText = "Chofer";
            this._colChofer.Name = "_colChofer";
            // 
            // _colAutobus
            // 
            this._colAutobus.HeaderText = "Autobus";
            this._colAutobus.Name = "_colAutobus";
            // 
            // _colRuta
            // 
            this._colRuta.HeaderText = "Ruta";
            this._colRuta.Name = "_colRuta";
            // 
            // _colFecha
            // 
            this._colFecha.HeaderText = "Fecha de asignacion";
            this._colFecha.Name = "_colFecha";
            // 
            // _colEstado
            // 
            this._colEstado.HeaderText = "Estado";
            this._colEstado.Name = "_colEstado";
            // 
            // ControlAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.Controls.Add(this._tabla);
            this.Controls.Add(this._panelFormulario);
            this.Controls.Add(this._lblTitulo);
            this.Name = "ControlAsignaciones";
            this.Size = new System.Drawing.Size(857, 563);
            this._panelFormulario.ResumeLayout(false);
            this._panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
