using System;

namespace Ejercicio_2_1_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduce un número: ");
            numero = Convert.ToInt32(
                Console.ReadLine());

            if (numero==1)

                Console.WriteLine("Uno");
            else
            {
                if (numero == 2)
                    Console.WriteLine("Dos");
                else
                    if (numero == 3)
                    Console.WriteLine("Tres");
                else
                    if (numero == 4)
                    Console.WriteLine("Cuatro");
                else
                    if (numero == 5)
                 Console.WriteLine("Cinco");

            }


            
        }
    }

}
