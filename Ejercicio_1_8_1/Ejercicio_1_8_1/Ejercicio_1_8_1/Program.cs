using System;

namespace Ejercicio_1_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double metros = 3000; //Aqui se introducen los metros a convertir en millas
            double millas = 1609; //Esta cifra no se toca, es lo que equivale 1 metro a millas
            double conversion = metros / millas;//aqui se hace la operacion para convertir los metros a millas

            Console.WriteLine(metros+" metros son "+conversion+" millas");
        }
    }
}
