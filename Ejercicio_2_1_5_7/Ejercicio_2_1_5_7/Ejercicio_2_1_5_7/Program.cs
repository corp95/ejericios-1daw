using System;

namespace Ejercicio_2_1_5_7
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
                Console.WriteLine("Hay un número que es par.");
            else
                Console.WriteLine("Pulsa cualquier tecla para salir.");
        }
    }
}
