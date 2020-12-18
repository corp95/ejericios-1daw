using System;

namespace Ejercicio_5_3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int alto;
            int ancho;

            Console.WriteLine("Introduce el alto: ");
            alto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            DibujarCuadrado(alto, ancho);

        }

        public static void DibujarCuadrado(int x, int y)
        {
            Console.WriteLine();

            for(int i=0; i<x; i++) //Alto
            {                               
                for (int j=0; j<y; j++) //Ancho
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
