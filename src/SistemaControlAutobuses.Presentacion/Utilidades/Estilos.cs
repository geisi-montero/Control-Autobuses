using System.Drawing;

namespace SistemaControlAutobuses.Presentacion.Utilidades
{
    
    public static class Estilos
    {
        public static readonly Color FondoPrincipal   = ColorTranslator.FromHtml("#F2F4F7");
        public static readonly Color FondoTarjeta      = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color BarraLateral      = ColorTranslator.FromHtml("#16233D");
        public static readonly Color BarraLateralHover = ColorTranslator.FromHtml("#223458");
        public static readonly Color BarraLateralActiva= ColorTranslator.FromHtml("#2C4470");
        public static readonly Color Acento            = ColorTranslator.FromHtml("#E0A438");
        public static readonly Color AcentoOscuro      = ColorTranslator.FromHtml("#B9821F");
        public static readonly Color TextoPrincipal    = ColorTranslator.FromHtml("#1E2430");
        public static readonly Color TextoSecundario   = ColorTranslator.FromHtml("#6B7280");
        public static readonly Color TextoClaro        = ColorTranslator.FromHtml("#F2F4F7");
        public static readonly Color Borde             = ColorTranslator.FromHtml("#DDE2E8");
        public static readonly Color Exito             = ColorTranslator.FromHtml("#2F8F5B");
        public static readonly Color Peligro           = ColorTranslator.FromHtml("#C0392B");
        public static readonly Color Informativo       = ColorTranslator.FromHtml("#2C4470");

        public static readonly Font FuenteTitulo    = new Font("Segoe UI Semibold", 18f, FontStyle.Regular);
        public static readonly Font FuenteSubtitulo = new Font("Segoe UI", 11f, FontStyle.Regular);
        public static readonly Font FuenteTexto     = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        public static readonly Font FuenteTextoNegrita = new Font("Segoe UI Semibold", 9.5f, FontStyle.Regular);
        public static readonly Font FuenteBoton     = new Font("Segoe UI Semibold", 9.5f, FontStyle.Regular);
        public static readonly Font FuenteMenu      = new Font("Segoe UI", 10f, FontStyle.Regular);
        public static readonly Font FuenteIndicador = new Font("Segoe UI Semibold", 26f, FontStyle.Regular);
    }
}
