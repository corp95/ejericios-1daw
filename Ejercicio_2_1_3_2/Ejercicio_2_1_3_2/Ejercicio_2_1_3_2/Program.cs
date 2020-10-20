using System;

namespace Ejercicio_2_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;

            Console.WriteLine("Introduce el primer número: ");
            numero1 = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine("Introduce el segundo: ");
            numero2 = Convert.ToInt32(
                Console.ReadLine());


            if (numero2 != 0)
            {
                resultado = numero1 / numero2;
                Console.WriteLine("{0} / {1} es igual a {2}", numero1, numero2, resultado);
            }

            else
                Console.WriteLine("Error: No se puede dividir entre 0"); 
        }
    }
}
