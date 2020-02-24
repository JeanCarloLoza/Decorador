using System;

namespace Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            GuardadorCXP servicio = new GuardadorCXPSimple();
            GuardadorCXP servicio2 = new GuardadorCXPHistorial();
            GuardadorCXP servicio3 = new GuardadorCXPCorreo();
            GuardadorCXP servicio4 = new GuardadorCXPHistorialCorreo();

            Console.WriteLine("Original");
            servicio.Guardar(1,100,"afecta");
            Console.WriteLine("\nModificacion 1");
            servicio2.Guardar(2, 200, "devenga");
            Console.WriteLine("\nModificacion 2");
            servicio3.Guardar(3, 300, "compromete");
            Console.WriteLine("\nModificacion 3");
            servicio4.Guardar(4, 400, "afecta");
        }
    }
}
