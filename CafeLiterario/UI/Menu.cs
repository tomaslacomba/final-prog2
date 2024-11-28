using CafeLiterario.Services;
using System;


namespace CafeLiterario.UI

public class Menu
{
    private readonly SysTienda sysTienda;
    private object mensaje;

    public Menu() => sysTienda = new SysTienda();

    public void MostrarMenu()
    {
        while (true)
        {
            Console.Clear();

            Logo.Show();

            MostrarMensaje("\nCafe Literario - Gestion de Inventario", ConsoleColor.DarkCyan);
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Mostrar Inventario");
            Console.WriteLine("3. Actualizar Producto");
            Console.WriteLine("4. Eliminar Producto");
            Console.WriteLine("5. Salir");
            Console.Write("\nSelecciona una opcion: ");
            var opcion = Console.ReadLine();

            switch ()
            {
                case "1":
                    sysTienda.AgregarProducto();
                    MostrarMensaje("Producto agregado exitosamente.", ConsoleColor.Green);
                    break;
                case "2":
                    sysTienda.MostrarInventario();
                    break;
                case "3":
                    sysTienda.ActualizarProducto();
                    MostrarMensaje("Producto actualizado exitosamente.", ConsoleColor.Green);
                    break;
                case "4":
                    sysTienda.EliminarProducto();
                    MostrarMensaje("Producto eliminado exitosamente.", ConsoleColor.Green);
                    break;
                case "5":
                    MostrarMensaje("Saliendo del sistema. ¡Hasta luego!", ConsoleColor.Yellow);
                    return;
                default:
                    MostrarMensaje("Opción no valida.", ConsoleColor.Red);
                    break;
            }

            MostrarMensaje("\nPresiona cualquier tecla para volver al menu...", ConsoleColor.Yellow);
            Console.ReadKey();
        }
    }

    private void MostrarMensaje(string v, ConsoleColor yellow)
    {
        throw new NotImplementedException();
    }

    private void MostrarMensaje(mensaje, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"\n{mensaje}");
        Console.ResetColor();
    }
}
