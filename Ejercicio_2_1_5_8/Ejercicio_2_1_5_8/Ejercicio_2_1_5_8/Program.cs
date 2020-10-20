using System;

namespace Ejercicio_2_1_5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Introduce el primer número: ");
            numero1 = Convert.ToInt32(
                Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            numero2 = Convert.ToInt32(
                Console.ReadLine());

            if ((numero1 >= 0) && (numero2 >= 0))
                Console.WriteLine("{0} y {1} son positivos.", numero1, numero2);
            else
                if ((numero1 < 0) && (numero2 < 0))
                Console.WriteLine("{0} y {1} son negativos.", numero1, numero2);
            else
                Console.WriteLine("Al menos uno es negativo.");

        }
    }
}
