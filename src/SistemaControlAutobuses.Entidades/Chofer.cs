using System;

namespace SistemaControlAutobuses.Entidades
{
    public class Chofer
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cedula { get; set; }
        public bool Activo { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}
