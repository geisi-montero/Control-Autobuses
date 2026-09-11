using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaControlAutobuses.Presentacion.Utilidades
{
 
    public class BotonPlano : Button
    {
        public Color ColorFondoNormal { get; set; } = Estilos.Acento;
        public Color ColorFondoHover { get; set; } = Estilos.AcentoOscuro;
        public Color ColorTextoBoton { get; set; } = Estilos.TextoPrincipal;
        public int Radio { get; set; } = 6;

        private bool _sobreControl;

        public BotonPlano()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                      ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Font = Estilos.FuenteBoton;
            Cursor = Cursors.Hand;
            Height = 38;
            ForeColor = ColorTextoBoton;

            MouseEnter += (s, e) => { _sobreControl = true; Invalidate(); };
            MouseLeave += (s, e) => { _sobreControl = false; Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color fondo = _sobreControl ? ColorFondoHover : ColorFondoNormal;
            var area = new Rectangle(0, 0, Width - 1, Height - 1);

            using (var ruta = CrearRuta(area, Radio))
            using (var pincel = new SolidBrush(fondo))
            {
                g.FillPath(pincel, ruta);
            }

            TextRenderer.DrawText(g, Text, Font, area, ColorTextoBoton,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private static GraphicsPath CrearRuta(Rectangle area, int radio)
        {
            var ruta = new GraphicsPath();
            int diametro = radio * 2;
            ruta.AddArc(area.X, area.Y, diametro, diametro, 180, 90);
            ruta.AddArc(area.Right - diametro, area.Y, diametro, diametro, 270, 90);
            ruta.AddArc(area.Right - diametro, area.Bottom - diametro, diametro, diametro, 0, 90);
            ruta.AddArc(area.X, area.Bottom - diametro, diametro, diametro, 90, 90);
            ruta.CloseFigure();
            return ruta;
        }
    }
}
