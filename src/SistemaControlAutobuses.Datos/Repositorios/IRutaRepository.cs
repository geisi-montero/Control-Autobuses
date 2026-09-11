using System.Collections.Generic;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Datos.Repositorios
{
    public interface IRutaRepository
    {
        int Insertar(Ruta ruta);
        List<Ruta> Consultar();
        void Actualizar(Ruta ruta);
        void Eliminar(int id);
        List<Ruta> ObtenerDisponibles();
    }
}
