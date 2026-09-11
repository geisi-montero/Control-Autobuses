using System.Drawing;
using System.Windows.Forms;
using SistemaControlAutobuses.Presentacion.Utilidades;

namespace SistemaControlAutobuses.Presentacion.Formularios
{
    partial class ControlDashboard
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

        #region Código generado por el Diseñador de componentes

        private Label _lblTitulo;
        private Label _lblSubtitulo;
        private FlowLayoutPanel _panelTarjetas;
        private TarjetaIndicador _tarjetaChoferes;
        private TarjetaIndicador _tarjetaAutobuses;
        private TarjetaIndicador _tarjetaRutas;
        private TarjetaIndicador _tarjetaAsignaciones;

        /// <summary>
        /// Método necesario para admitir el Diseñador. No modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblTitulo = new System.Windows.Forms.Label();
            this._lblSubtitulo = new System.Windows.Forms.Label();
            this._panelTarjetas = new System.Windows.Forms.FlowLayoutPanel();
            this._tarjetaChoferes = new SistemaControlAutobuses.Presentacion.Utilidades.TarjetaIndicador();
            this._tarjetaAutobuses = new SistemaControlAutobuses.Presentacion.Utilidades.TarjetaIndicador();
            this._tarjetaRutas = new SistemaControlAutobuses.Presentacion.Utilidades.TarjetaIndicador();
            this._tarjetaAsignaciones = new SistemaControlAutobuses.Presentacion.Utilidades.TarjetaIndicador();
            this._panelTarjetas.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblTitulo
            // 
            this._lblTitulo.AutoSize = true;
            this._lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this._lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this._lblTitulo.Location = new System.Drawing.Point(0, 0);
            this._lblTitulo.Name = "_lblTitulo";
            this._lblTitulo.Size = new System.Drawing.Size(132, 32);
            this._lblTitulo.TabIndex = 0;
            this._lblTitulo.Text = "Dashboard";
            // 
            // _lblSubtitulo
            // 
            this._lblSubtitulo.AutoSize = true;
            this._lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this._lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this._lblSubtitulo.Location = new System.Drawing.Point(3, 42);
            this._lblSubtitulo.Name = "_lblSubtitulo";
            this._lblSubtitulo.Size = new System.Drawing.Size(298, 20);
            this._lblSubtitulo.TabIndex = 1;
            this._lblSubtitulo.Text = "Resumen general del sistema de transporte.";
            // 
            // _panelTarjetas
            // 
            this._panelTarjetas.Controls.Add(this._tarjetaChoferes);
            this._panelTarjetas.Controls.Add(this._tarjetaAutobuses);
            this._panelTarjetas.Controls.Add(this._tarjetaRutas);
            this._panelTarjetas.Controls.Add(this._tarjetaAsignaciones);
            this._panelTarjetas.Location = new System.Drawing.Point(0, 78);
            this._panelTarjetas.Name = "_panelTarjetas";
            this._panelTarjetas.Size = new System.Drawing.Size(857, 113);
            this._panelTarjetas.TabIndex = 2;
            this._panelTarjetas.WrapContents = false;
            // 
            // _tarjetaChoferes
            // 
            this._tarjetaChoferes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tarjetaChoferes.ColorAcento = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(112)))));
            this._tarjetaChoferes.Location = new System.Drawing.Point(0, 0);
            this._tarjetaChoferes.Margin = new System.Windows.Forms.Padding(0, 0, 17, 0);
            this._tarjetaChoferes.Name = "_tarjetaChoferes";
            this._tarjetaChoferes.Padding = new System.Windows.Forms.Padding(15, 12, 12, 12);
            this._tarjetaChoferes.Size = new System.Drawing.Size(197, 95);
            this._tarjetaChoferes.TabIndex = 0;
            this._tarjetaChoferes.Titulo = "CHOFERES ACTIVOS";
            this._tarjetaChoferes.Valor = "0";
            // 
            // _tarjetaAutobuses
            // 
            this._tarjetaAutobuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tarjetaAutobuses.ColorAcento = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(143)))), ((int)(((byte)(91)))));
            this._tarjetaAutobuses.Location = new System.Drawing.Point(214, 0);
            this._tarjetaAutobuses.Margin = new System.Windows.Forms.Padding(0, 0, 17, 0);
            this._tarjetaAutobuses.Name = "_tarjetaAutobuses";
            this._tarjetaAutobuses.Padding = new System.Windows.Forms.Padding(15, 12, 12, 12);
            this._tarjetaAutobuses.Size = new System.Drawing.Size(197, 95);
            this._tarjetaAutobuses.TabIndex = 1;
            this._tarjetaAutobuses.Titulo = "AUTOBUSES ACTIVOS";
            this._tarjetaAutobuses.Valor = "0";
            // 
            // _tarjetaRutas
            // 
            this._tarjetaRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tarjetaRutas.ColorAcento = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(164)))), ((int)(((byte)(56)))));
            this._tarjetaRutas.Location = new System.Drawing.Point(428, 0);
            this._tarjetaRutas.Margin = new System.Windows.Forms.Padding(0, 0, 17, 0);
            this._tarjetaRutas.Name = "_tarjetaRutas";
            this._tarjetaRutas.Padding = new System.Windows.Forms.Padding(15, 12, 12, 12);
            this._tarjetaRutas.Size = new System.Drawing.Size(197, 95);
            this._tarjetaRutas.TabIndex = 2;
            this._tarjetaRutas.Titulo = "RUTAS DISPONIBLES";
            this._tarjetaRutas.Valor = "0";
            // 
            // _tarjetaAsignaciones
            // 
            this._tarjetaAsignaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tarjetaAsignaciones.ColorAcento = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this._tarjetaAsignaciones.Location = new System.Drawing.Point(642, 0);
            this._tarjetaAsignaciones.Margin = new System.Windows.Forms.Padding(0, 0, 17, 0);
            this._tarjetaAsignaciones.Name = "_tarjetaAsignaciones";
            this._tarjetaAsignaciones.Padding = new System.Windows.Forms.Padding(15, 12, 12, 12);
            this._tarjetaAsignaciones.Size = new System.Drawing.Size(197, 95);
            this._tarjetaAsignaciones.TabIndex = 3;
            this._tarjetaAsignaciones.Titulo = "ASIGNACIONES ACTIVAS";
            this._tarjetaAsignaciones.Valor = "0";
            // 
            // ControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.Controls.Add(this._panelTarjetas);
            this.Controls.Add(this._lblSubtitulo);
            this.Controls.Add(this._lblTitulo);
            this.Name = "ControlDashboard";
            this.Size = new System.Drawing.Size(857, 520);
            this._panelTarjetas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
