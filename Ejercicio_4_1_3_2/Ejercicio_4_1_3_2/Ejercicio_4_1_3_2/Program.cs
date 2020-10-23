using System;

namespace Ejercicio_4_1_3_2
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] numeros;
            int numeroUsuario;
            double suma=0;
            double media;

            Console.WriteLine("¿Cuántos números enteros quieres introducir? ");
            numeroUsuario = Convert.ToInt32(Console.ReadLine());

            numeros = new int[numeroUsuario];

            for (int contador=0; contador<numeroUsuario; contador++) //Este es el contador.
            {
                Console.WriteLine("Introduce un número: ");
                numeros[contador] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i=0; i<numeroUsuario; i++)
                suma = suma + numeros[i];

                media = suma / numeroUsuario;
                Console.WriteLine("La media de los números enteros introducidos es: {0}", media);
            

        }
    }
}
