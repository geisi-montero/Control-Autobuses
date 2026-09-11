using System.Collections.Generic;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Datos.Repositorios
{
    public interface IAsignacionRepository
    {
        int Crear(int choferId, int autobusId, int rutaId);
        List<Asignacion> Consultar();
        void Finalizar(int id);
    }
}
