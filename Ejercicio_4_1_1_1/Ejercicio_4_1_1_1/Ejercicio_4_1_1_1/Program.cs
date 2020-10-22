using System;

namespace Ejercicio_4_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            int suma;
            int division;
            

            Console.WriteLine("Introduce el primer número: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número: ");
            numeros[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número: ");
            numeros[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el cuarto número: ");
            numeros[3] = Convert.ToInt32(Console.ReadLine());

            suma = numeros[0] + numeros[1] + numeros[2] + numeros[3];
            division = suma / 4;

            Console.WriteLine("El resultado es {0}", division);

        }
    }
}
