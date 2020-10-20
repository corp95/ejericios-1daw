using System;

namespace Ejercicio_3_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte edad;

            Console.WriteLine("¿Cuántos años tienes?");
            edad = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Eh, no aparentas tener {0} años.", edad);
        }
    }
}
