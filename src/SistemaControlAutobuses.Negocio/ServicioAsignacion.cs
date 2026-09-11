using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using SistemaControlAutobuses.Datos.Repositorios;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Negocio
{
    public class ServicioAsignacion
    {
        private readonly IAsignacionRepository _repositorioAsignacion;
        private readonly IChoferRepository _repositorioChofer;
        private readonly IAutobusRepository _repositorioAutobus;
        private readonly IRutaRepository _repositorioRuta;

        public ServicioAsignacion(
            IAsignacionRepository repositorioAsignacion,
            IChoferRepository repositorioChofer,
            IAutobusRepository repositorioAutobus,
            IRutaRepository repositorioRuta)
        {
            _repositorioAsignacion = repositorioAsignacion;
            _repositorioChofer = repositorioChofer;
            _repositorioAutobus = repositorioAutobus;
            _repositorioRuta = repositorioRuta;
        }

        public List<Asignacion> Consultar()
        {
            return _repositorioAsignacion.Consultar();
        }

        public List<Asignacion> ConsultarActivas()
        {
            return _repositorioAsignacion.Consultar()
                .Where(a => a.Estado == EstadoAsignacion.Activa)
                .ToList();
        }

        public List<Chofer> ObtenerChoferesDisponibles() => _repositorioChofer.ObtenerDisponibles();

        public List<Autobus> ObtenerAutobusesDisponibles() => _repositorioAutobus.ObtenerDisponibles();

        public List<Ruta> ObtenerRutasDisponibles() => _repositorioRuta.ObtenerDisponibles();

        public int Crear(int choferId, int autobusId, int rutaId)
        {
            if (choferId <= 0)
                throw new ExcepcionNegocio("Debe seleccionar un chofer.");
            if (autobusId <= 0)
                throw new ExcepcionNegocio("Debe seleccionar un autobus.");
            if (rutaId <= 0)
                throw new ExcepcionNegocio("Debe seleccionar una ruta.");

            // Primera barrera: validacion en la capa de negocio contra los disponibles actuales.
            if (ObtenerChoferesDisponibles().All(c => c.Id != choferId))
                throw new ExcepcionNegocio("El chofer seleccionado ya se encuentra asignado.");

            if (ObtenerAutobusesDisponibles().All(a => a.Id != autobusId))
                throw new ExcepcionNegocio("El autobus seleccionado no esta disponible.");

            if (ObtenerRutasDisponibles().All(r => r.Id != rutaId))
                throw new ExcepcionNegocio("La ruta seleccionada ya esta ocupada.");

            // Segunda barrera: el procedimiento almacenado y los indices unicos filtrados
            // de la base de datos vuelven a garantizar la regla ante condiciones de carrera.
            try
            {
                return _repositorioAsignacion.Crear(choferId, autobusId, rutaId);
            }
            catch (SqlException ex)
            {
                throw new ExcepcionNegocio(ex.Message);
            }
        }

        public void Finalizar(int id)
        {
            if (id <= 0)
                throw new ExcepcionNegocio("Asignacion invalida.");

            _repositorioAsignacion.Finalizar(id);
        }
    }
}
