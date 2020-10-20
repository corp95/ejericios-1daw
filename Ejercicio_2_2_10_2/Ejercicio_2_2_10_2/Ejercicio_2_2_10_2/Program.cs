using System;

namespace Ejercicio_2_2_10_2 //no se si va
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int multiplo;

            Console.WriteLine("Introduce el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            multiplo = (num1 > num2 ? num2 : num1);

            for(int i=multiplo; i>=1; i++)
            {
                if ((num1%i==0)&&(num2%i==0))
                {
                    Console.WriteLine("El resultado es:{0}",
                        i);
                    break;

                }


            }
        }
    }
}
