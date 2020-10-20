using System;

namespace Ejercicio_2_2_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int num=20; num>=10; num--)
            {
                if (num == 13)
                    continue;

                Console.WriteLine("{0}", num);

            }
        }
    }
}
