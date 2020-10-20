using System;

namespace Ejercicio_2_2_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("Introduce el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            for (numero1 = 0; numero1 <= numero2; numero1++)
            {

                if (numero1 % 2 == 0)
                {
                    Console.WriteLine("Divisores comunes: {0}", numero1);

                }

            }



        }
    }
}
