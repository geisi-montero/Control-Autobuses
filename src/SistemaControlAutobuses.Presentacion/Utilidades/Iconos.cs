using System.Drawing;
using System.Drawing.Drawing2D;

namespace SistemaControlAutobuses.Presentacion.Utilidades
{
   
    public static class Iconos
    {
        public static Bitmap Dashboard(Color color, int tamano = 20) => Dibujar(tamano, (g, t) =>
        {
            using (var lapiz = new Pen(color, t / 12f))
            {
                float m = t * 0.12f, ancho = (t - m * 3) / 2f, alto = ancho;
                g.DrawRectangle(lapiz, m, m, ancho, alto);
                g.DrawRectangle(lapiz, m * 2 + ancho, m, ancho, alto);
                g.DrawRectangle(lapiz, m, m * 2 + alto, ancho, alto);
                g.DrawRectangle(lapiz, m * 2 + ancho, m * 2 + alto, ancho, alto);
            }
        });

        public static Bitmap Chofer(Color color, int tamano = 20) => Dibujar(tamano, (g, t) =>
        {
            using (var lapiz = new Pen(color, t / 11f) { LineJoin = LineJoin.Round })
            {
                float cabezaDiam = t * 0.34f;
                g.DrawEllipse(lapiz, (t - cabezaDiam) / 2f, t * 0.10f, cabezaDiam, cabezaDiam);

                var ruta = new GraphicsPath();
                float y = t * 0.52f;
                ruta.AddArc(t * 0.12f, y, t * 0.76f, t * 0.62f, 180, 180);
                g.DrawPath(lapiz, ruta);
            }
        });

        public static Bitmap Autobus(Color color, int tamano = 20) => Dibujar(tamano, (g, t) =>
        {
            using (var lapiz = new Pen(color, t / 12f) { LineJoin = LineJoin.Round })
            {
                var carroceria = new RectangleF(t * 0.08f, t * 0.20f, t * 0.84f, t * 0.48f);
                using (var ruta = CrearRectanguloRedondeado(carroceria, t * 0.10f))
                    g.DrawPath(lapiz, ruta);

                float yVentana = t * 0.28f, alturaVentana = t * 0.18f;
                g.DrawLine(lapiz, t * 0.20f, yVentana, t * 0.20f, yVentana + alturaVentana);
                g.DrawLine(lapiz, t * 0.44f, yVentana, t * 0.44f, yVentana + alturaVentana);
                g.DrawLine(lapiz, t * 0.68f, yVentana, t * 0.68f, yVentana + alturaVentana);

                float radioRueda = t * 0.09f, yRueda = t * 0.68f - radioRueda;
                g.FillEllipse(new SolidBrush(color), t * 0.20f - radioRueda, yRueda, radioRueda * 2, radioRueda * 2);
                g.FillEllipse(new SolidBrush(color), t * 0.72f - radioRueda, yRueda, radioRueda * 2, radioRueda * 2);
            }
        });

        public static Bitmap Ruta(Color color, int tamano = 20) => Dibujar(tamano, (g, t) =>
        {
            using (var lapiz = new Pen(color, t / 12f) { LineJoin = LineJoin.Round })
            {
                var contorno = new GraphicsPath();
                var rectangulo = new RectangleF(t * 0.20f, t * 0.08f, t * 0.60f, t * 0.60f);
                contorno.AddArc(rectangulo, 200, 320);
                var puntoInferior = new PointF(t * 0.50f, t * 0.92f);
                contorno.AddLine(contorno.GetLastPoint(), puntoInferior);
                g.DrawPath(lapiz, contorno);
                g.DrawEllipse(lapiz, t * 0.38f, t * 0.24f, t * 0.24f, t * 0.24f);
            }
        });

        public static Bitmap Asignacion(Color color, int tamano = 20) => Dibujar(tamano, (g, t) =>
        {
            using (var lapiz = new Pen(color, t / 11f) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                g.DrawEllipse(lapiz, t * 0.10f, t * 0.30f, t * 0.40f, t * 0.40f);
                g.DrawEllipse(lapiz, t * 0.50f, t * 0.30f, t * 0.40f, t * 0.40f);
                g.DrawLine(lapiz, t * 0.42f, t * 0.50f, t * 0.58f, t * 0.50f);
            }
        });

        public static Bitmap Salir(Color color, int tamano = 20) => Dibujar(tamano, (g, t) =>
        {
            using (var lapiz = new Pen(color, t / 11f) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                var puerta = new RectangleF(t * 0.14f, t * 0.14f, t * 0.40f, t * 0.72f);
                using (var ruta = CrearRectanguloRedondeado(puerta, t * 0.06f))
                    g.DrawPath(lapiz, ruta);

                g.DrawLine(lapiz, t * 0.42f, t * 0.50f, t * 0.90f, t * 0.50f);
                g.DrawLine(lapiz, t * 0.72f, t * 0.32f, t * 0.90f, t * 0.50f);
                g.DrawLine(lapiz, t * 0.72f, t * 0.68f, t * 0.90f, t * 0.50f);
            }
        });

        private static Bitmap Dibujar(int tamano, System.Action<Graphics, float> accion)
        {
            var mapaBits = new Bitmap(tamano, tamano);
            using (var g = Graphics.FromImage(mapaBits))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                accion(g, tamano);
            }
            return mapaBits;
        }

        private static GraphicsPath CrearRectanguloRedondeado(RectangleF rectangulo, float radio)
        {
            var ruta = new GraphicsPath();
            float diametro = radio * 2;
            ruta.AddArc(rectangulo.X, rectangulo.Y, diametro, diametro, 180, 90);
            ruta.AddArc(rectangulo.Right - diametro, rectangulo.Y, diametro, diametro, 270, 90);
            ruta.AddArc(rectangulo.Right - diametro, rectangulo.Bottom - diametro, diametro, diametro, 0, 90);
            ruta.AddArc(rectangulo.X, rectangulo.Bottom - diametro, diametro, diametro, 90, 90);
            ruta.CloseFigure();
            return ruta;
        }
    }
}
