using System.Text;
using System;

namespace Ejercicio_4_4_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra="0";
            int longitud = palabra.Length;

            Console.WriteLine("Introduce una frase: ");
            palabra = Convert.ToString(Console.ReadLine());

            StringBuilder cad = new StringBuilder(palabra);



            for (int i=0; i<=palabra[longitud]; i++)
            {
                if (palabra.IndexOf('a') >=0)
                cad[i] = 'o';

                palabra = cad.ToString();


            }

            Console.Write("{0}", palabra);
        }
    }
}
