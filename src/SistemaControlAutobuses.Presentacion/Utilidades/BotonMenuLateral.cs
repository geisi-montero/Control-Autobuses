using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaControlAutobuses.Presentacion.Utilidades
{

    public class BotonMenuLateral : Button
    {
        private bool _activo;
        private bool _sobreControl;
        private Bitmap _icono;

        public System.Func<Color, int, Bitmap> GeneradorIcono { get; set; }

        public bool Activo
        {
            get => _activo;
            set { _activo = value; ActualizarIcono(); Invalidate(); }
        }

        public BotonMenuLateral()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Height = 46;
            Font = Estilos.FuenteMenu;
            Cursor = Cursors.Hand;
            TextAlign = ContentAlignment.MiddleLeft;

            MouseEnter += (s, e) => { _sobreControl = true; Invalidate(); };
            MouseLeave += (s, e) => { _sobreControl = false; Invalidate(); };
        }

        private void ActualizarIcono()
        {
            if (GeneradorIcono == null) return;
            Color colorIcono = _activo ? Estilos.Acento : Estilos.TextoClaro;
            _icono = GeneradorIcono(colorIcono, 18);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color fondo = _activo ? Estilos.BarraLateralActiva
                        : _sobreControl ? Estilos.BarraLateralHover
                        : Estilos.BarraLateral;

            using (var pincel = new SolidBrush(fondo))
                g.FillRectangle(pincel, ClientRectangle);

            if (_activo)
            {
                using (var pincelAcento = new SolidBrush(Estilos.Acento))
                    g.FillRectangle(pincelAcento, 0, 0, 4, Height);
            }

            if (_icono == null) ActualizarIcono();
            if (_icono != null)
                g.DrawImage(_icono, 18, (Height - _icono.Height) / 2);

            var areaTexto = new Rectangle(48, 0, Width - 48, Height);
            Color colorTexto = _activo ? Estilos.TextoClaro : ColorTranslator.FromHtml("#C7D0DE");
            TextRenderer.DrawText(g, Text, Font, areaTexto, colorTexto,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }
    }
}
