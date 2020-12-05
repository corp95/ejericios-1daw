using System;
using System.Text;

// --------------------------------------------
// Daniel Santonja Gosálbez
// 1º DAW
// Modalidad Presencial
// Práctica nº 2
// --------------------------------------------

namespace practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena="0";
            string letra="0";
            int contadorIntentos = 0;

            Console.Write("Cadena: ");
            cadena = Convert.ToString(Console.ReadLine());

            StringBuilder cad = new StringBuilder(cadena);
            StringBuilder cad2 = new StringBuilder(letra);

            do
            {
                Console.Write("Letra: ");
                letra = Convert.ToString(Console.ReadLine());
                letra = cad.ToString(); //Mirar lo de introducir una letra!!!!!!!!!!!!!!!!!!!

                for (int i = 0; i < cad.Length; i++) //Esto es para convertir la palabra en guiones.
                {
                    cad[i] = '-';
                }

                Console.WriteLine("{0}", cadena);

            }

            while (contadorIntentos == 6);
              {
                Console.WriteLine("R.I.P. La palabra era {0}", cadena); 
              }

        }
    }
}
