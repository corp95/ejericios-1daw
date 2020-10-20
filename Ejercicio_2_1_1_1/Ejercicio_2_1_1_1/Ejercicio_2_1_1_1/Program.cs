using System;

namespace Ejercicio_2_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduce un número entero: ");
            numero = Convert.ToInt32(
                Console.ReadLine());

            if (numero % 2 == 0) Console.WriteLine("El número es par.");

            }
    }
}
