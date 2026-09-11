using System.Drawing;
using System.Windows.Forms;

namespace SistemaControlAutobuses.Presentacion.Utilidades
{

    public static class EstiloTabla
    {
        public static void Aplicar(DataGridView tabla)
        {
            tabla.BorderStyle = BorderStyle.None;
            tabla.BackgroundColor = Estilos.FondoTarjeta;
            tabla.GridColor = Estilos.Borde;
            tabla.RowHeadersVisible = false;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.AllowUserToResizeRows = false;
            tabla.ReadOnly = true;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.MultiSelect = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tabla.ColumnHeadersHeight = 38;
            tabla.RowTemplate.Height = 34;
            tabla.EnableHeadersVisualStyles = false;
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            tabla.ColumnHeadersDefaultCellStyle.BackColor = Estilos.FondoPrincipal;
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Estilos.TextoSecundario;
            tabla.ColumnHeadersDefaultCellStyle.Font = Estilos.FuenteTextoNegrita;
            tabla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tabla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Estilos.FondoPrincipal;
            tabla.ColumnHeadersDefaultCellStyle.SelectionForeColor = Estilos.TextoSecundario;

            tabla.DefaultCellStyle.Font = Estilos.FuenteTexto;
            tabla.DefaultCellStyle.ForeColor = Estilos.TextoPrincipal;
            tabla.DefaultCellStyle.SelectionBackColor = Estilos.BarraLateralActiva;
            tabla.DefaultCellStyle.SelectionForeColor = Estilos.TextoClaro;
            tabla.DefaultCellStyle.Padding = new Padding(6, 4, 6, 4);

            tabla.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFBFC");
        }
    }
}
