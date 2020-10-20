using System;

namespace Ejercicio_3_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1;
            long num2;
            long suma;
            long resta;
            long producto;

            Console.WriteLine("Introduce el primer número");
            num1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");
            num2 = Convert.ToInt64(Console.ReadLine());

            suma = num1 + num2;
            resta = num1 - num2;
            producto = num1 * num2;

            Console.WriteLine("La suma de {0} y {1} es: {2}. Su resta es {3} y su producto es {4}", num1, num2, suma, resta, producto);

        }
    }
}
