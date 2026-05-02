namespace Dsw2026Ej8
{
    public class Product
    {
        string _description;

        public Product()
        {

        }

        public void SetDescripcion (string description)
        {
            _description = description;
        }

        public string GetDescripcion()
        {
            return _description;
        }
    }
}