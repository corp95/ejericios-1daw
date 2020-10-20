using System;

namespace Ejercicio_2_2_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int min;

            Console.WriteLine("Introduce un número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            min = (num1 > num2 ? num2 : num1);

            for (int i = min; i>= 1;  i--)
            {
                if ((num1 % i == 0) && (num2 % i == 0))
                {
                    Console.WriteLine("El máximo común divisor es "+i);
                    break;
                }

            }
        }
    }
}
