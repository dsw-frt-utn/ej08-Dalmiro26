using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Sale
    {
        private decimal _importe;

        public Sale(decimal importe)
        {
            _importe = importe;
        }

        public void SetImporte(decimal valor)
        {
            _importe = valor;
        }

        public decimal GetImporte()
        {
            return _importe;
        }

        public virtual decimal CalculoTotal()
        {
            return _importe;
        }
    }
}
