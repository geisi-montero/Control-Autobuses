using System;

namespace SistemaControlAutobuses.Negocio
{
    public class ExcepcionNegocio : Exception
    {
        public ExcepcionNegocio(string mensaje) : base(mensaje) { }
    }
}
