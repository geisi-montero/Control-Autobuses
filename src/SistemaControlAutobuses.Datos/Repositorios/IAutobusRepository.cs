using System.Collections.Generic;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Datos.Repositorios
{
    public interface IAutobusRepository
    {
        int Insertar(Autobus autobus);
        List<Autobus> Consultar();
        void Actualizar(Autobus autobus);
        void Eliminar(int id);
        List<Autobus> ObtenerDisponibles();
    }
}
