﻿using System;

namespace Remove_All
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string palabra;
            int posicion;
            int cantidad;

            Console.WriteLine( "Introduce tu nombre: ");
            frase = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduce la palabra a eliminar: ");
            palabra = Convert.ToString(Console.ReadLine());

            cantidad = palabra.Length;

            posicion = frase.ToUpper().IndexOf(palabra.ToUpper());

            while(posicion!=-1)
            {
                frase = frase.Remove(posicion, cantidad);
                posicion = frase.ToUpper().IndexOf(palabra.ToUpper());

            }

            frase = frase.TrimStart(); //Para quitar los espacios del principio.
            frase = frase.TrimEnd(); //Para quitar los espacios del final de la frase.

            Console.WriteLine();
            Console.WriteLine("{0}", frase);
        }
    }
}
