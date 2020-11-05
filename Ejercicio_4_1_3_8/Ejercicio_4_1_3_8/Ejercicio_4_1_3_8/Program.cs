using System;

namespace Ejercicio_4_1_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[3];
            double resultado;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduce tres números: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            resultado = Math.Sqrt((numeros[0] * numeros[0]) + (numeros[1]) * (numeros[1]) + (numeros[2] * numeros[2]));

            Console.WriteLine("{0}", resultado);
           
            
        }
    }
}
