using System;

namespace Ejercicio_1_5_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = 20;
            b = 5;
            c = 6;
            d = (a + b) % c;

            Console.WriteLine("El resultado de " + "(" + a + "+" + b + ")%" + c + " es: " + d);
        }
    }
}
