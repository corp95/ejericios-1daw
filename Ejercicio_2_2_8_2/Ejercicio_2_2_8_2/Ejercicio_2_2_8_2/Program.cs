using System;

namespace Ejercicio_2_2_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho, alto;

            Console.WriteLine("Introduce el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el alto: ");
            alto = Convert.ToInt32(Console.ReadLine());

            for (int filaActual=1; filaActual<=alto; filaActual++)
            {
                for (int columnaActual = 1; columnaActual<=ancho; columnaActual++)
                {
                    
                    

                    Console.Write("*");

                }

                Console.WriteLine();

            }

        }
    }
}
