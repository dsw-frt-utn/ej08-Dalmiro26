namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper p = new ProductHelper();

            string etiqueta = p.ObtenerEtiquetaProducto(342, "Zapatilla", 190000.00m);
        
            Console.WriteLine(etiqueta);
        }
    }
}
