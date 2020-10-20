using System;

namespace Ejercicio_1_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado1; //aqui se mostrará (numero1+numero2)*(numero2-numero1)
            int resultado2; //aqui se mostrará (numero1*2)-(numero2*2)

            Console.WriteLine("Introduce el primer número: ");
            numero1 = Convert.ToInt32(
                Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            numero2 = Convert.ToInt32(
                Console.ReadLine());
            resultado1 = (numero1 + numero2) * (numero2 - numero1);
            resultado2 = (numero1 * 2) - (numero2 * 2);

            Console.Write("El resultado de (a+b)*(b-a) es {0} y el resultado de a al cuadrado - b al cuadrado es {1}",resultado1,resultado2);

        }
    }
}
