using System;

namespace Ejercicio_1_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicador; //el numero a multiplicar
            int a, b, c, d, e, f, g, h, i, j; //los numeros del 1 al 10 para multiplicar el valor introducido

            Console.Write("Introduce el número a multiplicar: ");
            multiplicador = Convert.ToInt32(
                Console.ReadLine());
            a = multiplicador*1;
            b = multiplicador*2;
            c = multiplicador*3;
            d = multiplicador*4;
            e = multiplicador*5;
            f = multiplicador*6;
            g = multiplicador*7;
            h = multiplicador*8;
            i = multiplicador*9;
            j = multiplicador*10;


            Console.WriteLine("{0}X1={1}\n" +
            "{0}X2={2}\n" +
            "{0}X3={3}\n" +
            "{0}X4={4}\n" +
            "{0}X5={5}\n" +
            "{0}X6={6}\n" +
            "{0}X7={7}\n" +
            "{0}X8={8}\n" +
            "{0}X9={9}\n" +
            "{0}X10={10}"
            , multiplicador, a, b, c, d, e, f, g, h, i, j);
            
        }
    }
}
