using System;
using System.Security.Cryptography;

namespace SistemaControlAutobuses.Negocio
{
 
    public static class UtilidadContrasena
    {
        private const int TamanoSalBytes = 16;
        private const int TamanoHashBytes = 32;
        private const int Iteraciones = 10000;

        public static string GenerarHash(string contrasena)
        {
            byte[] sal = new byte[TamanoSalBytes];
            using (var generador = RandomNumberGenerator.Create())
            {
                generador.GetBytes(sal);
            }

            byte[] hash = CalcularHash(contrasena, sal);
            return $"{Convert.ToBase64String(sal)}.{Convert.ToBase64String(hash)}";
        }

        public static bool Verificar(string contrasena, string hashAlmacenado)
        {
            if (string.IsNullOrWhiteSpace(hashAlmacenado) || !hashAlmacenado.Contains("."))
                return false;

            string[] partes = hashAlmacenado.Split('.');
            byte[] sal = Convert.FromBase64String(partes[0]);
            byte[] hashEsperado = Convert.FromBase64String(partes[1]);

            byte[] hashCalculado = CalcularHash(contrasena, sal);

            return CompararEnTiempoConstante(hashEsperado, hashCalculado);
        }

        private static byte[] CalcularHash(string contrasena, byte[] sal)
        {
            using (var derivador = new Rfc2898DeriveBytes(contrasena, sal, Iteraciones, HashAlgorithmName.SHA256))
            {
                return derivador.GetBytes(TamanoHashBytes);
            }
        }

        private static bool CompararEnTiempoConstante(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            int diferencia = 0;
            for (int i = 0; i < a.Length; i++)
                diferencia |= a[i] ^ b[i];
            return diferencia == 0;
        }
    }
}
