using System;

namespace Ejercicio_1_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double millasNauticas;
            double metros = 1852; //este no se modifica, es el equivalente de una milla nautica a metros
            double conversion; //conversión a metros

            Console.WriteLine("Introduce las millas nauticas a convertir:");
            millasNauticas = Convert.ToInt32(
                Console.ReadLine());
            conversion = millasNauticas * metros;

            Console.WriteLine("{0} millas nauticas son {1} metros", millasNauticas, conversion);
        }
    }
}
