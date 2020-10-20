using System;

namespace Ejercicio_2_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int anyo; //Es el año

            try
            {
                Console.WriteLine("Introduce tu edad: ");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduce el año de nacimiento: ");
                anyo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pulsa cualquier botón para salir.");
            }
            catch (FormatException)
            {
                Console.WriteLine("El número introducido no es válido."); 
            }
        }
    }
}
