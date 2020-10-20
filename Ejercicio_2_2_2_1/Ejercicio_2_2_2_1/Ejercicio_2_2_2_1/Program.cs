using System;

namespace Ejercicio_2_2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num2;
            int num1=0;
                       
            do
            {                
                Console.WriteLine("Introduce un número positivo: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                num1 = num1 + num2;

                Console.WriteLine(num1);
            }
            while (num2 > 0);
            Console.WriteLine("Pulsa cualquier botón para salir.");
                    
            
        }
    }
}
