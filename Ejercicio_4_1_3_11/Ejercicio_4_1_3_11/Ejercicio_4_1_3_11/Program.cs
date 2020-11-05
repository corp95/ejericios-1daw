using System;

namespace Ejercicio_4_1_3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numero = new double[4];
            double valor = 0;
            
            for (int i=0; i<4; i++)
            { 
                Console.WriteLine("Introduce un número: ");
                numero[i] = Convert.ToDouble(Console.ReadLine());

                if (valor < numero[i])
                {
                    valor = numero[i];
                }
            }
            
            Console.WriteLine("El mayor de los dos números es {0}", valor);
        }
    }
}
