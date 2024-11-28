namespace CafeLiterario.UI
{
    public class Logo
    {
        public static void Show(ConsoleColor? color = null)
        {
            Console.ForegroundColor = color ?? ConsoleColor.Cyan;

            Console.WriteLine("\t██╗   ██╗████████╗███╗   ██╗");
            Console.WriteLine("\t██║   ██║╚══██╔══╝████╗  ██║");
            Console.WriteLine("\t██║   ██║   ██║   ██╔██╗ ██║");
            Console.WriteLine("\t██║   ██║   ██║   ██║╚██╗██║");
            Console.WriteLine("\t╚██████╔╝   ██║   ██║ ╚████║");
            Console.WriteLine("\t ╚═════╝    ╚═╝   ╚═╝  ╚═══╝");
            Console.ResetColor(); 

            Console.WriteLine("###   CAFÉ LITERARIO - GESTIÓN DE INVENTARIO   ###"); 
        }
    }
}
