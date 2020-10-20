using System;

namespace Ejercicio_2_1_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;

            Console.WriteLine("El primer número: ");
            numero1 = Convert.ToInt32(
                Console.ReadLine());
            Console.WriteLine("Introduce el segundo: ");
            numero2 = Convert.ToInt32(
                Console.ReadLine());
            Console.WriteLine("Introduce el tercero: ");
            numero3 = Convert.ToInt32(
                Console.ReadLine());

            if (numero1 > numero2) 
                Console.WriteLine("{0} es el mayor de los tres.", numero1);
            else
            {
                if (numero3 > numero1)
                    Console.WriteLine("{0} es el mayor de los tres.", numero3);
                else
                {
                    if (numero2>numero3)
                        Console.WriteLine("{0} es el mayor de los tres.", numero2);
                }
            }
        }
    }
}
