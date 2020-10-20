using System;

namespace Ejercicio_2_1_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            
            Console.WriteLine("Introduce el primer número: ");
            numero1 = Convert.ToInt32(
                Console.ReadLine());

            numero1 = numero1 >= 0 ? numero1 : numero1 * -1;
            Console.WriteLine("{0}", numero1);

            
        }
    }
}
