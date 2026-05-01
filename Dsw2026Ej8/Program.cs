namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema5 p = new Problema5();

            RetailSale retailSale = new RetailSale(100);

            WholesaleSale wholesaleSale = new WholesaleSale(80);

            Console.WriteLine(p.ObtenerImporteFinal(retailSale));
            Console.WriteLine(p.ObtenerImporteFinal(wholesaleSale));
        }
    }
}
