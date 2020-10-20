using System;

namespace Ejercicio_2_1_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine("Introduce un número: ");
            numero1 = Convert.ToInt32(
                Console.ReadLine());

            if (!(numero1 % 2 == 0)&&(numero1 % 3 == 1))
                Console.WriteLine("{0} no es múltiplo ni de dos ni de tres", numero1);
            else
                Console.WriteLine("Pulsa cualquier botón para salir.");

        }
    }
}
