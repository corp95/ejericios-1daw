using System;
using System.Numerics;

namespace Ejercicio_4_1_3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vector1 = new double[3];
            double[] vector2 = new double[3];
            double suma1=0;
            double suma2 = 0;
            double suma3 = 0;
            double sumatotal;

            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Introduce tres números: ");
                vector1[i] = Convert.ToDouble(Console.ReadLine());
            }

            

            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Introduce otros tres números más: ");
                vector2[i] = Convert.ToDouble(Console.ReadLine());
            }

            suma1 = vector1[0] + vector2[0];
            suma2 = vector1[1] + vector2[1];
            suma3 = vector1[2] + vector2[2];
            sumatotal = suma1 + suma2 + suma3;

            Console.WriteLine("Las sumas de manera individual son: {0}, {1}, {2}. El total es: {3}", suma1, suma2, suma3, sumatotal);

        }
    }
}
