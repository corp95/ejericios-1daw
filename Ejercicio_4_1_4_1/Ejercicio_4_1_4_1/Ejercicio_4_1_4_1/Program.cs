using System;

namespace Ejercicio_4_1_4_1
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] datos = { 1, 10, 15, 91, 0 };
            //int capacidad = 5;
            int cantidad = 4;
            int buscar;

            for (int i=0; i<cantidad; i++)
            {
                Console.Write(" {0} ", datos[i]);
                Console.WriteLine();
            }

            for (int i=0; i<cantidad; i++)
            {
                Console.WriteLine("Introduce el dato a buscar: ");
                buscar = Convert.ToInt32(Console.ReadLine());

                switch (datos[i])
                {
                    case 1: Console.WriteLine("El número {0} está en la lista.", buscar);
                        break;

                    case 10:
                        Console.WriteLine("El número {0} está en la lista.", buscar);
                        break;

                    case 15:
                        Console.WriteLine("El número {0} está en la lista.", buscar);
                        break;

                    case 91:
                        Console.WriteLine("El número {0} está en la lista.", buscar);
                        break;

                    default: Console.WriteLine("El número introducido no está en la lista.");
                        break;

                }
               /* if (buscar == datos[i])
                    Console.WriteLine("Número {0} encontrado", buscar);
                break;*/
            }

        }
    }
}
