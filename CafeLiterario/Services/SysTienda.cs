using CafeLiterario.Models;

namespace CafeLiterario.Services
{
    public class SysTienda
    {
        private readonly GestorProductos gestor;
        private readonly List<string> categorias;

        public SysTienda()
        {
            gestor = new GestorProductos();
            categorias = new List<string> { "Libro", "Café", "Postre" };
        }

        private string SeleccionarCategoria()
        {
            Console.WriteLine("Seleccione una categoría:");
            for (int i = 0; i < categorias.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categorias[i]}");
            }

            int seleccion;
            while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > categorias.Count)
            {
                Console.WriteLine("Selección inválida. Intente nuevamente.");
            }

            return categorias[seleccion - 1];
        }

        public void AgregarProducto()
        {
            Console.Write("Nombre: ");
            var nombre = Console.ReadLine();
            var categoria = SeleccionarCategoria();
            Console.Write("Precio: ");
            var precio = decimal.Parse(Console.ReadLine());
            Console.Write("Cantidad: ");
            var cantidad = int.Parse(Console.ReadLine());

            GestorProductos gestor1 = gestor;
            gestor1.AgregarProducto(new Producto(nombre, categoria, precio, cantidad));
            Console.WriteLine("Producto agregado exitosamente.");
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Libro");
            Console.WriteLine("2. Café");
            Console.WriteLine("3. Postre");
            Console.WriteLine("4. Mostrar todo el inventario");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
            {
                Console.WriteLine("Seleccion invalida. Intente nuevamente.");
            }

            List<Producto> productos;
            if (opcion == 4)
            {
                productos = gestor.CargarProductos();
            }
            else
            {
                var categoria = categorias[opcion - 1];
                productos = gestor.CargarProductosPorCategoria(categoria);
            }

            if (productos.Count == 0)
            {
                Console.WriteLine("\nNo hay productos disponibles en esta categoría.");
                return;
            }

            Console.WriteLine("\nInventario:");
            Console.WriteLine("Categoría  | Nombre              | Precio   | Cantidad");
            Console.WriteLine("-----------------------------------------------------");
            foreach (var producto in productos)
            {
                Console.WriteLine($"{producto.Categoria,-10} | {producto.Nombre,-17} | {producto.Precio,8:C} | {producto.Cantidad,8}");
            }
        }

        public void ActualizarProducto()
        {
            Console.Write("Nombre del producto a actualizar: ");
            var nombre = Console.ReadLine();
            var categoria = SeleccionarCategoria();
            Console.Write("Nuevo precio: ");
            var precio = decimal.Parse(Console.ReadLine());
            Console.Write("Nueva cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());

            gestor.ActualizarProducto(new Producto(nombre, categoria, precio, cantidad));
            Console.WriteLine("Producto actualizado exitosamente.");
        }

        public void EliminarProducto()
        {
            var categoria = SeleccionarCategoria();
            var productos = gestor.CargarProductosPorCategoria(categoria);

            if (productos.Count == 0)
            {
                Console.WriteLine($"\nNo hay productos en la categoría {categoria}.");
                return;
            }

            Console.WriteLine($"\nProductos en la categoría {categoria}:");
            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {productos[i].Nombre} | {productos[i].Precio:C} | {productos[i].Cantidad} unidades");
            }

            Console.Write("Seleccione el número del producto a eliminar: ");
            int seleccion;
            while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > productos.Count)
            {
                Console.WriteLine("Selección inválida. Intente nuevamente.");
            }

            var productoAEliminar = productos[seleccion - 1];
            gestor.EliminarProducto(productoAEliminar.Nombre);
            Console.WriteLine($"Producto '{productoAEliminar.Nombre}' eliminado exitosamente.");
        }
    }
}