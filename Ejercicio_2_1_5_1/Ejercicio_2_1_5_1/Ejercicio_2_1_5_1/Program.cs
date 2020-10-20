using System;

namespace Ejercicio_2_1_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine("Introduce el primer número: ");
                numero1 = Convert.ToInt32(
                    Console.ReadLine());


            if (numero1 % 2 == 0)
                Console.WriteLine("{0} es múltiplo de 2", numero1);

            else
                Console.WriteLine("{0} es múltiplo de 3", numero1);


        }
    }
}
