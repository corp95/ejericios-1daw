using System;

namespace Ejercicio_2_1_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, mayor;

            Console.WriteLine("Inserte el primer número: ");
            num1 = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine("Inserte el segundo número: ");
            num2 = Convert.ToInt32(
                Console.ReadLine());

            mayor=num1>num2 ? num1: num2;

            Console.WriteLine("El mayor de los dos números es {0}", mayor);
        }
    }
}
