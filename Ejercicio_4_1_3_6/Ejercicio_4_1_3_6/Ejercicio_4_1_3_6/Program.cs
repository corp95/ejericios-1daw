using System;

namespace Ejercicio_4_1_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            string nombrePropio; //Tu nombre, o el que quiera introducir el usuario para comparar.
            int veces = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce un nombre: ");
                nombres[i] = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("Introduce un nombre para comprobar si se encuentra en la lista (introduce FIN para salir del programa): ");
            nombrePropio = Convert.ToString(Console.ReadLine());

            while (nombrePropio!="FIN")
            {              

                for (int i = 0; i < 10; i++)
                {
                    if (nombrePropio == nombres[i])
                        veces++;
                }
                Console.WriteLine("Introduce un nombre para comprobar si se encuentra en la lista (introduce FIN para salir del programa): ");
                nombrePropio = Convert.ToString(Console.ReadLine());
            }
            
            if (veces > 0)
            {
                Console.WriteLine("El nombre está en la lista {0} veces.",veces);
            }
            else
                Console.WriteLine("Tu nombre no se encuentra en la lista.");
                    
        }
    }
}
