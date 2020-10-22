using System;

namespace Ejercicio_4_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;
               
            int[] dias =    
                {31,28,30,31,30,31,30,31,30,31,30,31};

            Console.WriteLine("Introduce un día del mes (1=enero, 12=diciembre): ");
            mes = Convert.ToInt32(Console.ReadLine());

            mes--; //Decrementamos en 1 unidad para acceder a la posición correcta.

            Console.WriteLine("El mes {0} tiene {1} días", mes+1, dias[mes]);
        }
    }
}
