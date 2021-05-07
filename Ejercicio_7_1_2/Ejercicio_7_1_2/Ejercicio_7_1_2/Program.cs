using System;

namespace Ejercicio_7_1_2
{
    class Program
    {
        public class Hardware
        {
            public void EscribirCentrado()
            {
                for (byte i = 0; i < 25; i++)
                    Console.Write(' ');
            }

            public void EscribirCentrado(int espacio)
            {
                for (byte i = 0; i<espacio; i++)
                    Console.Write(' ');
            }
        }
        public class Ejemplo_07_01b
        {
            public static void Main()
            {
                Console.WriteLine("Pulsa Intro para escribir centrado");
                Console.ReadLine();
                Hardware miPantalla = new Hardware();
                miPantalla.EscribirCentrado(50);
                Console.WriteLine("¡Centrado!");
            }
        }
    }
}
