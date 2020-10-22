using System;

namespace Ejercicio_4_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[4];
            double suma;
            double division;
            

            Console.WriteLine("Introduce el primer número: ");
            numeros[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número: ");
            numeros[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número: ");
            numeros[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el cuarto número: ");
            numeros[3] = Convert.ToDouble(Console.ReadLine());

            suma = numeros[0] + numeros[1] + numeros[2] + numeros[3];
            division = suma / 4;

            Console.WriteLine("El resultado es {0}", division);

        }
    }
}
