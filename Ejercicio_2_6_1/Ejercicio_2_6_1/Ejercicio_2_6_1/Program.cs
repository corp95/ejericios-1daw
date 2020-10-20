using System;

namespace Ejercicio_2_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 75; //Este es el número "aleatorio" 
            int numUsuario; //Número introducido por el usuario


            Console.WriteLine("¡Adivina! Sólo tienes 6 oportunidades.");

            for (int intentos = 1; intentos <= 6; intentos++)
            {
                Console.WriteLine("Introduce un número aleatorio del 1 al 100: ");
                numUsuario = (Convert.ToInt32(Console.ReadLine()));

                if (numUsuario != num)
                {
                    Console.WriteLine("Número incorrecto. Inténtalo de nuevo.");
                    if (numUsuario < num)
                        Console.WriteLine("¡El número es más grande!");
                    else
                        Console.WriteLine("¡El número es más pequeño!");
                }

                else
                {
                    Console.WriteLine("¡Número correcto!");
                    break;
                }
            }
   
        }
    }
}
