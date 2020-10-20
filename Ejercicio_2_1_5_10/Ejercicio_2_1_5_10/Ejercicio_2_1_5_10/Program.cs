using System;

namespace Ejercicio_2_1_5_10
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

            if (numero1 == numero2)
                Console.WriteLine("{0} y {1} son iguales.", numero1, numero2);
            else
                if (numero1 > numero2)
                Console.WriteLine("{0} es mayor que {1}.", numero1, numero2);
            else
                Console.WriteLine("{0} es mayor que {1}", numero2, numero1);
        }
    }
}
