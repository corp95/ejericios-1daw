using System;

namespace Ejercicio_2_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int anyo; //es el año

            try
            {
                Console.WriteLine("Introduce tu edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("El número introducido no es válido.");
                
            }
            try
            {
                Console.WriteLine("Introduce tu año de nacimiento: ");
                anyo = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("El número introducido no es válido.");
            }
        }
    }
}
