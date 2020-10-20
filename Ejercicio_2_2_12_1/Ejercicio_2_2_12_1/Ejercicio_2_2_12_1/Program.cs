using System;

namespace Ejercicio_2_2_12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num2 = 100;

            for (int num1 = 100; num1 <= 200; num1++)
            {
                Console.Write(" {0} ", num1);
            }

            Console.WriteLine();

            while (num2<=200)
            {

                if (num2 == 100)
                {
                    continue;

                    //no está terminado, revisar, la parte del for funciona, la parte del while no

                    Console.Write(" {0} ", num2);
                    num2++;
                }
                
            }
                       
                        
        }
    }
}
