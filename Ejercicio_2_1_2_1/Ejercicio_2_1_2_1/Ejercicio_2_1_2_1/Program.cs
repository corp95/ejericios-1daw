using System;

namespace Ejercicio_2_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;

            Console.WriteLine("Introduce el primer número: ");
            primerNumero = Convert.ToInt32(
                Console.ReadLine());

            if (primerNumero % 10 == 0)
            {
                Console.WriteLine("{0} es múltiplo de 10 \n", primerNumero);
                Console.WriteLine("Introduce el segundo número: ");
                segundoNumero = Convert.ToInt32(
                    Console.ReadLine());
                if (segundoNumero % 10 == 0)
                    Console.WriteLine("{0} es múltiplo de 10", segundoNumero);

            }   
        }
    }
}
