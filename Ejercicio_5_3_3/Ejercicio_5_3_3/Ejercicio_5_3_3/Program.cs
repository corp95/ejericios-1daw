using System;

namespace Ejercicio_5_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho;
            int alto;
            char letraUsuario;

            Console.WriteLine("Introduce el ancho: ");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el alto: ");
            alto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce una letra: ");
            letraUsuario = Convert.ToChar(Console.ReadLine());

            DibujarRectanguloHueco(ancho, alto, letraUsuario);

        }

        public static void DibujarRectanguloHueco(int alto, int ancho, char letraUsuario)
        {

            for(int i=1; i<=alto; i++)
            {
                Console.Write("{0}",letraUsuario);

                for(int j=2; j<ancho -1; j++)
                {
                    if (i == 1 || i == alto)
                        Console.Write("{0}",letraUsuario);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("{0}", letraUsuario);
            }

        }
    }
}
