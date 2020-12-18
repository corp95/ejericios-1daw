using System;

namespace Ejercicio_5_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho;
            int alto;

            Console.WriteLine("Introduce el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el alto: ");
            alto = Convert.ToInt32(Console.ReadLine());

            DibujarRectangulo(alto, ancho);
        }

        public static void DibujarRectangulo(int x, int y)
        {
            Console.WriteLine();

            for(int i=0; i<x; i++)
            {
                for(int j=0; j<y; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
