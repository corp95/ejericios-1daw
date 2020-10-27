using System;

namespace Ejercicio_4_1_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] diasMes =
                {31,28,31,30,31,30,31,30,30,31,30,31};
            int mes;
            int dia;
            int suma=0;
            int suma2;

            Console.WriteLine("Introduce un número del 1 al 12 (1=Enero, 12=Diciembre: )");
            mes = Convert.ToInt32(Console.ReadLine());
            mes--;

            Console.WriteLine("Introduce un número del 1 al 365: ");
            dia = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<mes; i++)
            {
                suma = diasMes[i] + suma; //!

            }
            suma2 = dia + suma;

            Console.WriteLine("El día {0} del mes {1} es el día correspondiente a {2}.",dia, mes++, suma2);



        }
    }
}
