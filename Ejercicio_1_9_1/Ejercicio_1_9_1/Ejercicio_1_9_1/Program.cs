using System;

namespace Ejercicio_1_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primernumero;
            int segundonumero;
            int producto;

            Console.WriteLine("Introduce el primer número");
            primernumero = Convert.ToInt32(
                Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            segundonumero = Convert.ToInt32(
                Console.ReadLine());
            producto = primernumero * segundonumero;

            Console.WriteLine("El resultado de {0} * {1} es {2}", primernumero, segundonumero, producto);
        }
    }
}
