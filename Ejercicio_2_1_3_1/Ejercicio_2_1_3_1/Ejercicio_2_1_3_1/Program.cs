using System;

namespace Ejercicio_2_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;

            Console.WriteLine("Introduce un número: ");
            numero1 = Convert.ToInt32(
                Console.ReadLine());
            if (numero1 == 0)
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            
            else Console.WriteLine("Introduce otro número: ");
            numero2 = Convert.ToInt32(
                Console.ReadLine());
            resultado = numero1 * numero2;

            Console.WriteLine("{0} * {1} es {2}", numero1, numero2, resultado);

        }
    }
}
