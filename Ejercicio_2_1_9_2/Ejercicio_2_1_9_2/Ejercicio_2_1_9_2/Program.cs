using System;

namespace Ejercicio_2_1_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato1;

            Console.WriteLine("Pulsa cualquier botón: ");
            dato1 = Console.ReadLine();

            switch (dato1) 
            {
                case (","):
                case ("."):
                case (":"):
                case (";"): Console.WriteLine("{0} es un signo de puntuación.", dato1);
                break;

                case ("0"):
                case ("1"):
                case ("2"):
                case ("3"):
                case ("4"):
                case ("5"):
                case ("6"):
                case ("7"):
                case ("8"):
                case ("9"): Console.WriteLine("{0} es un número.", dato1);
                    break;
                default: Console.WriteLine("{0} es un carácter.", dato1);
                    break;

            }
        }



        
    }
}
