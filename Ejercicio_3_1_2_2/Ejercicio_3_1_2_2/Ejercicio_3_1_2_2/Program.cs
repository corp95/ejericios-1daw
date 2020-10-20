using System;

namespace Ejercicio_3_1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num1;
            byte num2;
            ushort resultado;

            Console.WriteLine("Introduce un número.");
            num1 =Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Introduce un número.");
            num2 =Convert.ToByte(Console.ReadLine());

            resultado =(ushort) (num1 * num2);

            Console.WriteLine("El resultado es {0}", resultado);


        }
    }
}
