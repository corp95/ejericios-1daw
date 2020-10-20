using System;

namespace Ejercicio_2_1_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine("Introduce un número: ");
            numero1 = Convert.ToInt32(
                Console.ReadLine());

            if ((numero1 % 2 == 0) && (numero1 % 2 == 1))
                Console.WriteLine("{0} es múltiplo de 2 y de 3", numero1); //no me saca esta frase
            
        }
    }
}
