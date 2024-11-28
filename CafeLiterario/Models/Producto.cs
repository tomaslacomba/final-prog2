namespace CafeLiterario.Models
{
    public class Producto
    {
        public string Nombre { get; private set; }
        public string Categoria { get; private set; }
        public decimal Precio { get; private set; }
        public int Cantidad { get; private set; }

        public Producto(string nombre, string categoria, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}