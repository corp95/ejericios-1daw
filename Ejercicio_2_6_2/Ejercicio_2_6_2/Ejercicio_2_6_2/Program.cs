using System;

namespace Ejercicio_2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int contador = 2;

            Console.WriteLine("Introduce un número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            for (contador=2; contador <=num1; contador++)
            {
                if (num1%contador==0)
                {
                    Console.WriteLine("{0} ", contador);

                    num1 = num1 / contador;

                    contador = 1;
                }
            }
            
        }
    }
}
