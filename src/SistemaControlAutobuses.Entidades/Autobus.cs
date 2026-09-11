namespace SistemaControlAutobuses.Entidades
{

    public class Autobus
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public bool Activo { get; set; }

        public string Descripcion => $"{Marca} {Modelo} - {Placa}";
    }
}
