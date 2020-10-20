using System;

namespace Ejercicio_1_5_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g;
            a = 2;
            b = 10;
            c = 5;
            d = 2;
            e = 7;
            f = 1;
            g = a + b / c * d - e % f;
            
            Console.WriteLine("El resultado de " + a + "+" + b + "/" + c + "*" + d + "-" + e + "%" + f + " es: " + g /n);
        }
    }
}
