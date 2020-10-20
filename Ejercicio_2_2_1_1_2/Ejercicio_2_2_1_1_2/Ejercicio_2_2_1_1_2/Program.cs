using System;

namespace Ejercicio_2_2_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = -1;
            int resultado;
                 
            while (num!=0)
            {
                Console.WriteLine("Introduce un número: ");
                num = Convert.ToInt32(Console.ReadLine());

                resultado = num * num;
                Console.WriteLine("El cuadrado de {0} es {1}", num, resultado);

                
                
            }

        }
    }
}
