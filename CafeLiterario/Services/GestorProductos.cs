using System.Collections.Generic;
using System.Linq;
using CafeLiterario.Models;

namespace CafeLiterario.Services
{
    public class GestorProductos
    {
        private readonly List<Producto> productos;

        public GestorProductos()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> CargarProductos()
        {
            return new List<Producto>(productos);
        }

        public List<Producto> CargarProductosPorCategoria(string categoria)
        {
            return productos.Where(p => p.Categoria == categoria).ToList();
        }

        public void ActualizarProducto(Producto producto)
        {
            var index = productos.FindIndex(p => p.Nombre == producto.Nombre);
            if (index != -1)
            {
                productos[index] = producto;
            }
        }

        public void EliminarProducto(string nombre)
        {
            productos.RemoveAll(p => p.Nombre == nombre);
        }
    }
}