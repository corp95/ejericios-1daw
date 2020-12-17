using System;

namespace Ejercicio_5_2_1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Pulsa intro para borrar pantalla.");
            Console.ReadLine();

            BorrarPantalla();
        }
        public static void BorrarPantalla()
        {
            // Se puede hacer con un Console.Clear(); y es mejor. Hay que intentar usar herramientas del sistema.
            for (int i = 0; i < 25; i++)
                Console.WriteLine();
        }

    }
}
