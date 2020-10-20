using System;

namespace Ejercicio_2_2_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumatorio=0;
            
            do
            {              
                sumatorio=sumatorio+1;
                Console.WriteLine("{0}", sumatorio);
                             
            }

            while (sumatorio < 10);
            Console.WriteLine("Fin.");
        }

    }
}
