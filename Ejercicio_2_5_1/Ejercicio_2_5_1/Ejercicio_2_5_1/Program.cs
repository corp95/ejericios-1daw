using System;

namespace Ejercicio_2_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una frase: ");
            string frase= Console.ReadLine();
            foreach (char letra in frase)
            {
                if (letra=='a')
                {

                    Console.WriteLine("{0} ", letra);

                }

            }


        }
    }
}
