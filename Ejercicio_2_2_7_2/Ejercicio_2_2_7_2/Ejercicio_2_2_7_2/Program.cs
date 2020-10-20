using System;

namespace Ejercicio_2_2_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            for (letra='L'; letra<='N'; letra++)
            {
                if ((letra == 'L') || (letra == 'N'))

                        Console.Write("{0}{0}{0}{0}{0}", letra);
                else
                    if(letra=='M')
                    Console.Write("{0}{0}{0}{0}{0}", letra);
            }                 
                            
            
        }
    }
}
