using System;

namespace Ejercicio_2_1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos;

            Console.WriteLine("Introduce el primer número entero: ");
            numeroUno = Convert.ToInt32(
            Console.ReadLine());
            Console.WriteLine("Introduce el segundo número entero: ");
            numeroDos = Convert.ToInt32(
                Console.ReadLine());

            if (numeroUno % numeroDos == 0) Console.WriteLine(numeroUno + " es múltiplo de " + numeroDos);
        }
    }
}
