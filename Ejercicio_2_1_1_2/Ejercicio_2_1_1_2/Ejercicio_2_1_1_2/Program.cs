using System;

namespace Ejercicio_2_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;

            Console.WriteLine("Introduce el primer número entero: ");
            primerNumero = Convert.ToInt32(
                Console.ReadLine());
            Console.WriteLine("Introduce el segundo número entero: ");
            segundoNumero = Convert.ToInt32(
                Console.ReadLine());

            if (primerNumero > segundoNumero)
                Console.WriteLine(primerNumero + " es mayor que " + segundoNumero);
            else Console.WriteLine(segundoNumero + " es mayor que " + primerNumero);
        }
    }
}
