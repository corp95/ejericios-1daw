using System;

namespace Ejercicio_2_1_9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dato1;

            Console.WriteLine("Introduce un carácter: ");
            dato1 = Convert.ToInt32(
                Console.ReadLine());

            if (dato1 == 0)
                Console.WriteLine("Es un número");
            else
            {
                if (dato1 == 1)
                    Console.WriteLine("Es un número");
                else
                    if (dato1 == 2)
                    Console.WriteLine("Es un número");
                else
                    if (dato1 == 3)
                    Console.WriteLine("Es un número");
                    

                
            }
        }
    }
}
