using System;

namespace Ejercicio_1_5_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            a = 15;
            b = -5;
            c = 6;
            d = 10;
            e = a + b * c / d;

            Console.WriteLine("El resultado de " + a + "+" + b + "*" + c + "/" + d + " es: " + e);
        }
    }
}
