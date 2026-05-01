using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class WholesaleSale : Sale
    {
        public WholesaleSale(decimal importe) : base(importe)
        {
        }
        public decimal GetWholesaleImporte()
        {
            return GetImporte();
        }
        public void SetWholesaleImporte(decimal importe)
        {
            SetImporte(importe);
        }
        public override decimal CalculoTotal()
        {
            return GetImporte() * 0.9m;
        }
    }
}
