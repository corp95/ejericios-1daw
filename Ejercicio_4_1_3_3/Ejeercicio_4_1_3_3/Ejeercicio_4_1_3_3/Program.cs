using System;

namespace Ejeercicio_4_1_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[10];
            double media;
            double suma=0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce un número: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                suma = suma + numeros[i];
            }

            media = suma / 10;

            Console.WriteLine("La media de los números introducidos es: {0}", media);

            for (int i = 0; i < 10; i++)
            {
                if (media<numeros[i])
                {
                    Console.WriteLine("Los números {0} están por encima de la media.", numeros[i]);
                }
            }


        }
    }
}
