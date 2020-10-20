using System;

namespace Ejercicio_2_2_9_1
{
    class Program
    {
        static void Main(string[] args) 
        {
            int numero;
            Console.WriteLine("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

           
            for (int i=0 ; i<=numero; i++)
            {               

                if (i%9==0)
                {
                    Console.WriteLine("Múltiplo de 9: {0}", i);

                }    

            }
                        
        }
    }
}
