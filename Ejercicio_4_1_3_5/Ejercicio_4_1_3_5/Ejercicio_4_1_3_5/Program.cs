using System;

namespace Ejercicio_4_1_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] diasMes =
                  {31,28,31,30,31,30,31,31,30,31,30,31};
            int mes;
            int dia;
            int suma = 0;
            int suma2;
            int restaFinaldeAnyo; //aqui hay que restar 365 - el día que introduzca.

            Console.WriteLine("Introduce un día del 1 al 31: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un número del 1 al 12 (1=Enero, 12=Diciembre: )");
            mes = Convert.ToInt32(Console.ReadLine());
            mes--;
                       
            for (int i = 0; i < mes; i++)
            {
                suma = diasMes[i] + suma; 

            }
            mes++;
            suma2 = dia + suma;
            restaFinaldeAnyo = 365 - suma2;
           
            Console.WriteLine("Desde el {0} del mes {1} quedan {2} días para fin de año.", dia, mes, restaFinaldeAnyo);



        }
    }
}