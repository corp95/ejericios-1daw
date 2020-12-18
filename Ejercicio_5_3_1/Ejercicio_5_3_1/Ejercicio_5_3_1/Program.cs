using System;

namespace Ejercicio_5_3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int lado;

            Console.WriteLine("Introduce el lado del cuadrado: ");
            lado = Convert.ToInt32(Console.ReadLine());


            DibujarCuadrado(lado);

        }

        public static void DibujarCuadrado(int x)
        {
            Console.WriteLine();

            for(int i=0; i<x; i++) 
            {                               
                for (int j=0; j<x; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
