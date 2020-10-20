using System;

namespace Ejercicio_2_2_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int num1=2; num1<=106; num1++)
            {

                if (num1 % 10 == 0)
                    continue;
                    Console.WriteLine("{0}", num1);



            }
        }
    }
}
