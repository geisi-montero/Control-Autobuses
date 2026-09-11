using System;

namespace SistemaControlAutobuses.Entidades
{
    public class Asignacion
    {
        public int Id { get; set; }

        public int ChoferId { get; set; }
        public string NombreChofer { get; set; }

        public int AutobusId { get; set; }
        public string DescripcionAutobus { get; set; }

        public int RutaId { get; set; }
        public string NombreRuta { get; set; }

        public DateTime FechaAsignacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public EstadoAsignacion Estado { get; set; }
    }
}
