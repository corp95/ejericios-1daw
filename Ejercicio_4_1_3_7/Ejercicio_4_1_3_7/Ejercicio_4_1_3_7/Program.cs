using System;

namespace Ejercicio_4_1_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[100];
            string nombre="";
            int i = 0;
            int j = 0;

            Console.WriteLine("Introduce un nombre o pulsa intro para terminar el programa: ");
            nombre = Convert.ToString(Console.ReadLine());

            while (nombre!="")
            {

                nombres[i] = nombre;
                i++;

                Console.WriteLine("Introduce un nombre o pulsa intro para terminar el programa: ");
                nombre = Convert.ToString(Console.ReadLine());

                if (nombres[i]=="")
                {
                    for (j = 0; j < i; j++)
                    {
                        Console.WriteLine("{0}", nombres[j]);

                    }
                }
                
            }
        }
    }
}
