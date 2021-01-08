using System;

namespace Ejercicio_5_4_2
{
    class Program
    {       
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Introduce un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El menor es: {0}",Menor(n1, n2));

        }

        static int Menor(int n1, int n2)
        {
            Console.WriteLine(" ");

            if (n1 < n2)
                return n1;
            else
                return n2;

        }

    }
}
