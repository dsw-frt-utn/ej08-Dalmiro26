using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            string resultado = code.Trim();

            resultado = resultado.ToUpper();

            resultado = resultado.Replace(" ", "-");

            return resultado;
        }
    }
}
