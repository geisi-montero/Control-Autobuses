using System;
using System.Collections.Generic;
using System.Linq;
using SistemaControlAutobuses.Datos.Repositorios;
using SistemaControlAutobuses.Entidades;

namespace SistemaControlAutobuses.Negocio
{

    public class ServicioChofer
    {
        private readonly IChoferRepository _repositorio;

        public ServicioChofer(IChoferRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Chofer> Consultar(RolUsuario rol)
        {
            ValidarAdministrador(rol);
            return _repositorio.Consultar();
        }

        public List<Chofer> ObtenerDisponibles()
        {
            return _repositorio.ObtenerDisponibles();
        }

        public int Registrar(Chofer chofer, RolUsuario rol)
        {
            ValidarAdministrador(rol);
            ValidarDatos(chofer);
            return _repositorio.Insertar(chofer);
        }

        public void Actualizar(Chofer chofer, RolUsuario rol)
        {
            ValidarAdministrador(rol);
            ValidarDatos(chofer);
            _repositorio.Actualizar(chofer);
        }

        public void Eliminar(int id, RolUsuario rol)
        {
            ValidarAdministrador(rol);
            _repositorio.Eliminar(id);
        }

        private void ValidarDatos(Chofer chofer)
        {
            if (string.IsNullOrWhiteSpace(chofer.Nombre))
                throw new ExcepcionNegocio("El nombre del chofer es obligatorio.");

            if (string.IsNullOrWhiteSpace(chofer.Apellido))
                throw new ExcepcionNegocio("El apellido del chofer es obligatorio.");

            if (string.IsNullOrWhiteSpace(chofer.Cedula))
                throw new ExcepcionNegocio("La cedula es obligatoria.");

            if (!chofer.Cedula.Trim().All(c => char.IsDigit(c) || c == '-'))
                throw new ExcepcionNegocio("La cedula solo puede contener numeros y guiones.");

            if (chofer.FechaNacimiento == default(DateTime) || chofer.FechaNacimiento > DateTime.Today)
                throw new ExcepcionNegocio("La fecha de nacimiento no es valida.");

            int edad = DateTime.Today.Year - chofer.FechaNacimiento.Year;
            if (chofer.FechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;
            if (edad < 18)
                throw new ExcepcionNegocio("El chofer debe ser mayor de edad.");
        }

        private void ValidarAdministrador(RolUsuario rol)
        {
            if (rol != RolUsuario.Administrador)
                throw new ExcepcionNegocio("No tiene permisos para realizar esta accion.");
        }
    }
}
