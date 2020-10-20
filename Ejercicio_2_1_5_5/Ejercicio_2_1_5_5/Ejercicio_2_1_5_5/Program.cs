using System;

namespace Ejercicio_2_1_5_5
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

            if ((numero1 % 2 == 0) && (numero2 % 2 == 0))
                Console.WriteLine("{0} y {1} son pares.", numero1, numero2);
            else
                Console.WriteLine("Uno de los dos números no es par.");
        }
    }
}
