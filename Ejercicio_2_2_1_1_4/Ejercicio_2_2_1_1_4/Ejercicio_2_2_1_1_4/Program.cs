using System;

namespace Ejercicio_2_2_1_1_3
{
    class Program
    {

        static void Main(string[] args)
        {
            int resultado = -1;
            int num1, num2;

            while (resultado != 0)
            {
                Console.WriteLine("Introduce el primer número: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduce el segundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 % num2 == 0)

                    Console.WriteLine("{0} es múltiplo de {1}", num1, num2);
                else
                    if (num2 % num1 == 0)
                    Console.WriteLine("{0} es múltiplo de {1}", num2, num1);
                else
                    Console.WriteLine("{0} y {1} no son múltiplos.", num1, num2);
            }
        }
    }
}

