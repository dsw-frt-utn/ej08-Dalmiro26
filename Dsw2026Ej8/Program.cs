namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema2 p = new Problema2();

            string etiqueta = p.CrearResumenVenta(342, "Zapatilla", 5, 190000.00m);
        
            Console.WriteLine(etiqueta);
        }
    }
}
