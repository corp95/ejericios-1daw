using System;

namespace Ejercicio_2_2_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pass=-1;

           

            while (pass!=1111)
            {
                Console.WriteLine("Introduce una contraseña: ");
                pass = Convert.ToInt32(Console.ReadLine());

                if (pass == 1111)
                    Console.WriteLine("Contraseña correcta.");
                
                else                   
                    Console.WriteLine("Contraseña incorrecta, inténtelo de nuevo.");
                
            }



        }
    }
}
