namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema6 p = new Problema6();

            string resultado = p.NormalizarCodigoProducto("HsY 98 Mf4d2");

            Console.WriteLine(resultado);
        }
    }
}
