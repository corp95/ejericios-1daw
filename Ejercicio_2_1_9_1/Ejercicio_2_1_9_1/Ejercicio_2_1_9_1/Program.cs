using System;

namespace Ejercicio_2_1_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;

            Console.WriteLine("Introduce un número: ");
            numero=Console.ReadLine();

            switch (numero)
            {
                case "1":   
                    Console.WriteLine("Uno.");
                    break;
                case "2":   
                    Console.WriteLine("Dos.");
                    break;
                case "3":
                    Console.WriteLine("Tres.");
                    break;
                case "4":
                    Console.WriteLine("Cuatro.");
                    break;
                case "5":
                    Console.WriteLine("Cinco.");
                    break;
                
                default: Console.WriteLine("Introduce un número del 1 al 5.");
                    break;
            }
        }
    }
}
