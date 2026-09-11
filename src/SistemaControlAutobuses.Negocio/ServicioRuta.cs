using System.Collections.Generic;
using SistemaControlAutobuses.Datos.Repositorios;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Negocio
{
    
    public class ServicioRuta
    {
        private readonly IRutaRepository _repositorio;

        public ServicioRuta(IRutaRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Ruta> Consultar(RolUsuario rol)
        {
            ValidarAdministrador(rol);
            return _repositorio.Consultar();
        }

        public List<Ruta> ObtenerDisponibles()
        {
            return _repositorio.ObtenerDisponibles();
        }

        public int Registrar(Ruta ruta, RolUsuario rol)
        {
            ValidarAdministrador(rol);
            ValidarDatos(ruta);
            return _repositorio.Insertar(ruta);
        }

        public void Actualizar(Ruta ruta, RolUsuario rol)
        {
            ValidarAdministrador(rol);
            ValidarDatos(ruta);
            _repositorio.Actualizar(ruta);
        }

        public void Eliminar(int id, RolUsuario rol)
        {
            ValidarAdministrador(rol);
            _repositorio.Eliminar(id);
        }

        private void ValidarDatos(Ruta ruta)
        {
            if (string.IsNullOrWhiteSpace(ruta.Nombre))
                throw new ExcepcionNegocio("El nombre de la ruta es obligatorio.");
        }

        private void ValidarAdministrador(RolUsuario rol)
        {
            if (rol != RolUsuario.Administrador)
                throw new ExcepcionNegocio("No tiene permisos para realizar esta accion.");
        }
    }
}
