using System;
using System.Collections.Generic;
using SistemaControlAutobuses.Datos.Repositorios;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Negocio
{

    public class ServicioAutobus
    {
        private readonly IAutobusRepository _repositorio;

        public ServicioAutobus(IAutobusRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Autobus> Consultar(RolUsuario rol)
        {
            ValidarAdministrador(rol);
            return _repositorio.Consultar();
        }

        public List<Autobus> ObtenerDisponibles()
        {
            return _repositorio.ObtenerDisponibles();
        }

        public int Registrar(Autobus autobus, RolUsuario rol)
        {
            ValidarAdministrador(rol);
            ValidarDatos(autobus);
            return _repositorio.Insertar(autobus);
        }

        public void Actualizar(Autobus autobus, RolUsuario rol)
        {
            ValidarAdministrador(rol);
            ValidarDatos(autobus);
            _repositorio.Actualizar(autobus);
        }

        public void Eliminar(int id, RolUsuario rol)
        {
            ValidarAdministrador(rol);
            _repositorio.Eliminar(id);
        }

        private void ValidarDatos(Autobus autobus)
        {
            if (string.IsNullOrWhiteSpace(autobus.Marca))
                throw new ExcepcionNegocio("La marca es obligatoria.");

            if (string.IsNullOrWhiteSpace(autobus.Modelo))
                throw new ExcepcionNegocio("El modelo es obligatorio.");

            if (string.IsNullOrWhiteSpace(autobus.Placa))
                throw new ExcepcionNegocio("La placa es obligatoria.");

            if (string.IsNullOrWhiteSpace(autobus.Color))
                throw new ExcepcionNegocio("El color es obligatorio.");

            if (autobus.Anio < 1980 || autobus.Anio > DateTime.Today.Year + 1)
                throw new ExcepcionNegocio("El anio ingresado no es valido.");
        }

        private void ValidarAdministrador(RolUsuario rol)
        {
            if (rol != RolUsuario.Administrador)
                throw new ExcepcionNegocio("No tiene permisos para realizar esta accion.");
        }
    }
}
