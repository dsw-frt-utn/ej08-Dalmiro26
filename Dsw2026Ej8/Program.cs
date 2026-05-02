namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema3 p = new Problema3();
            Product producto = new Product();   

            producto.SetDescripcion("Primera descripcion");
            string resultado = p.CompararCopias(2, producto);

            Console.WriteLine(resultado);
        }
    }
}
