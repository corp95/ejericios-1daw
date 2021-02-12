using System;

namespace Ejercicio_5_10_1
{
    class Program
    {

        static double Factorial(int n, int m)
        {
            if (n == 0)
                return 1;
            else if (m<0) {
            return Factorial(n, m+1) / n;
            
            } 
            else
            {
            return n * Factorial(n, m-1);
            
            }
            //return m * Factorial(m, n - 1);
        }
        static void Main(string[] args)
        {
            int num, pot;

            Console.WriteLine("Introduce un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce la potencia: ");
            pot = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} elevado a {1} es {2}", num, pot, Factorial(num, pot));
            
        }
    }
}
