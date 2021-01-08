using System;

namespace Ejercicio_5_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Introduce un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Signo(num));

        }

        static int Signo(int num)
        {
            Console.WriteLine("");

            if (num == 0)
                return 0;
            else
                if (num > 0)
                return 1;
            else
                return -1;
         
        }
    }
}
