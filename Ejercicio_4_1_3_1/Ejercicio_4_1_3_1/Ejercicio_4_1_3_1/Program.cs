using System;

namespace Ejercicio_4_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] numero = new short[6];

            Console.WriteLine("Introduce el primer número: ");
            numero[0] = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número: ");
            numero[1] = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número: ");
            numero[2] = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Introduce el cuarto número: ");
            numero[3] = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Introduce el quinto número: ");
            numero[4] = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Introduce el sexto número: ");
            numero[5] = Convert.ToInt16(Console.ReadLine());

            for (int i = 5; i >= 0; i--)
                Console.Write("{0}", numero[i]);
        }
    }
}
