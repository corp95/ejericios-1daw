using System;

namespace Ejercicio_3_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=15;
            int y=-10;
            int z=2147483647;
            int a, b, c;

            a = x++;
            b = y++;
            c = z++;


            Console.WriteLine("{0} {1} {2}",a,b,c);
        }
    }
}
