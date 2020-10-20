using System;

namespace Ejercicio_2_2_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 26;
            int calculo=numero-2;


            Console.WriteLine(numero);

            do
            {             
                if (calculo <26)

                numero=numero-2;

                Console.WriteLine("{0}", numero);

            }
            
            while (numero > 10);
            Console.WriteLine("Fin");
        }
    }
}
