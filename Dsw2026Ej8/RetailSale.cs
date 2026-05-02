using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class RetailSale : Sale
    {

        public RetailSale(decimal importe) : base(importe)
        {
            
        }

        public decimal GetRetailImporte()
        {
            return GetImporte();
        }

        public void SetRetailImporte(decimal importe)
        {
            SetImporte(importe);
        }
        public override decimal CalculoTotal()
        {
            return GetImporte();
        }
    }
}
