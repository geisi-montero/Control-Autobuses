using System.Collections.Generic;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Datos.Repositorios
{
    public interface IChoferRepository
    {
        int Insertar(Chofer chofer);
        List<Chofer> Consultar();
        void Actualizar(Chofer chofer);
        void Eliminar(int id);
        List<Chofer> ObtenerDisponibles();
    }
}
