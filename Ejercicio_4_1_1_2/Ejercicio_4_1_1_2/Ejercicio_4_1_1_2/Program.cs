using System;

namespace Ejercicio_4_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[5];

            Console.WriteLine("Introduce el primero número: ");
            numeros[0] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número: ");
            numeros[1] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Introduce el tercero número: ");
            numeros[2] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Introduce el cuarto número: ");
            numeros[3] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Introduce el quinto número: ");
            numeros[4] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", numeros[4], numeros[3], numeros[2], numeros[1], numeros[0]);
        }
    }
}
