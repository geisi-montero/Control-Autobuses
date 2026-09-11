using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaControlAutobuses.Presentacion.Utilidades
{

    public class TarjetaIndicador : Panel
    {
        private readonly Label _lblValor;
        private readonly Label _lblTitulo;
        private readonly Panel _franjaAcento;

        public TarjetaIndicador()
        {
            BackColor = Estilos.FondoTarjeta;
            Size = new Size(230, 110);
            Padding = new Padding(18, 14, 14, 14);

            _franjaAcento = new Panel { Dock = DockStyle.Left, Width = 5, BackColor = Estilos.Acento };

            _lblTitulo = new Label
            {
                Text = "INDICADOR",
                Font = Estilos.FuenteTexto,
                ForeColor = Estilos.TextoSecundario,
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 22,
                TextAlign = ContentAlignment.MiddleLeft
            };

            _lblValor = new Label
            {
                Text = "0",
                Font = Estilos.FuenteIndicador,
                ForeColor = Estilos.TextoPrincipal,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Controls.Add(_lblValor);
            Controls.Add(_lblTitulo);
            Controls.Add(_franjaAcento);

            Paint += TarjetaIndicador_Paint;
        }

        public TarjetaIndicador(string titulo, Color colorAcento) : this()
        {
            Titulo = titulo;
            ColorAcento = colorAcento;
        }

        [Category("Datos")]
        public string Valor
        {
            get => _lblValor.Text;
            set => _lblValor.Text = value;
        }

        [Category("Apariencia")]
        public string Titulo
        {
            get => _lblTitulo.Text;
            set => _lblTitulo.Text = value;
        }

        [Category("Apariencia")]
        public Color ColorAcento
        {
            get => _franjaAcento.BackColor;
            set => _franjaAcento.BackColor = value;
        }

        private void TarjetaIndicador_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Estilos.Borde, ButtonBorderStyle.Solid);
        }
    }
}
