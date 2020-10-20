using System;

namespace Ejercicio_2_1_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Introduce un número: ");
            numero1 = Convert.ToInt32(
                Console.ReadLine());
            Console.WriteLine("Introduce otro número: ");
            numero2 = Convert.ToInt32(
                Console.ReadLine());

            if ((numero1 % 2 == 0) || (numero2 % 2 == 0))
                Console.WriteLine("Al menos uno de los dos números es par.");
            else
                Console.WriteLine("Pulsa cualquier botón para salir.");


        }
    }
}
