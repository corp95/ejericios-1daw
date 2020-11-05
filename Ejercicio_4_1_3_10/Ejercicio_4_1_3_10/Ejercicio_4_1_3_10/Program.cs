using System;

namespace Ejercicio_4_1_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vector1 = new double[3];
            double[] vector2 = new double[3];
            double resultado=0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduce tres números: ");
                vector1[i] = Convert.ToDouble(Console.ReadLine());
            }



            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduce otros tres números más: ");
                vector2[i] = Convert.ToDouble(Console.ReadLine());
            }

            resultado = (vector1[0] * vector2[0] + vector1[1] * vector1[1] + vector1[2] * vector2[2]);

            Console.WriteLine("El resultado es {0}", resultado);
        }
    }
}
